using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        public const int MaximoTransportes = 100;
        public const int MinOpciones = 1;
        public const int MaxOpciones = 5;

        public static void MostrarMenu()
        {
            Console.WriteLine("Elija una opción: ");
            Console.WriteLine("1.Definir la cantidad de Taxis y sus Pasajeros");
            Console.WriteLine("2.Definir la cantidad de Omnibuses y sus Pasajeros");
            Console.WriteLine("3.Listar todos los Taxis y sus pasajeros");
            Console.WriteLine("4.Listar todos los Omnibuses y sus pasajeros");
            Console.WriteLine("5.Cerrar Programa");
        }

        public static int ObtenerNumero(string mensajeEntrada, string mensajeError, int topeInferior, int topeSuperior)
        {
            int numero;
            
            Console.WriteLine(mensajeEntrada);
            string entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out numero) || numero < topeInferior || numero > topeSuperior)  
            {
                Console.WriteLine(mensajeError);
                entrada = Console.ReadLine();
            }

            return numero;
        }
        public static void ListarTaxis(List<Taxi> taxis)
        {
            int numTaxi = 0;
            foreach (Taxi taxi in taxis)
            {
                numTaxi++;
                Console.WriteLine($"Taxi {taxi.Nombre}-{numTaxi}: {taxi.Pasajeros} pasajeros");
            }
        }

        public static void ListarOmnibuses(List<Omnibus> omnibuses)
        {
            int numOmnibus = 0;
            foreach (Omnibus omnibus in omnibuses)
            {
                numOmnibus++;
                Console.WriteLine($"Omnibus {omnibus.Nombre}-{numOmnibus}: {omnibus.Pasajeros} pasajeros");
            }
        }

        public static void AgregarTaxis(List<Taxi> taxis, int cantidad)
        {
            for(int i = 0; i < cantidad; i++)
            {
                int pasajeros = Program.ObtenerNumero(
                    $"Ingrese el número de pasajeros del Taxi Nro: {i+1}", 
                    "El número ingresado es erróneo, intente nuevamente", 
                    0, 
                    MaximoTransportes
                    );
                Console.WriteLine("Ingrese el nombre del Taxi");
                string nombre = Console.ReadLine();
                taxis.Add(new Taxi(pasajeros, nombre));
            }
        }

        public static void AgregarOmnibuses(List<Omnibus> omnibuses, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                int pasajeros = Program.ObtenerNumero(
                    $"Ingrese el número de pasajeros del Omnibus Nro: {i+1}", 
                    "El número ingresado es erróneo, intente nuevamente",
                    0,
                    MaximoTransportes
                    );
                Console.WriteLine("Ingrese el nombre del Omnibus");
                string nombre = Console.ReadLine();
                omnibuses.Add(new Omnibus(pasajeros, nombre));
            }
        }

        static void Main(string[] args)
        {
            int taxisCantidad = Program.ObtenerNumero(
                "Ingrese la cantidad de Taxis entre 0 y 100",
                "El número ingresa es erróneo, intente nuevamente",
                0,
                MaximoTransportes
                );
            int omnibusesCantidad = Program.ObtenerNumero(
                "Ingrese la cantidad de Omnibuses entre 0 y 100",
                "El número ingresado es erróneo, intente nuevamente",
                0,
                MaximoTransportes
                );

            List<Taxi> taxis = new List<Taxi>();
            List<Omnibus> omnibuses = new List<Omnibus>();

            Program.AgregarTaxis(taxis, taxisCantidad);
            Program.AgregarOmnibuses(omnibuses, omnibusesCantidad);

            Program.ListarTaxis(taxis);
            Program.ListarOmnibuses(omnibuses);

            Console.ReadLine();
        }
    }
}
