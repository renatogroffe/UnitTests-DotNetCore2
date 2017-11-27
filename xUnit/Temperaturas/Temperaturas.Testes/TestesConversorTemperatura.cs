using System;
using Xunit;

namespace Temperaturas.Testes
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(86, 30)]
        [InlineData(90.5, 32.5)]
        [InlineData(212, 100)]
        public void TesteConversaoTemperatura(
            double tempFahrenheit, double tempCelsius)
        {
            double resultado = ConversorTemperatura
                .FahrenheitParaCelsius(tempFahrenheit);
            Assert.Equal(tempCelsius, resultado);
        }
    }
}