namespace UnitConvertorWebApp.Services.Implementations
{
    public class DistanceConversionService : IDistanceConversionService
    {
        public double MillimetersToCentimeters(double millimeters) => millimeters / 10.0;
        public double CentimetersToMillimeters(double centimeters) => centimeters * 10.0;
        public double CentimetersToMeters(double centimeters) => centimeters / 100.0;
        public double MetersToCentimeters(double meters) => meters * 100.0;
        public double MetersToKilometers(double meters) => meters / 1000.0;
        public double KilometersToMeters(double kilometers) => kilometers * 1000.0;

        public double MetersToFeet(double meters) => meters * 3.28084;
        public double MetersToYards(double meters) => meters * 1.09361;
        public double KilometersToMiles(double kilometers) => kilometers * 0.621371;
        public double KilometersToFeet(double kilometers) => kilometers * 3280.84;

        public double InchesToCentimeters(double inches) => inches * 2.54;
        public double FeetToMeters(double feet) => feet / 3.28084;
        public double YardsToMeters(double yards) => yards * 0.9144;
        public double MilesToKilometers(double miles) => miles / 0.621371;
        public double FeetToKilometers(double feet) => feet * 0.0003048;

        public double FeetToYards(double feet) => feet / 3.0;
        public double YardsToFeet(double yards) => yards * 3.0;
        public double InchesToFeet(double inches) => inches / 12.0;
        public double FeetToInches(double feet) => feet * 12.0;
    }
}
