namespace UnitConvertorWebApp.Services
{
    public interface IDistanceConversionService
    {
        // Metric to Metric
        double MillimetersToCentimeters(double millimeters);
        double CentimetersToMillimeters(double centimeters);
        double CentimetersToMeters(double centimeters);
        double MetersToCentimeters(double meters);
        double MetersToKilometers(double meters);
        double KilometersToMeters(double kilometers);
        double CentimetersToKilometers(double centimeters);
        double KilometersToCentimeters(double kilometers);
        double MillimetersToKilometers(double millimeters);
        double KilometersToMillimeters(double kilometers);
        double MillimetersToMeters(double millimeters);
        double MetersToMillimeters(double meters);


        // Metric to Imperial
        double MillimetersToInches(double millimeters);
        double MillimetersToFeet(double millimeters);
        double MillimetersToYards(double millimeters);
        double MillimetersToMiles(double millimeters);
        double CentimetersToInches(double centimeters);
        double CentimetersToFeet(double centimeters);
        double CentimetersToYards(double centimeters);
        double CentimetersToMiles(double centimeters);
        double MetersToInches(double meters);
        double MetersToFeet(double meters);
        double MetersToYards(double meters);
        double MetersToMiles(double meters);
        double KilometersToMiles(double kilometers);
        double KilometersToFeet(double kilometers);
        double KilometersToYards(double kilometers);
        double KilometersToInches(double kilometers);


        // Imperial to Metric
        double InchesToMillimeters(double inches);
        double InchesToCentimeters(double inches);
        double InchesToMeters(double inches);
        double InchesToKilometers(double inches);
        double FeetToMillimeters(double feet);
        double FeetToCentimeters(double feet);
        double FeetToMeters(double feet);
        double FeetToKilometers(double feet);
        double YardsToMillimeters(double yards);
        double YardsToCentimeters(double yards);
        double YardsToMeters(double yards);
        double YardsToKilometers(double yards);
        double MilesToMillimeters(double miles);
        double MilesToCentimeters(double miles);
        double MilesToMeters(double miles);
        double MilesToKilometers(double miles);

        // Imperial to Imperial
        double InchesToFeet(double inches);
        double FeetToInches(double feet);
        double FeetToYards(double feet);
        double YardsToFeet(double yards);
        double InchesToYards(double inches);
        double YardsToInches(double yards);
        double YardsToMiles(double yards);
        double MilesToYards(double miles);
        double FeetToMiles(double feet);
        double MilesToFeet(double miles);
        double InchesToMiles(double inches);
        double MilesToInches(double miles);
    }
}
