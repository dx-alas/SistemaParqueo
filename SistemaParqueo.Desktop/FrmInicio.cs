using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using SistemaParqueo.Desktop;

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

            ActualizarEstadoVisualCorte();
        }

        private void ActualizarEstadoVisualCorte()
        {
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

        private bool ObtenerAutorizacion(out int idAutorizador)
        {
            idAutorizador = Sesion.UsuarioActual.UsuarioId;

            if (Sesion.UsuarioActual.RolId == 1) return true;

            using (FrmAutorizacion frm = new FrmAutorizacion())
            {
                if (frm.ShowDialog() != DialogResult.OK) return false;

                idAutorizador = frm.UsuarioAutorizadorId;
            }

            return true;
        }

        private void AbrirCorte()
        {
            if (!ObtenerAutorizacion(out int idAutorizador)) return;

            using (FrmInicioCorteCaja frm = new FrmInicioCorteCaja())
            {
                if (frm.ShowDialog() != DialogResult.OK) return;

                Sesion.CorteActivo = CorteCajaBL.Instance.AbrirCorte(frm.MontoInicial,
                    frm.ObservacionInicial,
                    idAutorizador
                );
            }

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

            if (!ObtenerAutorizacion(out int idAutorizador)) return;

            decimal totalRecaudado = TicketBL.Instance
                .SelectAll()
                .Where(t =>
                    t.CorteId == Sesion.CorteActivo.CorteId &&
                    t.HoraSalida != null)
                .Sum(t => t.Total ?? 0);

            using (FrmCierreCorteCaja frm = new FrmCierreCorteCaja())
            {
                frm.MontoCalculado = totalRecaudado;

                if (frm.ShowDialog() != DialogResult.OK) return;

                CorteCajaBL.Instance.CerrarCorte(
                    Sesion.CorteActivo.CorteId,
                    frm.MontoTotal,
                    frm.ObservacionFinal,
                    idAutorizador
                );
            }

            Sesion.CorteActivo = null;
            MessageBox.Show("Corte de caja cerrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarEstadoCorte();
            txtBarcode.Focus();
        }

        private void btnCerrarCorte_Click(object sender, EventArgs e)
        {
            if (Sesion.CorteActivo == null) AbrirCorte();
            else CerrarCorte();
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
            int ocupados = TicketBL.Instance.SelectAll().Count(t => t.HoraSalida == null);
            int disponibles = total - ocupados;

            lblNumVehiculo.Text = ocupados.ToString();
            lblInformacion.Text = $"En Parqueo: {ocupados} / Cantidad Total: {total} / Espacios Disponibles: {disponibles}";
            pbCapacidad.Minimum = 0;
            pbCapacidad.Maximum = total;
            pbCapacidad.Value = ocupados;
        }
        // ---- Sección Informacion Dinamica Finaliza ----

        // ---- Sección Gestión BARCODE y DGV Inicia -----
        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Length >= 9)
            {
                ProcesarCodigo();
            }
        }

        private void ProcesarCodigo()
        {
            string codigo = txtBarcode.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo)) return;

            try
            {
                if (Sesion.CorteActivo == null)
                {
                    MessageBox.Show("Debe abrir un corte de caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarBarcode();
                    return;
                }

                var tarjeta = TarjetaBL.Instance.SelectByCodigo(codigo);

                if (tarjeta == null)
                {
                    MessageBox.Show("Tarjeta no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarBarcode();
                    return;
                }

                var ticketActivo = TicketBL.Instance.GetTicketActivoByTarjeta(tarjeta.TarjetaId);

                if (ticketActivo == null)
                    RegistrarEntrada(tarjeta.TarjetaId);

                else
                    RegistrarSalida(ticketActivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No hay cliente asociado a la tarjeta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    if (frm.ShowDialog() != DialogResult.OK) return;

                    vehiculoSeleccionado = frm.VehiculoSeleccionado;

                    if (vehiculoSeleccionado == null)
                    {
                        MessageBox.Show("Debe seleccionar un vehículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            TicketBL.Instance.RegistrarEntrada(
                tarjetaId,
                vehiculoSeleccionado.VehiculoId,
                Sesion.UsuarioActual.UsuarioId,
                Sesion.CorteActivo.CorteId
            );

            var tarjeta = TarjetaBL.Instance.SelectById(tarjetaId);

            var tipoVehiculo = TipoVehiculoBL.Instance.SelectAll().FirstOrDefault(tv => tv.TipoVehiculoId == vehiculoSeleccionado.TipoVehiculoId);

            // OBTENER TIPO CLIENTE
            var tipoCliente = TipoClienteBL.Instance.SelectAll().FirstOrDefault(tc => tc.TipoClienteId == cliente.TipoClienteId);

            // PRECIO NORMAL
            decimal precioEntrada = tipoVehiculo.Precio;

            // SI ES DOCENTE NO PAGA
            if (tipoCliente != null &&
                tipoCliente.Nombre.ToUpper() == "DOCENTE")
            {
                precioEntrada = 0;
            }

            TicketPrinter.ImprimirEntrada(
                tarjeta.Codigo,
                vehiculoSeleccionado.Placa,
                cliente.Nombre + " " + cliente.Apellido,
                precioEntrada
            );

            CargarEstadoParqueo();
            CargarVehiculosActivos();
        }

        private void RegistrarSalida(Ticket ticket)
        {
            decimal total = TicketBL.Instance.RegistrarSalida(
                ticket,
                Sesion.CorteActivo.CorteId
            );

            DateTime fechaEntrada = DateTime.Today.Add(ticket.HoraEntrada);

            var tarjeta = TarjetaBL.Instance.SelectById(ticket.TarjetaId);

            var cliente = ClienteBL.Instance.SelectAll().FirstOrDefault(c => c.TarjetaId == ticket.TarjetaId);

            var vehiculo = VehiculoBL.Instance.SelectAll().FirstOrDefault(v => v.ClienteId == cliente.ClienteId);

            // OBTENER TIPO CLIENTE
            var tipoCliente = TipoClienteBL.Instance.SelectAll().FirstOrDefault(tc => tc.TipoClienteId == cliente.TipoClienteId);

            // SI ES DOCENTE NO PAGA
            if (tipoCliente != null &&
                tipoCliente.Nombre.ToUpper() == "DOCENTE")
            {
                total = 0;
            }

            TicketPrinter.ImprimirSalida(
                tarjeta.Codigo,
                vehiculo.Placa,
                cliente.Nombre + " " + cliente.Apellido,
                total,
                fechaEntrada
            );

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
                             HoraEntrada = DateTime.Today.Add(t.HoraEntrada).ToString("hh:mm:ss tt"),
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

        // --- Sección Logica de Multas Inicia ---
        private void EvaluarMulta()
        {
            btnMulta.Enabled = ticketSeleccionado != null && ticketSeleccionado.MultaId == null;
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvVehiculos.Rows[e.RowIndex];
            string codigoTarjeta = fila.Cells[0].Value?.ToString();

            if (string.IsNullOrEmpty(codigoTarjeta)) return;

            var tarjeta = TarjetaBL.Instance.SelectAll().FirstOrDefault(t => t.Codigo == codigoTarjeta);

            if (tarjeta == null) return;

            ticketSeleccionado = TicketBL.Instance.SelectAll().FirstOrDefault(t => t.TarjetaId == tarjeta.TarjetaId && t.HoraSalida == null);

            EvaluarMulta();
        }

        private void btnMulta_Click(object sender, EventArgs e)
        {
            if (ticketSeleccionado == null) return;

            try
            {
                ticketSeleccionado = TicketBL.Instance.AplicarMulta(ticketSeleccionado.TicketId);
                CargarVehiculosActivos();
                CargarEstadoParqueo();
                EvaluarMulta();

                var multa = MultaTicketBL.Instance.SelectAll().FirstOrDefault();
                MessageBox.Show($"Multa de extravío aplicada: ${multa.Precio:0.00}\nSe cobrará al momento de la salida.", "Multa Aplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // --- Sección Logica de Multas Finaliza ---

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}