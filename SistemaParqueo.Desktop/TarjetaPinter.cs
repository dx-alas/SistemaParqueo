using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace SistemaParqueo.Desktop
{
    public class TarjetaPrinter
    {
        // GENERAR CÓDIGO DE BARRAS
        private static Bitmap GenerarCodigoBarra(string codigo)
        {
            BarcodeWriter writer = new BarcodeWriter();

            writer.Format = BarcodeFormat.CODE_128;

            writer.Options = new EncodingOptions
            {
                Width = 280,
                Height = 70,
                Margin = 1
            };

            return writer.Write(codigo);
        }

        // IMPRIMIR TARJETA
        public static void ImprimirTarjeta(
            string codigoTarjeta,
            string cliente,
            string tipoDocumento,
            string documento
        )
        {
            Bitmap barcode = GenerarCodigoBarra(codigoTarjeta);

            string rutaLogo =
                Path.Combine(
                    Application.StartupPath,
                    "Recursos",
                    "logo.png"
                );

            string rutaLogo2 =
                Path.Combine(
                    Application.StartupPath,
                    "Recursos",
                    "logo2.png"
                );

            Image logo = null;
            Image logo2 = null;

            if (File.Exists(rutaLogo))
                logo = Image.FromFile(rutaLogo);

            if (File.Exists(rutaLogo2))
                logo2 = Image.FromFile(rutaLogo2);

            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;

                // FONDO
                g.FillRectangle(
                    Brushes.White,
                    new Rectangle(20, 20, 500, 300)
                );

                // BORDE
                g.DrawRectangle(
                    Pens.Black,
                    new Rectangle(20, 20, 500, 300)
                );

                // LOGO PRINCIPAL
                if (logo != null)
                {
                    g.DrawImage(
                        logo,
                        35,
                        35,
                        150,
                        70
                    );
                }

                // TITULO
                g.DrawString(
                    "SISTEMA PARQUEO",
                    new Font("Arial", 18, FontStyle.Bold),
                    Brushes.Black,
                    190,
                    40
                );

                // NOMBRE
                g.DrawString(
                    cliente,
                    new Font("Arial", 16, FontStyle.Bold),
                    Brushes.Black,
                    40,
                    120
                );

                // TIPO DOCUMENTO
                g.DrawString(
                    tipoDocumento,
                    new Font("Arial", 11, FontStyle.Bold),
                    Brushes.Black,
                    40,
                    155
                );

                // DOCUMENTO
                g.DrawString(
                    documento,
                    new Font("Arial", 12),
                    Brushes.Black,
                    40,
                    180
                );

                // CODIGO BARRA
                g.DrawImage(
                    barcode,
                    110,
                    210,
                    280,
                    70
                );

                // SONSONATE
                g.DrawString(
                    "Sonsonate",
                    new Font("Arial", 9),
                    Brushes.Black,
                    35,
                    295
                );

                // LOGO PEQUEÑO
                if (logo2 != null)
                {
                    g.DrawImage(
                        logo2,
                        455,
                        260,
                        40,
                        40
                    );
                }
            };

            try
            {
                if (!pd.PrinterSettings.IsValid)
                {
                    MessageBox.Show(
                        "No hay impresora configurada."
                    );
                    return;
                }

                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al imprimir: " + ex.Message
                );
            }
        }
    }
}