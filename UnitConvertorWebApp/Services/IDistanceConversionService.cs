using UnitConvertorWebApp.Models;

namespace UnitConvertorWebApp.Services
{
    public interface IDistanceConversionService
    {
        public ConversionResult Convert(double value, string fromUnit, string toUnit);

    }
}
