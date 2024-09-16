using System;
using System.Threading.Tasks;
using UnitConvertorWebApp.Models;
using UnitsNet;

namespace UnitConvertorWebApp.Services.Implementations
{
    public class ConversionService : IConversionService
    {
        public async Task<ConversionResult> ConvertAsync(string quantityName, double value, string fromUnit, string toUnit)
        {
            return await Task.Run(() =>
            {
                var quantityInfo = Quantity.ByName[quantityName];
                var fromUnitEnum = (Enum)Enum.Parse(quantityInfo.UnitType, fromUnit);
                var toUnitEnum = (Enum)Enum.Parse(quantityInfo.UnitType, toUnit);

                var convertedValue = UnitConverter.Convert(value, fromUnitEnum, toUnitEnum);
                var abbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(toUnitEnum);

                return new ConversionResult(convertedValue, abbreviation);
            });
        }

        public async Task<List<string>> GetAvailableUnitsAsync(string quantityName)
        {
            return await Task.Run(() =>
            {
                var quantityInfo = Quantity.ByName[quantityName];
                return quantityInfo.UnitInfos.Select(ui => ui.Name).ToList();
            });
        }

        public async Task<List<string>> GetAvailableQuantitiesAsync()
        {
            return await Task.Run(() => Quantity.Names.ToList());
        }
    }
}