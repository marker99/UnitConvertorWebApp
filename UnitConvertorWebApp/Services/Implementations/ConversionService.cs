using UnitConvertorWebApp.Models;
using UnitsNet;
using UnitsNet.Units;

namespace UnitConvertorWebApp.Services.Implementations
{
    public class ConversionService : IConversionService
    {
        public ConversionResult ConvertDistance(double value, string fromUnit, string toUnit)
        {
            var fromUnitEnum = Enum.Parse<LengthUnit>(fromUnit, true);
            var toUnitEnum = Enum.Parse<LengthUnit>(toUnit, true);

            var convertedValue = Length.From(value, fromUnitEnum).As(toUnitEnum);
            var abbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(toUnitEnum);

            return new ConversionResult(convertedValue, abbreviation);
        }

        public ConversionResult ConvertTemperature(double value, string fromUnit, string toUnit)
        {
            var fromUnitEnum = Enum.Parse<TemperatureUnit>(fromUnit, true);
            var toUnitEnum = Enum.Parse<TemperatureUnit>(toUnit, true);

            var convertedValue = Temperature.From(value, fromUnitEnum).As(toUnitEnum);
            var abbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(toUnitEnum);

            return new ConversionResult(convertedValue, abbreviation);
        }

        public ConversionResult ConvertWeight(double value, string fromUnit, string toUnit)
        {
            var fromUnitEnum = Enum.Parse<MassUnit>(fromUnit, true);
            var toUnitEnum = Enum.Parse<MassUnit>(toUnit, true);

            var convertedValue = Mass.From(value, fromUnitEnum).As(toUnitEnum);
            var abbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(toUnitEnum);

            return new ConversionResult(convertedValue, abbreviation);
        }
    }
}
