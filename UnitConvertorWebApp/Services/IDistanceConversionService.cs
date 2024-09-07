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

        // Metric to Imperial
        double MetersToFeet(double meters);
        double MetersToYards(double meters);
        double KilometersToMiles(double kilometers);
        double KilometersToFeet(double kilometers);

        // Imperial to Metric
        double InchesToCentimeters(double inches);
        double FeetToMeters(double feet);
        double YardsToMeters(double yards);
        double MilesToKilometers(double miles);
        double FeetToKilometers(double feet);

        // Imperial to Imperial
        double FeetToYards(double feet);
        double YardsToFeet(double yards);
        double InchesToFeet(double inches);
        double FeetToInches(double feet);
    }
}
