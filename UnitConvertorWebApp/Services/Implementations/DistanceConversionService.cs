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
        public double CentimetersToKilometers(double centimeters) => centimeters / 100_000.0;
        public double KilometersToCentimeters(double kilometers) => kilometers * 100_000.0;
        public double MillimetersToKilometers(double millimeters) => millimeters / 1_000_000.0;
        public double KilometersToMillimeters(double kilometers) => kilometers * 1_000_000.0;
        public double MillimetersToMeters(double millimeters) => millimeters / 1000.0;
        public double MetersToMillimeters(double meters) => meters * 1000.0;

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

        public double MillimetersToInches(double millimeters) => millimeters / 25.4;


        public double MillimetersToFeet(double millimeters) => millimeters / 304.8;


        public double MillimetersToYards(double millimeters) => millimeters / 914.4;


        public double MillimetersToMiles(double millimeters) => millimeters / 1_609_344.0;


        public double CentimetersToInches(double centimeters) => centimeters / 2.54;


        public double CentimetersToFeet(double centimeters) => centimeters / 30.48;


        public double CentimetersToYards(double centimeters) => centimeters / 91.44;


        public double CentimetersToMiles(double centimeters) => centimeters / 160_934.4;


        public double MetersToInches(double meters) => meters * 39.3701;


        public double MetersToMiles(double meters) => meters / 1609.34;

        public double KilometersToYards(double kilometers) => kilometers * 1093.61;


        public double KilometersToInches(double kilometers) => kilometers * 39_370.1;


        public double IncesToMillimeters(double inches) => inches * 25.4;


        public double IncesToMeters(double inches) => inches / 39.3701;


        public double InchesToKilometers(double inches) => inches / 39_370.1;


        public double FeetToMillimeters(double feet) => feet * 304.8;


        public double FeetToCentimeters(double feet) => feet * 30.48;


        public double YardsToMillimeters(double yards) => yards * 914.4;


        public double YardsToCentimeters(double yards) => yards * 91.44;


        public double YardsToKilometers(double yards) => yards / 1093.61;


        public double MilesToMillimeters(double miles) => miles * 1_609_344.0;


        public double MilesToCentimeters(double miles) => miles * 160_934.4;


        public double MilesToMeters(double miles) => miles * 1609.34;


        public double InchesToYards(double inches) => inches / 36.0;


        public double YardsToInches(double yards) => yards * 36.0;


        public double YardsToMiles(double yards) => yards / 1760.0;


        public double MilesToYards(double miles) => miles * 1760.0;


        public double FeetToMiles(double feet) => feet / 5280.0;


        public double MilesToFeet(double miles) => miles * 5280.0;


        public double InchesToMiles(double inches) => inches / 63_360.0;


        public double MilesToInches(double miles) => miles * 63_360.0;

    }
}
