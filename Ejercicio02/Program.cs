using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Ejercicio02
{
    class Program
    {
        static List<ClsCliente> LstClientes = new List<ClsCliente>();
        static List<ClsLocalidad> LstLocalidades = new List<ClsLocalidad>();
        static List<ClsPaquete> LstPaquetes = new List<ClsPaquete>();
        static Random rnd = new Random();

        enum Tipo { A = 1, B, C, D }

        static void Main(string[] args)
        {
            CargarLocalidades();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n=== MENU PRINCIPAL ===");
                Console.WriteLine("1. ABM Clientes");
                Console.WriteLine("2. ABM Paquetes");
                Console.WriteLine("3. Contratar Paquetes");
                Console.WriteLine("4. Informes");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1": MenuClientes(); break;
                    case "2": MenuPaquetes(); break;
                    case "3": MenuContratacion(); break;
                    case "4": MenuInformes(); break;
                    case "0": salir = true; break;
                    default: Console.WriteLine("Opción inválida."); break;
                }
            }
        }

        // ================== CLIENTES ==================
        static void MenuClientes()
        {
            Console.WriteLine("\n--- MENU CLIENTES ---");
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Listar Clientes");
            Console.WriteLine("3. Modificar Cliente");
            Console.WriteLine("4. Eliminar Cliente");
            Console.Write("Opción: ");
            switch (Console.ReadLine())
            {
                case "1": AgregarCliente(); break;
                case "2": ListarClientes(); break;
                case "3": ModificarCliente(); break;
                case "4": EliminarCliente(); break;
            }
        }

        static void AgregarCliente()
        {
            var cli = new ClsCliente();
            cli.Codigo = rnd.Next(1, 99999);
            Console.Write("Nombre: "); cli.Nombre = Console.ReadLine();
            Console.Write("Apellido: "); cli.Apellido = Console.ReadLine();

            Console.WriteLine("Seleccione Localidad:");
            foreach (var loc in LstLocalidades) Console.WriteLine(loc);
            cli.oLoc = LstLocalidades.Find(l => l.ID == int.Parse(Console.ReadLine()));

            Console.WriteLine("Forma de pago (1=Débito, 2=Crédito): ");
            string fp = Console.ReadLine();
            if (fp == "1") cli.oFPago = new FPagoDebito() { Cod = 1, Forma = "Debito" };
            else cli.oFPago = new FPagoCredito() { Cod = 2, Forma = "Credito" };

            LstClientes.Add(cli);
            Console.WriteLine("Cliente agregado correctamente.");
        }

        static void ListarClientes()
        {
            Console.WriteLine("\n--- LISTA DE CLIENTES ---");
            foreach (var c in LstClientes) Console.WriteLine(c);
        }

        static void ModificarCliente()
        {
            ListarClientes();
            Console.Write("Ingrese código de cliente a modificar: ");
            int cod = int.Parse(Console.ReadLine());
            var cli = LstClientes.Find(c => c.Codigo == cod);
            if (cli == null) { Console.WriteLine("No encontrado"); return; }

            Console.Write("Nuevo nombre: "); cli.Nombre = Console.ReadLine();
            Console.Write("Nuevo apellido: "); cli.Apellido = Console.ReadLine();
            Console.WriteLine("Modificado!");
        }

        static void EliminarCliente()
        {
            ListarClientes();
            Console.Write("Ingrese código de cliente a eliminar: ");
            int cod = int.Parse(Console.ReadLine());
            var cli = LstClientes.Find(c => c.Codigo == cod);
            if (cli != null) { LstClientes.Remove(cli); Console.WriteLine("Eliminado."); }
        }

        // ================== PAQUETES ==================
        static void MenuPaquetes()
        {
            Console.WriteLine("\n--- MENU PAQUETES ---");
            Console.WriteLine("1. Crear Paquete");
            Console.WriteLine("2. Listar Paquetes");
            Console.Write("Opción: ");
            switch (Console.ReadLine())
            {
                case "1": CrearPaquete(); break;
                case "2": ListarPaquetes(); break;
            }
        }

        static void CrearPaquete()
        {
            var pack = new ClsPaquete();
            pack.Cod = rnd.Next(1, 999);
            Console.Write("Nombre: "); pack.Nombre = Console.ReadLine();

            Console.WriteLine("Tipo (A/B/C/D): ");
            pack.Tipo = Console.ReadLine();
            Console.Write("Precio: "); pack.PrecioU = double.Parse(Console.ReadLine());

            LstPaquetes.Add(pack);
            Console.WriteLine("Paquete creado.");
        }

        static void ListarPaquetes()
        {
            Console.WriteLine("\n--- LISTA DE PAQUETES ---");
            foreach (var p in LstPaquetes) Console.WriteLine(p);
        }

        // ================== CONTRATOS ==================
        static void MenuContratacion()
        {
            ListarClientes();
            Console.Write("Seleccione cliente por código: ");
            int cod = int.Parse(Console.ReadLine());
            var cli = LstClientes.Find(c => c.Codigo == cod);
            if (cli == null) { Console.WriteLine("Cliente no existe"); return; }

            ListarPaquetes();
            Console.Write("Seleccione paquete por código: ");
            int codP = int.Parse(Console.ReadLine());
            var pack = LstPaquetes.Find(p => p.Cod == codP);

            if (pack == null) { Console.WriteLine("Paquete no existe"); return; }

            if (cli.LPaquetes.Exists(p => p.Cod == pack.Cod))
            {
                Console.WriteLine(new ErrorPersonalizado().Message);
                return;
            }

            pack.Abono = cli.oFPago.CalcularPrecio(pack.PrecioU);
            pack.FechaPago = DateTime.Now;
            cli.LPaquetes.Add(pack);

            Console.WriteLine($"Cliente {cli.Nombre} contrató {pack.Nombre}, abono final: {pack.Abono}");
        }

        // ================== INFORMES ==================
        static void MenuInformes()
        {
            Console.WriteLine("\n--- INFORMES ---");
            Console.WriteLine("1. Total recaudado");
            Console.WriteLine("2. Paquete más vendido");
            Console.Write("Opción: ");
            switch (Console.ReadLine())
            {
                case "1": InformeTotalRecaudado(); break;
                case "2": InformePaqueteMasVendido(); break;
            }
        }

        static void InformeTotalRecaudado()
        {
            double total = 0;
            foreach (var cli in LstClientes)
                foreach (var pack in cli.LPaquetes) total += pack.Abono;

            Console.WriteLine($"Total recaudado mensual: {total}");
        }

        static void InformePaqueteMasVendido()
        {
            Dictionary<int, int> conteo = new Dictionary<int, int>();
            foreach (var cli in LstClientes)
                foreach (var p in cli.LPaquetes)
                {
                    if (!conteo.ContainsKey(p.Cod)) conteo[p.Cod] = 0;
                    conteo[p.Cod]++;
                }

            if (conteo.Count == 0) { Console.WriteLine("No hay ventas."); return; }

            int max = -1, idMax = -1;
            foreach (var kv in conteo)
                if (kv.Value > max) { max = kv.Value; idMax = kv.Key; }

            var pack = LstPaquetes.Find(p => p.Cod == idMax);
            Console.WriteLine($"Paquete más vendido: {pack.Nombre}, contratado {max} veces.");
        }

        // ================== AUX ==================
        static void CargarLocalidades()
        {
            LstLocalidades.Add(new ClsLocalidad() { ID = 1, Nombre = "CABA" });
            LstLocalidades.Add(new ClsLocalidad() { ID = 2, Nombre = "Morón" });
            LstLocalidades.Add(new ClsLocalidad() { ID = 3, Nombre = "Ituzaingó" });
            LstLocalidades.Add(new ClsLocalidad() { ID = 4, Nombre = "Castelar" });
        }
    }
}

