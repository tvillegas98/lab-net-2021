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
            int numero = MetodosHelper.ObtenerNumero("Ingrese un número: ", "Número inválido, intente nuevamente");
            EjerciciosHelper.IntentarDividirDiezPor(numero);

            //Ejercicio 2.
            EjerciciosHelper.Division();


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
        }
    }
}
