using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2.Entities.MyHelpers;
using TP2.Entities.MyExceptions;

namespace TP2.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1.
            Console.WriteLine("-------------------Ejercio 1-------------------");
            int numero = MetodosHelper.ObtenerNumero("Ingrese un número: ", "Número inválido, intente nuevamente");
            EjerciciosHelper.IntentarDividirDiezPor(numero);
            Console.WriteLine("-------------------Fin Ejercicio 1-------------------");

            //Ejercicio 2.
            Console.WriteLine("-------------------Ejercio 2-------------------");
            Console.WriteLine("Si la división es exitosa, se mostrará el resultado, en caso contrario, se mostrará 0(A menos que el dividendo sea 0)");
            int resultado = EjerciciosHelper.Division();
            Console.WriteLine($"El resultado es: {resultado}");
            Console.WriteLine("-------------------Fin Ejercicio 2-------------------");
            //Ejercicio 3.

            try
            {
                EjerciciosHelper.LevantarExcepcion();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Tipo:{error.GetType()}\nError: {error.Message}\nStackTrace:{error.StackTrace}");
            }

            //Ejercicio 4.

            try
            {
                throw new ExcepcionPersonalizada("Hola, llegué para romper tu programa.");
            }catch (ExcepcionPersonalizada error)
            {
                MessageBox.Show($"Tipo:{error.GetType()}\nError: {error.Message}\nStackTrace:{error.StackTrace}");
            }
            finally
            {
                Console.WriteLine("No pude romper tu programa.");
            }
            Console.ReadLine();
        }
    }
}
