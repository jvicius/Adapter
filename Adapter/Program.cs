using System;
using System.Runtime.CompilerServices;
using Adapter.Adapters;
using Adapter.Models;
using System.Windows.Forms;

namespace Adapter
{
    class Program
    {
        private static CajaEuros _caja;
        private static ConversorPesos _conversor;

        static void Main(string[] args)
        {
            _caja = new CajaEuros();
            _conversor = new ConversorPesos(_caja);
            var key = new ConsoleKeyInfo();
            while (!(key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.NumPad5))
            {
                key = ShowMenu();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        depositarEuros();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        retirarEuros();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                       
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                       
                        break;


                }
            }
        }

        private static void depositarEuros()
        {
            Console.Clear();
            Console.WriteLine("Monto a depositar:");
            try
            {
                var amount = Console.ReadLine();
                _caja.DepositarEuros(Convert.ToDouble(amount));
            }
            catch 
            {
                MessageBox.Show("Monto Incorrecto");
            }
        }

        private static void retirarEuros()
        {
            Console.Clear();
            Console.WriteLine("Monto a retirar:");
            try
            {
                var amount = Console.ReadLine();
                if (!_caja.RetirarEuros(Convert.ToDouble(amount)))
                {
                    MessageBox.Show("Saldo Insuficiente");
                }
            }
            catch 
            {
                MessageBox.Show("Monto Incorrecto");
            }
        }

        private static ConsoleKeyInfo ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"Saldo en Euros: {_caja.ObtenerSaldo()}");
            Console.WriteLine("1. Depositar Euros");
            Console.WriteLine("2. Retirar Euros");
            Console.WriteLine("5. Exit");
            return Console.ReadKey();
        }

        private static void depositarPesos()
        {
            Console.Clear();
            Console.WriteLine("Monto a depositar:");
            try
            {
                var amount = Console.ReadLine();
                _conversor.DepositarPesos(Convert.ToDouble(amount));
            }
            catch
            {
                MessageBox.Show("Monto Incorrecto");
            }
        }

        private static void retirarPesos()
        {
            Console.Clear();
            Console.WriteLine("Monto a retirar:");
            try
            {
                var amount = Console.ReadLine();
                if (!_conversor.RetirarPesos(Convert.ToDouble(amount)))
                {
                    MessageBox.Show("Saldo Insuficiente");
                }
            }
            catch
            {
                MessageBox.Show("Monto Incorrecto");
            }
        }

    }
}
