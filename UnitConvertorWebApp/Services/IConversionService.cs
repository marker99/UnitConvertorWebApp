using UnitConvertorWebApp.Models;

namespace UnitConvertorWebApp.Services
{
    public interface IConversionService
    {
        /// <summary>
        /// Should be able to handle every type of conversions
        /// </summary>
        /// <param name="quantityName"></param>
        /// <param name="value"></param>
        /// <param name="fromUnit"></param>
        /// <param name="toUnit"></param>
        /// <returns></returns>
        ConversionResult Convert(string quantityName, double value, string fromUnit, string toUnit);

        public ConversionResult ConvertDistance(double value, string fromUnit, string toUnit);
        public ConversionResult ConvertWeight(double value, string fromUnit, string toUnit);
        public ConversionResult ConvertTemperature(double value, string fromUnit, string toUnit);
        //public ConversionResult ConvertTime(double value, string fromUnit, string toUnit);

    }
}
