namespace TempConverterLib
{
    public class TempConverter
    {
        public decimal CelciusToFahrenheit(decimal celciusTemp)
            => (celciusTemp * 1.8M) + 32M;

        public decimal FahrenheitToCelcius(decimal fahrenheitTemp)
            => (fahrenheitTemp - 32M) / 1.8M;
    }
}