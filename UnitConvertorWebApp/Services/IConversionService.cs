using UnitConvertorWebApp.Models;

namespace UnitConvertorWebApp.Services
{
    public interface IConversionService
    {
        public ConversionResult ConvertDistance(double value, string fromUnit, string toUnit);
        public ConversionResult ConvertWeight(double value, string fromUnit, string toUnit);
        public ConversionResult ConvertTemperature(double value, string fromUnit, string toUnit);
        //public ConversionResult ConvertTime(double value, string fromUnit, string toUnit);

    }
}
