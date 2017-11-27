using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Temperaturas.Testes
{
    [TestClass]
    public class TestesConversorTemperatura
    {
        [TestMethod]
        public void TesteConversaoTemperatura1()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(32);
            Assert.AreEqual(0, valorCalculado);
        }

        [TestMethod]
        public void TesteConversaoTemperatura2()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(86);
            Assert.AreEqual(30, valorCalculado);
        }

        [TestMethod]
        public void TesteConversaoTemperatura3()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(90.5);
            Assert.AreEqual(32.5, valorCalculado);
        }

        [TestMethod]
        public void TesteConversaoTemperatura4()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(212);
            Assert.AreEqual(100, valorCalculado);
        }
    }
}