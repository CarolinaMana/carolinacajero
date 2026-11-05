
using System;

namespace carolinacajero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CodeArt Academy - Mini ATM V1";
            Console.WriteLine("=== SISTEMA MINI ATM (MODALIDAD POO I) ===\n");

            Cuenta cuentaUsuario = new Cuenta("987654321", 25000.00);
            Transaccion registroOperacion = new Transaccion("Retiro de Efectivo", 5000.00, DateTime.Now);

            Console.WriteLine(">>> Inicialización y Consulta de Estados:");
            Console.WriteLine($"Cuenta ID: {cuentaUsuario.NumeroCuenta}");
            Console.WriteLine($"Saldo Base Inicial: ${cuentaUsuario.Saldo:N2}\n");

            Console.WriteLine(">>> Demostración de Comportamiento Lógico:");

            cuentaUsuario.Depositar(1500.00);

            bool retiroAprobado = cuentaUsuario.Retirar(registroOperacion.Monto);

            if (retiroAprobado)
            {
                Console.WriteLine("\n>>> Generando Comprobante:");
                registroOperacion.MostrarDetalle();
            }

            Console.WriteLine("Presione cualquier tecla para finalizar el prototipo de consola...");
            Console.ReadKey();
        }
    }
}
