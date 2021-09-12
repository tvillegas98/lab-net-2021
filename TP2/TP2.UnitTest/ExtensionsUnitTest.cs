using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TP2.Entities.MyExtensions;

namespace TP2.UnitTest
{
    [TestClass]
    public class ExtensionsUnitTest
    {
        [TestMethod]
        public void DividirPorTestUno()
        {
            int dividendo = 9;
            int divisor = 3;
            int resultado = 3;

            Assert.AreEqual(resultado, dividendo.DividirPor(divisor));
        }

        [TestMethod]
        public void DividirPorTestDos()
        {
            int dividendo = 100;
            int divisor = 10;
            int resultado = 10;

            Assert.AreEqual(resultado, dividendo.DividirPor(divisor));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivirPorCeroTest()
        {
            int dividendo = 100;
            int divisor = 0;
            int resultado = dividendo.DividirPor(divisor);
        }
    }
}
