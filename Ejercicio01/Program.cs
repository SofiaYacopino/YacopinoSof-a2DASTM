using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Ejercicio01
{
    class Program
    {
        private static Banco banco;

        static void Main(string[] args)
        {
            banco = new Banco();
            Console.WriteLine("=== SISTEMA BANCARIO ===");
            Console.WriteLine($"Bienvenido a {banco.Nombre}");
            Console.WriteLine();

            bool continuar = true;

            while (continuar)
            {
                try
                {
                    MostrarMenu();
                    int opcion = LeerOpcion();
                    continuar = ProcesarOpcion(opcion);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Crear Cuenta de Ahorros");
            Console.WriteLine("2. Crear Cuenta Corriente");
            Console.WriteLine("3. Realizar Depósito");
            Console.WriteLine("4. Realizar Retiro");
            Console.WriteLine("5. Consultar Saldo");
            Console.WriteLine("6. Listar Todas las Cuentas");
            Console.WriteLine("7. Salir");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");
        }

        static int LeerOpcion()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                throw new DatosInvalidosException("Debe ingresar un número válido.");
            }
        }

        static bool ProcesarOpcion(int opcion)
        {
            try
            {
                switch (opcion)
                {
                    case 1:
                        CrearCuentaAhorros();
                        break;
                    case 2:
                        CrearCuentaCorriente();
                        break;
                    case 3:
                        RealizarDeposito();
                        break;
                    case 4:
                        RealizarRetiro();
                        break;
                    case 5:
                        ConsultarSaldo();
                        break;
                    case 6:
                        ListarCuentas();
                        break;
                    case 7:
                        Console.WriteLine("¡Gracias por usar el sistema bancario!");
                        return false;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
            catch (FondosInsuficientesException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (LimiteRetirosExcedidoException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (DatosInvalidosException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            return true;
        }

        static void CrearCuentaAhorros()
        {
            Console.WriteLine("\n=== CREAR CUENTA DE AHORROS ===");
            Console.Write("Número de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            Console.Write("Titular: ");
            string titular = Console.ReadLine();

            banco.CrearCuentaAhorros(numeroCuenta, titular);
            Console.WriteLine("Cuenta de ahorros creada exitosamente.");
        }

        static void CrearCuentaCorriente()
        {
            Console.WriteLine("\n=== CREAR CUENTA CORRIENTE ===");
            Console.Write("Número de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            Console.Write("Titular: ");
            string titular = Console.ReadLine();

            banco.CrearCuentaCorriente(numeroCuenta, titular);
            Console.WriteLine("Cuenta corriente creada exitosamente.");
        }

        static void RealizarDeposito()
        {
            Console.WriteLine("\n=== REALIZAR DEPÓSITO ===");
            Console.Write("Número de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            Console.Write("Monto a depositar: $");
            decimal monto = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            banco.RealizarDeposito(numeroCuenta, monto);
            Console.WriteLine($"Depósito de ${monto:N2} realizado exitosamente.");
            Console.WriteLine($"Nuevo saldo: ${banco.ConsultarSaldo(numeroCuenta):N2}");
        }

        static void RealizarRetiro()
        {
            Console.WriteLine("\n=== REALIZAR RETIRO ===");
            Console.Write("Número de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            Console.Write("Monto a retirar: $");
            decimal monto = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            banco.RealizarRetiro(numeroCuenta, monto);
            Console.WriteLine($"Retiro de ${monto:N2} realizado exitosamente.");
            Console.WriteLine($"Nuevo saldo: ${banco.ConsultarSaldo(numeroCuenta):N2}");
        }

        static void ConsultarSaldo()
        {
            Console.WriteLine("\n=== CONSULTAR SALDO ===");
            Console.Write("Número de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            decimal saldo = banco.ConsultarSaldo(numeroCuenta);
            var cuenta = banco.ObtenerCuenta(numeroCuenta);

            Console.WriteLine($"Tipo de cuenta: {cuenta.ObtenerTipoCuenta()}");
            Console.WriteLine($"Titular: {cuenta.Titular}");
            Console.WriteLine($"Saldo actual: ${saldo:N2}");

            if (cuenta is CuentaCorriente cc)
            {
                Console.WriteLine($"Saldo disponible (con sobregiro): ${cc.ObtenerSaldoDisponible():N2}");
            }
            else if (cuenta is CuentaAhorros ca)
            {
                Console.WriteLine($"Retiros realizados este mes: {ca.RetirosRealizados}/3");
            }
        }

        static void ListarCuentas()
        {
            Console.WriteLine("\n=== LISTADO DE CUENTAS ===");
            var cuentas = banco.ObtenerTodasLasCuentas();

            if (cuentas.Count == 0)
            {
                Console.WriteLine("No hay cuentas registradas.");
                return;
            }

            foreach (var cuenta in cuentas)
            {
                Console.WriteLine($"Cuenta: {cuenta.NumeroCuenta}");
                Console.WriteLine($"Titular: {cuenta.Titular}");
                Console.WriteLine($"Tipo: {cuenta.ObtenerTipoCuenta()}");
                Console.WriteLine($"Saldo: ${cuenta.Saldo:N2}");

                if (cuenta is CuentaAhorros ca)
                {
                    Console.WriteLine($"Retiros realizados: {ca.RetirosRealizados}/3");
                }
                else if (cuenta is CuentaCorriente cc)
                {
                    Console.WriteLine($"Saldo disponible: ${cc.ObtenerSaldoDisponible():N2}");
                }

                Console.WriteLine(new string('-', 30));
            }
        }
    }
}

