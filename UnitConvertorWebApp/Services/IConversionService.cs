using UnitConvertorWebApp.Models;

namespace UnitConvertorWebApp.Services
{
    public interface IConversionService
    {
        /// <summary>
        /// Converts a value from one unit to another for a given quantity type.
        /// </summary>
        /// <param name="quantityName">The name of the quantity type (e.g., "Length", "Mass").</param>
        /// <param name="value">The value to convert.</param>
        /// <param name="fromUnit">The unit to convert from.</param>
        /// <param name="toUnit">The unit to convert to.</param>
        /// <returns>A task representing the asynchronous operation, containing the conversion result.</returns>
        Task<ConversionResult> ConvertAsync(string quantityName, double value, string fromUnit, string toUnit);

        /// <summary>
        /// Gets all available units for a given quantity type.
        /// </summary>
        /// <param name="quantityName">The name of the quantity type.</param>
        /// <returns>A task representing the asynchronous operation, containing a list of available units.</returns>
        Task<List<string>> GetAvailableUnitsAsync(string quantityName);

        /// <summary>
        /// Gets all available quantity types.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, containing a list of available quantity types.</returns>
        Task<List<string>> GetAvailableQuantitiesAsync();
    }
}
