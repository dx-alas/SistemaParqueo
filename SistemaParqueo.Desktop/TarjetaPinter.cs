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
                    new Rectangle(0, 0, 300, 800)
                );

                // BORDE
                g.DrawRectangle(
                    Pens.Black,
                    new Rectangle(0, 0, 300, 350)
                );

                // LOGO PRINCIPAL
                if (logo != null)
                {
                    g.DrawImage(
                        logo,
                        20,
                        35,
                        250,
                        70
                    );
                }

                // TITULO
                g.DrawString(
                    "SISTEMA PARQUEO",
                    new Font("Arial", 18, FontStyle.Bold),
                    Brushes.Black,
                    15,
                    15
                );

                // NOMBRE
                g.DrawString(
                    cliente,
                    new Font("Arial", 10, FontStyle.Bold),
                    Brushes.Black,
                    10,
                    120
                );

                // TIPO DOCUMENTO
                g.DrawString(
                    tipoDocumento,
                    new Font("Arial", 10, FontStyle.Bold),
                    Brushes.Black,
                    10,
                    155
                );

                // DOCUMENTO
                g.DrawString(
                    documento,
                    new Font("Arial", 10),
                    Brushes.Black,
                    10,
                    180
                );

                // CODIGO BARRA
                g.DrawImage(
                    barcode,
                    20,
                    210,
                    260,
                    70
                );

                // SONSONATE
                g.DrawString(
                    "Sonsonate",
                    new Font("Arial", 10),
                    Brushes.Black,
                    35,
                    295
                );
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