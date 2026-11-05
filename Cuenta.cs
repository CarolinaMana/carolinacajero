
using System;

namespace carolinacajero
{
    public class Cuenta
    {
        public string NumeroCuenta { get; set; }
        public double Saldo { get; private set; }

        public Cuenta(string numeroCuenta, double saldoInicial)
        {
            NumeroCuenta = numeroCuenta;
            Saldo = saldoInicial;
        }

        public void Depositar(double monto)
        {
            if (monto > 0)
            {
                Saldo += monto;
                Console.WriteLine($"[Cuenta] Depósito exitoso. Nuevo Saldo: ${Saldo:N2}");
            }
        }

        public bool Retirar(double monto)
        {
            if (monto > 0 && monto <= Saldo)
            {
                Saldo -= monto;
                Console.WriteLine($"[Cuenta] Retiro exitoso. Nuevo Saldo: ${Saldo:N2}");
                return true;
            }
            Console.WriteLine("[Cuenta] Error: Fondos insuficientes o monto inválido.");
            return false;
        }
    }
}
