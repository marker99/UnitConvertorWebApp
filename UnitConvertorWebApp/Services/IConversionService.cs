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
    }
}
