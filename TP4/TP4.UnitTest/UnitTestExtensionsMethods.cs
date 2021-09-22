using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TP4.UI.MyExtensions;
namespace TP4.UnitTest
{
    [TestClass]
    public class UnitTestExtensionMethods
    {
        [TestMethod]
        public void TestRemoverEspaciosEnBlanco()
        {
            string cadena = "PRUEBA             ";
            string cadenaResultadoEsperado = "PRUEBA";
            string cadenaResultado = cadena.RemoverEspaciosEnBlanco();

            Assert.AreEqual(cadenaResultadoEsperado, cadenaResultado);
        }

        [TestMethod]

        public void TestRemoverEspaciosEnBlancoStringCompuesto()
        {
            string cadena = "PRUEBA                A          PRUEBA        DE          ERRORES";
            string cadenaResultadoEsperado = "PRUEBA A PRUEBA DE ERRORES";
            string cadenaResultado = cadena.RemoverEspaciosEnBlanco();

            Assert.AreEqual(cadenaResultadoEsperado, cadenaResultado);
        }
    }
}
