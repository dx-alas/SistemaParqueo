using SistemaParqueo.Entities;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    public class TicketPrinter
    {
        private static string contenido = "";

        public static void ImprimirEntrada(
    string tarjeta,
    string placa,
    string cliente,
    decimal precio
)
        {
            contenido =
        $@"

           ENTRADA

Tarjeta : {tarjeta}

Placa   : {placa}

Cliente :
{cliente}

Hora Entrada:
{DateTime.Now:dd/MM/yyyy hh:mm tt}

Precio:
${precio:0.00}

";

            Imprimir();
        }

        public static void ImprimirSalida(
    string tarjeta,
    string placa,
    string cliente,
    decimal monto,
    DateTime fechaEntrada
)
        {
            contenido =
        $@"

            SALIDA

Tarjeta : {tarjeta}

Placa   : {placa}

Cliente :
{cliente}

Hora Entrada:
{fechaEntrada:dd/MM/yyyy hh:mm tt}

Hora Salida:
{DateTime.Now:dd/MM/yyyy hh:mm tt}

Monto:
${monto:0.00}

";

            Imprimir();
        }

        //private static void Imprimir()
        //{
        //    PrintDocument pd = new PrintDocument();

        //    pd.PrintPage += (sender, e) =>
        //    {
        //        Font font = new Font("Consolas", 12);

        //        e.Graphics.DrawString(
        //            contenido,
        //            font,
        //            Brushes.Black,
        //            new RectangleF(0, 0, 300, 800)
        //        );
        //    };

        //    pd.Print();
        //}
        private static void Imprimir()
        {
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (sender, e) =>
            {
                Font font = new Font("Consolas", 12);

                e.Graphics.DrawString(
                    contenido,
                    font,
                    Brushes.Black,
                    new RectangleF(0, 0, 300, 800)
                );
            };

            try
            {
                if (!pd.PrinterSettings.IsValid)
                {
                    MessageBox.Show("No hay impresora instalada o configurada.");
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