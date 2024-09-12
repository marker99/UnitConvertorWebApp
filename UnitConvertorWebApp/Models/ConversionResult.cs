namespace UnitConvertorWebApp.Models
{
    public class ConversionResult
    {
        public double NumericValue { get; set; }
        public string? Abbreviation { get; set; }  // Nullable to handle cases without formatted strings.

        public ConversionResult(double numericValue, string? abbreviation = null)
        {
            NumericValue = numericValue;
            Abbreviation = abbreviation;  // Can be null or empty if there is no abbreviation.
        }
    }
}
