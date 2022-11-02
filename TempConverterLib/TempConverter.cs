namespace TempConverterLib
{
    public static class TempConverter
    {
        public static decimal CelciusToFahrenheit(decimal celciusTemp)
            => (celciusTemp * 1.8M) + 32M;

        public static decimal FahrenheitToCelcius(decimal fahrenheitTemp)
            => (fahrenheitTemp - 32M) / 1.8M;
    }
}