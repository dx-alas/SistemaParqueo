using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    public partial class FrmInicio : Form
    {

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

            lblInformacion.Text =
                $"En Parqueo: {ocupados} / Cantidad Total: {total} / Espacios Disponibles: {disponibles}";
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
                MessageBox.Show("No hay cliente asociado a la tarjeta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var vehiculo = vehiculos.FirstOrDefault(v => v.ClienteId == cliente.ClienteId);

            if (vehiculo == null)
            {
                MessageBox.Show("No hay vehículo asociado al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tipoVehiculo = TipoVehiculoBL.Instance.SelectById(vehiculo.TipoVehiculoId);

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
                TipoVehiculoId = vehiculo.TipoVehiculoId,
                PrecioAplicado = tipoVehiculo.Precio,
                MultaId = null
            };

            TicketBL.Instance.Insert(nuevo);

            MessageBox.Show("Entrada registrada correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarVehiculosActivos();
        }

        private void RegistrarSalida(Ticket ticket)
        {
            TimeSpan horaSalida = DateTime.Now.TimeOfDay;

            TimeSpan tiempo = horaSalida - ticket.HoraEntrada;

            if (tiempo.TotalMinutes <= 0)
                tiempo = TimeSpan.FromMinutes(1);

            decimal horas = (decimal)Math.Ceiling(tiempo.TotalHours);
            decimal total = horas * ticket.PrecioAplicado;

            ticket.HoraSalida = horaSalida;
            ticket.Total = total;
            ticket.EstadoTicketId = 2; // Cerrado
            ticket.CorteId = Sesion.CorteActivo.CorteId;

            TicketBL.Instance.Update(ticket);

            MessageBox.Show($"Salida registrada\nTotal: ${total: 0.00}", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarVehiculosActivos();
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
                         join c in clientes on t.TarjetaId equals c.TarjetaId
                         join v in vehiculos on c.ClienteId equals v.ClienteId
                         join ta in tarjetas on t.TarjetaId equals ta.TarjetaId
                         join tc in tiposCliente on c.TipoClienteId equals tc.TipoClienteId
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

        // ---- Sección Gestión BARCODE y DGV Finaliza -----
    }
}