using PooVueling;
using Xunit;

namespace xUnitTest
{
    public class test
    {
        Icalculadora ICalculadora = new Calculadora();

        [Fact]
        public void MultiplicationTest()
        {
            Assert.Equal(ICalculadora.Multiplicacion(2, 3),6);
        }

        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(ICalculadora.Division(2, 2),1);
        }

        [Fact]
        public void RestaTest()
        {
            Assert.Equal(ICalculadora.Resta(8, 2),6);
        }

        [Fact]
        public void SumaTest()
        {
            Assert.Equal(ICalculadora.Suma(5, 2),7);
        }
    }
}
