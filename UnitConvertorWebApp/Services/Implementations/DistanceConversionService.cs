namespace UnitConvertorWebApp.Services.Implementations
{
    public class DistanceConversionService : IDistanceConversionService
    {
        public double MetersToFeet(double meters)
        {
            return meters * 3.28084;
        }

        public double FeetToMeters(double feet)
        {
            return feet / 3.28084;
        }

        public double KilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371;
        }

        public double MilesToKilometers(double miles)
        {
            return miles / 0.621371;
        }

    }
}
