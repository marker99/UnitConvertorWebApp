namespace UnitConvertorWebApp.Services.Implementations
{
    public class WeightConversionService : IWeightConversionService
    {
        // Conversion factors
        private const double GramsPerKilogram = 1000.0;
        private const double GramsPerPound = 453.592;
        private const double GramsPerOunce = 28.3495;
        private const double GramsPerTon = 1_000_000.0; // Metric ton
        private const double GramsPerStone = 6350.29; // 1 stone ≈ 6350.29 grams

        public double GramsToKilograms(double grams) => grams / GramsPerKilogram;

        public double KilogramsToGrams(double kilograms) => kilograms * GramsPerKilogram;

        public double GramsToPounds(double grams) => grams / GramsPerPound;


        public double PoundsToGrams(double pounds) => pounds * GramsPerPound;


        public double KilogramsToPounds(double kilograms)
        {
            double grams = KilogramsToGrams(kilograms);
            return GramsToPounds(grams);
        }

        public double PoundsToKilograms(double pounds)
        {
            double grams = PoundsToGrams(pounds);
            return GramsToKilograms(grams);
        }

        public double OuncesToGrams(double ounces) => ounces * GramsPerOunce; 

        public double GramsToOunces(double grams) => grams / GramsPerOunce;


        public double PoundsToOunces(double pounds) 
        {
            // 1 pound = 16 ounces
            return pounds * 16.0;
        }

        public double OuncesToPounds(double ounces)
        {
            // 1 ounce = 1/16 pounds
            return ounces / 16.0;
        }

        public double TonsToKilograms(double tons) => tons * GramsPerTon / GramsPerKilogram;

        public double KilogramsToTons(double kilograms) => kilograms * GramsPerKilogram / GramsPerTon;


        public double StonesToKilograms(double stones)
        {
            double grams = StonesToGrams(stones);
            return GramsToKilograms(grams);
        }

        public double KilogramsToStones(double kilograms)
        {
            double grams = KilogramsToGrams(kilograms);
            return GramsToStones(grams);
        }

        public double StonesToPounds(double stones)
        {
            double grams = StonesToGrams(stones);
            return GramsToPounds(grams);
        }

        public double PoundsToStones(double pounds)
        {
            double grams = PoundsToGrams(pounds);
            return GramsToStones(grams);
        }

        // Helper methods for stones
        private double StonesToGrams(double stones)
        {
            return stones * GramsPerStone;
        }

        private double GramsToStones(double grams)
        {
            return grams / GramsPerStone;
        }
    }
}
