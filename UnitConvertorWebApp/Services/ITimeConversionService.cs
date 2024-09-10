namespace UnitConvertorWebApp.Services
{
    public interface ITimeConversionService
    {
        //TODO: Missing Conversions as well as smaller than seconds


        double SecondsToMinutes(double seconds);
        double MinutesToSeconds(double minutes);

        double SecondsToHours(double seconds);
        double HoursToSeconds(double hours);

        double MinutesToHours(double minutes);
        double HoursToMinutes(double hours);

        double DaysToHours(double days);
        double HoursToDays(double hours);

        double DaysToMinutes(double days);
        double MinutesToDays(double minutes);
    }
}
