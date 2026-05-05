using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SistemaParqueo.Desktop
{
    public partial class FrmHistorialSalidas : Form
    {
        public FrmHistorialSalidas()
        {
            InitializeComponent();
        }

        private void FrmHistorialSalidas_Load(object sender, EventArgs e)
        {
            dgvHistorial.AutoGenerateColumns = false;

            CargarHistorial();
            CargarResumen();
            CargarCorteActual();
        }

        private void CargarHistorial()
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
                         where t.HoraSalida != null
                         select new
                         {
                             Tarjeta = ta.Codigo,
                             Placa = v.Placa,
                             HoraInicio = t.HoraEntrada,
                             Salida = t.HoraSalida,
                             TipoCliente = tc.Nombre,
                             Estudiante = c.Nombre + " " + c.Apellido,
                             Monto = t.Total
                         }).ToList();

            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = query;
        }

        private void CargarResumen()
        {
            var tickets = TicketBL.Instance.SelectAll();

            int totalCerrados = tickets.Count(t => t.HoraSalida != null);

            lblNumTickets.Text = totalCerrados.ToString();
        }

        private void CargarCorteActual()
        {
            if (Sesion.CorteActivo != null)
            {
                txtCorteCajaActual.Text = $"#{Sesion.CorteActivo.CorteId}";
            }
            else
            {
                txtCorteCajaActual.Text = "Sin corte activo";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHistorial.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar");
                    return;
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "PDF (*.pdf)|*.pdf";
                saveFile.FileName = "Historial_Salidas.pdf";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(doc, new FileStream(saveFile.FileName, FileMode.Create));

                    doc.Open();

                    Paragraph title = new Paragraph("HISTORIAL DE SALIDAS\n\n",
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);

                    PdfPTable table = new PdfPTable(dgvHistorial.Columns.Count);
                    table.WidthPercentage = 100;

                    foreach (DataGridViewColumn column in dgvHistorial.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        table.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dgvHistorial.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }

                    doc.Add(table);
                    doc.Close();

                    MessageBox.Show("PDF exportado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}