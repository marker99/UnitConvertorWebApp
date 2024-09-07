namespace UnitConvertorWebApp.Services
{
    public interface IDistanceConversionService
    {
        double MetersToFeet(double meters);

        double FeetToMeters(double feet);

        double KilometersToMiles(double kilometers);

        double MilesToKilometers(double miles);
    }
}
