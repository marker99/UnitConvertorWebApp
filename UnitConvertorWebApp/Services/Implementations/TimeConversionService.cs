namespace UnitConvertorWebApp.Services.Implementations
{
    public class TimeConversionService : ITimeConversionService
    {
        public double SecondsToMinutes(double seconds) => seconds / 60.0;
        public double MinutesToSeconds(double minutes) => minutes * 60.0;

        public double SecondsToHours(double seconds) => seconds / 3600.0;
        public double HoursToSeconds(double hours) => hours * 3600.0;

        public double MinutesToHours(double minutes) => minutes / 60.0;
        public double HoursToMinutes(double hours) => hours * 60.0;

        public double DaysToHours(double days) => days * 24.0;
        public double HoursToDays(double hours) => hours / 24.0;

        public double DaysToMinutes(double days) => days * 1440.0;
        public double MinutesToDays(double minutes) => minutes / 1440.0;
    }
}
