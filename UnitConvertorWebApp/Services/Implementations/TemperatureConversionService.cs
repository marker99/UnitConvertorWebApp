namespace UnitConvertorWebApp.Services.Implementations
{
    public class TemperatureConversionService : ITemperatureConversionService
    {
        // Celsius to Fahrenheit: (C * 9/5) + 32
        public double CelsiusToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;

        // Celsius to Kelvin: C + 273.15
        public double CelsiusToKelvin(double celsius) => celsius + 273.15;

        // Fahrenheit to Celsius: (F - 32) * 5/9
        public double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;

        // Fahrenheit to Kelvin: (F - 32) * 5/9 + 273.15
        public double FahrenheitToKelvin(double fahrenheit) => (fahrenheit - 32) * 5 / 9 + 273.15;

        // Kelvin to Celsius: K - 273.15
        public double KelvinToCelsius(double kelvin) => kelvin - 273.15;

        // Kelvin to Fahrenheit: (K - 273.15) * 9/5 + 32
        public double KelvinToFahrenheit(double kelvin) => (kelvin - 273.15) * 9 / 5 + 32;
    }
}
