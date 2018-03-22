using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraIntegrationTests
    {

        Icalculadora ICalculadora = new Calculadora();

        [TestMethod()]
        public void DivisionTest()
        {
            Assert.IsTrue(ICalculadora.Division(8, 2) == 4);
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            Assert.IsTrue(ICalculadora.Multiplicacion(2, 2) == 4);
        }

        [TestMethod()]
        public void RestaTest()
        {
            Assert.IsTrue(ICalculadora.Resta(4, 2) == 2);
        }

        [TestMethod()]
        public void SumaTest()
        {
            //Assert.Fail();
            Assert.IsTrue(ICalculadora.Suma(2, 2) == 4);
            
        }
    }
}