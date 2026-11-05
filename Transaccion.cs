
using System;

namespace carolinacajero
{
    public class Transaccion
    {
        public string Tipo { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Transaccion(string tipo, double monto, DateTime fecha)
        {
            Tipo = tipo;
            Monto = monto;
            Fecha = fecha;
        }

        public void MostrarDetalle()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("        DETALLE DE TRANSACCIÓN        ");
            Console.WriteLine("======================================");
            Console.WriteLine($"Fecha:  {Fecha:dd/MM/yyyy HH:mm:ss}");
            Console.WriteLine($"Tipo:   {Tipo}");
            Console.WriteLine($"Monto:  ${Monto:N2}");
            Console.WriteLine("======================================\n");
        }
    }
}
