using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    public partial class FrmInicio : Form
    {
        private Ticket ticketSeleccionado;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            dgvVehiculos.AutoGenerateColumns = false;
            CargarEstadoCorte();
            CargarVehiculosActivos();
            CargarEstadoParqueo();
            txtBarcode.Focus();
        }

        // ---- Sección Gestión Corte de Caja Inicia ----
        private void CargarEstadoCorte()
        {
            Sesion.CorteActivo = CorteCajaBL.Instance.GetCorteActivo();

            if (Sesion.CorteActivo != null)
            {
                lblEstado.Text = "Estado: Caja Abierta";
                txtCajero.Text = Sesion.UsuarioActual?.Nombre ?? "Desconocido";
                txtTurnoIniciado.Text = Sesion.CorteActivo.Fecha.ToShortDateString() + " " + Sesion.CorteActivo.HoraInicio.ToString(@"hh\:mm");
                txtMontoInicial.Text = Sesion.CorteActivo.MontoInicial?.ToString("0.00") ?? "0.00";
                btnCerrarCorte.Text = "Cerrar Corte de Caja";
            }
            else
            {
                lblEstado.Text = "Estado: Caja Cerrada";
                txtCajero.Clear();
                txtTurnoIniciado.Clear();
                txtMontoInicial.Clear();
                btnCerrarCorte.Text = "Abrir Corte de Caja";
            }

        }

        private void AbrirCorte()
        {
            int idAutorizador = Sesion.UsuarioActual.UsuarioId;

            if (Sesion.UsuarioActual.RolId != 1) //Autorizacion
            {
                using (FrmAutorizacion frm = new FrmAutorizacion())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;

                    idAutorizador = frm.UsuarioAutorizadorId;
                }
            }

            decimal montoInicial;
            string observacion;

            using (FrmInicioCorteCaja frm = new FrmInicioCorteCaja())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                montoInicial = frm.MontoInicial;
                observacion = frm.ObservacionInicial;
            }

            CorteCaja nuevo = new CorteCaja
            {
                Fecha = DateTime.Now.Date,
                HoraInicio = DateTime.Now.TimeOfDay,
                MontoInicial = montoInicial,
                ObservacionInicial = observacion,
                UsuarioAperturaId = idAutorizador
            };

            CorteCajaBL.Instance.Insert(nuevo);

            Sesion.CorteActivo = CorteCajaBL.Instance.GetCorteActivo();

            MessageBox.Show("Corte de caja abierto correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarEstadoCorte();
        }

        private void CerrarCorte()
        {
            if (Sesion.CorteActivo == null)
            {
                MessageBox.Show("No hay corte activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idAutorizador = Sesion.UsuarioActual.UsuarioId;

            if (Sesion.UsuarioActual.RolId != 1)
            {
                using (FrmAutorizacion frm = new FrmAutorizacion())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;

                    idAutorizador = frm.UsuarioAutorizadorId;
                }
            }

            decimal montoTotal;
            string observacionFinal;

            using (FrmCierreCorteCaja frm = new FrmCierreCorteCaja())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                montoTotal = frm.MontoTotal;
                observacionFinal = frm.ObservacionFinal;
            }

            Sesion.CorteActivo.HoraEntrega = DateTime.Now.TimeOfDay;
            Sesion.CorteActivo.MontoTotal = montoTotal;
            Sesion.CorteActivo.ObservacionFinal = observacionFinal;
            Sesion.CorteActivo.UsuarioCierreId = idAutorizador;

            CorteCajaBL.Instance.Update(Sesion.CorteActivo);

            Sesion.CorteActivo = null;

            MessageBox.Show("Corte de caja cerrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarEstadoCorte();

            txtBarcode.Focus();
        }

        private void btnCerrarCorte_Click(object sender, EventArgs e)
        {
            if (Sesion.CorteActivo == null)
                AbrirCorte();
            else
                CerrarCorte();
        }
        // ---- Sección Gestión Corte de Caja Finaliza ----

        // ---- Sección Informacion Dinamica Inicia ----
        private void CargarEstadoParqueo()
        {
            var parqueos = ParqueoBL.Instance.SelectAll();

            if (parqueos == null || parqueos.Count == 0)
            {
                lblNumVehiculo.Text = "0";
                lblInformacion.Text = "Sin datos de parqueo";
                return;
            }

            var parqueo = parqueos.First();
            int total = parqueo.CapacidadTotal;

            int ocupados = TicketBL.Instance.SelectAll()
                .Count(t => t.HoraSalida == null);

            int disponibles = total - ocupados;

            lblNumVehiculo.Text = ocupados.ToString();
            lblInformacion.Text =  $"En Parqueo: {ocupados} / Cantidad Total: {total} / Espacios Disponibles: {disponibles}";

            pbCapacidad.Minimum = 0;
            pbCapacidad.Maximum = total;
            pbCapacidad.Value = ocupados;
        }
        // ---- Sección Informacion Dinamica Finaliza ----

        // ---- Sección Gestión BARCODE y DGV Inicia -----
        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Length >= 8)
            {
                ProcesarCodigo();
            }
        }

        private void ProcesarCodigo()
        {
            string codigo = txtBarcode.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
                return;

            try
            {
                if (Sesion.CorteActivo == null)
                {
                    MessageBox.Show("Debe abrir un corte de caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarBarcode();
                    return;
                }

                var tarjeta = TarjetaBL.Instance.SelectByCodigo(codigo); //Buscar tarjetas

                if (tarjeta == null)
                {
                    MessageBox.Show("Tarjeta no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarBarcode();
                    return;
                }

                var ticketActivo = TicketBL.Instance.GetTicketActivoByTarjeta(tarjeta.TarjetaId); //Ticket Activo

                if (ticketActivo == null)
                {
                    RegistrarEntrada(tarjeta.TarjetaId);
                }
                else
                {
                    RegistrarSalida(ticketActivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LimpiarBarcode();
        }

        private void RegistrarEntrada(int tarjetaId)
        {
            var vehiculos = VehiculoBL.Instance.SelectAll();
            var clientes = ClienteBL.Instance.SelectAll();

            var cliente = clientes.FirstOrDefault(c => c.TarjetaId == tarjetaId);

            if (cliente == null)
            {
                MessageBox.Show("No hay cliente asociado a la tarjeta", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener TODOS los vehículos del cliente
            var vehiculosCliente = vehiculos.Where(v => v.ClienteId == cliente.ClienteId).ToList();

            if (vehiculosCliente.Count == 0)
            {
                MessageBox.Show("No hay vehículo asociado al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Vehiculo vehiculoSeleccionado;

            if (vehiculosCliente.Count == 1)
            {
                vehiculoSeleccionado = vehiculosCliente.First();
            }
            else
            {
                using (FrmSeleccionVehiculo frm = new FrmSeleccionVehiculo(vehiculosCliente))
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;

                    vehiculoSeleccionado = frm.VehiculoSeleccionado;

                    if (vehiculoSeleccionado == null)
                    {
                        MessageBox.Show("Debe seleccionar un vehículo", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            var tipoVehiculo = TipoVehiculoBL.Instance.SelectById(vehiculoSeleccionado.TipoVehiculoId);

            if (tipoVehiculo == null)
            {
                MessageBox.Show("Tipo de vehículo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ticket nuevo = new Ticket
            {
                Fecha = DateTime.Now.Date,
                HoraEntrada = DateTime.Now.TimeOfDay,
                TarjetaId = tarjetaId,
                CorteId = Sesion.CorteActivo.CorteId,
                EstadoTicketId = 1,
                UsuarioId = Sesion.UsuarioActual.UsuarioId,
                EstadoPermanenciaId = 1,
                TipoVehiculoId = vehiculoSeleccionado.TipoVehiculoId,
                PrecioAplicado = tipoVehiculo.Precio,
                MultaId = null,
                VehiculoId = vehiculoSeleccionado.VehiculoId
            };

            TicketBL.Instance.Insert(nuevo);
            MessageBox.Show("Entrada registrada correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            CargarEstadoParqueo();
            CargarVehiculosActivos();
        }

        private void RegistrarSalida(Ticket ticket)
        {
            TimeSpan horaSalida = DateTime.Now.TimeOfDay;

            ticket.HoraSalida = horaSalida;

            decimal total = ticket.PrecioAplicado;

            if (ticket.MultaId != null)
            {
                var multa = MultaTicketBL.Instance.SelectById(ticket.MultaId.Value);
                if (multa != null)
                {
                    total += multa.Precio;
                }
            }

            ticket.Total = total;
            ticket.EstadoTicketId = 2;
            ticket.CorteId = Sesion.CorteActivo.CorteId;

            TicketBL.Instance.Update(ticket);
            MessageBox.Show($"Salida registrada\nTotal: ${ticket.Total:0.00}", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarVehiculosActivos();
            CargarEstadoParqueo();
        }

        private void LimpiarBarcode()
        {
            txtBarcode.Clear();
            txtBarcode.Focus();
        }

        private void CargarVehiculosActivos()
        {
            var tickets = TicketBL.Instance.SelectAll();
            var vehiculos = VehiculoBL.Instance.SelectAll();
            var clientes = ClienteBL.Instance.SelectAll();
            var tarjetas = TarjetaBL.Instance.SelectAll();
            var tiposCliente = TipoClienteBL.Instance.SelectAll();

            var query = (from t in tickets
                         join ta in tarjetas on t.TarjetaId equals ta.TarjetaId
                         join c in clientes on ta.TarjetaId equals c.TarjetaId
                         join tc in tiposCliente on c.TipoClienteId equals tc.TipoClienteId
                         join v in vehiculos on t.VehiculoId equals (int?)v.VehiculoId
                         where t.HoraSalida == null
                         select new
                         {
                             Tarjeta = ta.Codigo,
                             Placa = v.Placa,
                             HoraEntrada = t.HoraEntrada,
                             TipoCliente = tc.Nombre,
                             Cliente = c.Nombre + " " + c.Apellido
                         }).ToList();

            dgvVehiculos.DataSource = null;
            dgvVehiculos.DataSource = query;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorialSalidas frm = new FrmHistorialSalidas();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
        }

        // ---- Sección Gestión BARCODE y DGV Finaliza -----

        // LOGICA MULTAS
        private void EvaluarMulta()
        {
            btnMulta.Enabled = ticketSeleccionado != null && ticketSeleccionado.MultaId == null;
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvVehiculos.Rows[e.RowIndex];

            string codigoTarjeta = fila.Cells["Tarjeta"].Value?.ToString();

            if (string.IsNullOrEmpty(codigoTarjeta)) return;

            var tarjeta = TarjetaBL.Instance.SelectAll().FirstOrDefault(t => t.Codigo == codigoTarjeta);

            if (tarjeta == null) return;

            ticketSeleccionado = TicketBL.Instance.SelectAll().FirstOrDefault(t => t.TarjetaId == tarjeta.TarjetaId && t.HoraSalida == null);

            EvaluarMulta();
        }

        private void btnMulta_Click(object sender, EventArgs e)
        {
            if (ticketSeleccionado == null)
                return;

            if (ticketSeleccionado.MultaId != null)
            {
                MessageBox.Show("Este ticket ya tiene multa aplicada", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var multa = MultaTicketBL.Instance.SelectAll().FirstOrDefault(); //Aplicar primera y unica multa

            if (multa == null)
            {
                MessageBox.Show("Multa no configurada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ticketSeleccionado.MultaId = multa.MultaId;

            TicketBL.Instance.Update(ticketSeleccionado);

            ticketSeleccionado = TicketBL.Instance.SelectAll()
                .FirstOrDefault(t => t.TicketId == ticketSeleccionado.TicketId);

            CargarVehiculosActivos();
            CargarEstadoParqueo();

            EvaluarMulta();

            MessageBox.Show($"Multa de extravío aplicada: ${multa.Precio:0.00}\nSe cobrará al momento de la salida.", "Multa Aplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}