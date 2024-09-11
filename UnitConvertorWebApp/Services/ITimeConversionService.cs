namespace UnitConvertorWebApp.Services
{
    public interface ITimeConversionService
    {
        // Milliseconds
        double MillisecondsToSeconds(double milliseconds);
        double MillisecondsToMinutes(double milliseconds);
        double MillisecondsToHours(double milliseconds);
        double MillisecondsToDays(double milliseconds);
        double MillisecondsToWeeks(double milliseconds);
        double MillisecondsToMonths(double milliseconds);
        double MillisecondsToYears(double milliseconds);

        // Seconds
        double SecondsToMilliseconds(double seconds);
        double SecondsToMinutes(double seconds);
        double SecondsToHours(double seconds);
        double SecondsToDays(double seconds);
        double SecondsToWeeks(double seconds);
        double SecondsToMonths(double seconds);
        double SecondsToYears(double seconds);

        // Minutes
        double MinutesToMilliseconds(double minutes);
        double MinutesToSeconds(double minutes);
        double MinutesToHours(double minutes);
        double MinutesToDays(double minutes);
        double MinutesToWeeks(double minutes);
        double MinutesToMonths(double minutes);
        double MinutesToYears(double minutes);

        // Hours 
        double HoursToMilliseconds(double hours);
        double HoursToSeconds(double hours);
        double HoursToMinutes(double hours);
        double HoursToDays(double hours);
        double HoursToWeeks(double hours);
        double HoursToMonths(double hours);
        double HoursToYears(double hours);

        // Days
        double DaysToMilliseconds(double days);
        double DaysToSeconds(double days);
        double DaysToMinutes(double days);
        double DaysToHours(double days);
        double DaysToWeeks(double days);
        double DaysToMonths(double days);
        double DaysToYears(double days);
        
        // Weeks
        double WeeksToMilliseconds(double weeks);
        double WeeksToSeconds(double weeks);
        double WeeksToMinutes(double weeks);
        double WeeksToHours(double weeks);
        double WeeksToDays(double weeks);
        double WeeksToMonths(double weeks);
        double WeeksToYears(double weeks);

        // Months
        double MonthsToMilliseconds(double months);
        double MonthsToSeconds(double months);
        double MonthsToMinutes(double months);
        double MonthsToHours(double months);
        double MonthsToDays(double months);
        double MonthsToWeeks(double months);
        double MonthsToYears(double months);

        // Years
        double YearsToMilliseconds(double years);
        double YearsToSeconds(double years);
        double YearsToMinutes(double years);
        double YearsToHours(double years);
        double YearsToDays(double years);
        double YearsToWeeks(double years);
        double YearsToMonths(double years);
    }
}
