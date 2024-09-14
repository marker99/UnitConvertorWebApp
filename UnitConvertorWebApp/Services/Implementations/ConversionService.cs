using UnitConvertorWebApp.Models;
using UnitsNet;
using UnitsNet.Units;

namespace UnitConvertorWebApp.Services.Implementations
{
    public class ConversionService : IConversionService
    {
        public ConversionResult Convert(string quantityName, double value, string fromUnit, string toUnit)
        {
            // Get the QuantityInfo for the given quantity name
            var quantityInfo = Quantity.ByName[quantityName];

            // Parse the units based on the quantity
            var fromUnitEnum = (Enum)Enum.Parse(quantityInfo.UnitType, fromUnit);
            var toUnitEnum = (Enum)Enum.Parse(quantityInfo.UnitType, toUnit);

            // Convert the value using the UnitConverter
            var convertedValue = UnitConverter.Convert(value, fromUnitEnum, toUnitEnum);

            // Get the abbreviation for the target unit
            var abbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(toUnitEnum);

            // Return the result with the converted value and abbreviation
            return new ConversionResult(convertedValue, abbreviation);
        }
    }
}
