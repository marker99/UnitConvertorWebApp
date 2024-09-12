using UnitConvertorWebApp.Models;
using UnitsNet;
using UnitsNet.Units;

namespace UnitConvertorWebApp.Services.Implementations
{
    public class DistanceConversionService : IDistanceConversionService
    {
        public ConversionResult Convert(double value, string fromUnit, string toUnit)
        {
            var fromUnitEnum = Enum.Parse<LengthUnit>(fromUnit, true);
            var toUnitEnum = Enum.Parse<LengthUnit>(toUnit, true);

            var convertedValue = Length.From(value, fromUnitEnum).As(toUnitEnum);
            var abbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(toUnitEnum);

            return new ConversionResult(convertedValue, abbreviation);
        }
    }
}
