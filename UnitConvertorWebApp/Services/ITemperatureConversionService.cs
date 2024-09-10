namespace UnitConvertorWebApp.Services
{
    public interface ITemperatureConversionService
    {
        // Celsius conversions
        double CelsiusToFahrenheit(double celsius);
        double CelsiusToKelvin(double celsius);
        double FahrenheitToCelsius(double fahrenheit);
        double KelvinToCelsius(double kelvin);

        // Fahrenheit conversions
        double FahrenheitToKelvin(double fahrenheit);
        double KelvinToFahrenheit(double kelvin);
    }
}
