using TempConverterLib;

namespace TempConverterTest
{
    public class TempConverterTest
    {
        public TempConverter TempConverter { get; set; }

        public TempConverterTest()
        {
            TempConverter = new TempConverter();
        }

        [Fact]
        public void CelciusToFahrenheitOK()
                    => Assert.Equal(32, TempConverter.CelciusToFahrenheit(0));

        [Fact]
        public void FahrenheitToCelciusOK()
            => Assert.Equal(0, TempConverter.FahrenheitToCelcius(32));

        [Theory]
        [InlineData(32, 0)]
        [InlineData(86, 30)]
        [InlineData(90.5, 32.5)]
        [InlineData(212, 100)]
        public void FahrenheitToCelcius(decimal fTemp, decimal cTemp)
            => Assert.Equal(fTemp, TempConverter.CelciusToFahrenheit(cTemp));
    }
}