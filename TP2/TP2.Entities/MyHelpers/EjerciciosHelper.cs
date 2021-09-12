using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Entities.MyExtensions;
using System.Windows.Forms;

namespace TP2.Entities.MyHelpers
{
    public static class EjerciciosHelper
    {
        public static void IntentarDividirDiezPor(int numero)
        {
            int numeroAuxiliar = 10;
            try
            {
                int resultado = numeroAuxiliar / numero;
                Console.WriteLine($"{numeroAuxiliar} / {numero} = {resultado}");
            }
            catch (DivideByZeroException error)
            {
/*                Console.WriteLine("Mensaje de error:");
                Console.WriteLine(error.Message);
                Console.WriteLine("StackTrace del error");
                Console.WriteLine(error.StackTrace);*/
                MessageBox.Show($"Error: {error.Message}\nStackTrace:{error.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Fin del ejercicio 1.");
            }
        }

        public static int Division()
        {
            int resultado = 0;
            try
            {
                Console.WriteLine("Ingrese el número dividendo: ");
                int dividendo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número divisor");
                int divisor = int.Parse(Console.ReadLine());
                resultado = dividendo.DividirPor(divisor);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Solo Chuck Norris puede dividir por cero!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Solo Vin Diesel puede dividir por una letra o por nada!");
            }

            return resultado;
        }

        public static void LevantarExcepcion()
        {
            throw new Exception("Voy a romper tu programa.");
        }
    }
}
