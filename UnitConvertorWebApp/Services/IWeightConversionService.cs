namespace UnitConvertorWebApp.Services
{
    public interface IWeightConversionService
    {
        //TODO: Probalby missing conversions

        double GramsToKilograms(double grams);
        double KilogramsToGrams(double kilograms);

        double GramsToPounds(double grams);
        double PoundsToGrams(double pounds);

        double KilogramsToPounds(double kilograms);
        double PoundsToKilograms(double pounds);

        double OuncesToGrams(double ounces);
        double GramsToOunces(double grams);

        double PoundsToOunces(double pounds);
        double OuncesToPounds(double ounces);

        double TonsToKilograms(double tons);
        double KilogramsToTons(double kilograms);

        double StonesToKilograms(double stones);
        double KilogramsToStones(double kilograms);
        double StonesToPounds(double stones);
        double PoundsToStones(double pounds);
    }
}
