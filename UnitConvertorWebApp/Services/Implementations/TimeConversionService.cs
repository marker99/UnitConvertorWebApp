namespace UnitConvertorWebApp.Services.Implementations
{
    public class TimeConversionService : ITimeConversionService
    {
        // Constants for conversion
        private const double SecondsInMinute = 60;
        private const double SecondsInHour = 3600;
        private const double SecondsInDay = 86400;
        private const double SecondsInWeek = 604800;
        private const double SecondsInMonth = 2629746; // Average month in seconds
        private const double SecondsInYear = 31556952; // Average year in seconds

        private const double MillisecondsInSecond = 1000;

        // Milliseconds conversions
        public double MillisecondsToSeconds(double milliseconds) => milliseconds / MillisecondsInSecond;
        public double MillisecondsToMinutes(double milliseconds) => MillisecondsToSeconds(milliseconds) / SecondsInMinute;
        public double MillisecondsToHours(double milliseconds) => MillisecondsToSeconds(milliseconds) / SecondsInHour;
        public double MillisecondsToDays(double milliseconds) => MillisecondsToSeconds(milliseconds) / SecondsInDay;
        public double MillisecondsToWeeks(double milliseconds) => MillisecondsToSeconds(milliseconds) / SecondsInWeek;
        public double MillisecondsToMonths(double milliseconds) => MillisecondsToSeconds(milliseconds) / SecondsInMonth;
        public double MillisecondsToYears(double milliseconds) => MillisecondsToSeconds(milliseconds) / SecondsInYear;

        // Seconds conversions
        public double SecondsToMilliseconds(double seconds) => seconds * MillisecondsInSecond;
        public double SecondsToMinutes(double seconds) => seconds / SecondsInMinute;
        public double SecondsToHours(double seconds) => seconds / SecondsInHour;
        public double SecondsToDays(double seconds) => seconds / SecondsInDay;
        public double SecondsToWeeks(double seconds) => seconds / SecondsInWeek;
        public double SecondsToMonths(double seconds) => seconds / SecondsInMonth;
        public double SecondsToYears(double seconds) => seconds / SecondsInYear;

        // Minutes conversions
        public double MinutesToMilliseconds(double minutes) => SecondsToMilliseconds(minutes * SecondsInMinute);
        public double MinutesToSeconds(double minutes) => minutes * SecondsInMinute;
        public double MinutesToHours(double minutes) => minutes / SecondsInMinute;
        public double MinutesToDays(double minutes) => MinutesToSeconds(minutes) / SecondsInDay;
        public double MinutesToWeeks(double minutes) => MinutesToSeconds(minutes) / SecondsInWeek;
        public double MinutesToMonths(double minutes) => MinutesToSeconds(minutes) / SecondsInMonth;
        public double MinutesToYears(double minutes) => MinutesToSeconds(minutes) / SecondsInYear;

        // Hours conversions
        public double HoursToMilliseconds(double hours) => SecondsToMilliseconds(hours * SecondsInHour);
        public double HoursToSeconds(double hours) => hours * SecondsInHour;
        public double HoursToMinutes(double hours) => hours * SecondsInMinute;
        public double HoursToDays(double hours) => hours / 24.0;
        public double HoursToWeeks(double hours) => HoursToSeconds(hours) / SecondsInWeek;
        public double HoursToMonths(double hours) => HoursToSeconds(hours) / SecondsInMonth;
        public double HoursToYears(double hours) => HoursToSeconds(hours) / SecondsInYear;

        // Days conversions
        public double DaysToMilliseconds(double days) => SecondsToMilliseconds(days * SecondsInDay);
        public double DaysToSeconds(double days) => days * SecondsInDay;
        public double DaysToMinutes(double days) => DaysToSeconds(days) / SecondsInMinute;
        public double DaysToHours(double days) => days * 24.0;
        public double DaysToWeeks(double days) => days / 7.0;
        public double DaysToMonths(double days) => DaysToSeconds(days) / SecondsInMonth;
        public double DaysToYears(double days) => DaysToSeconds(days) / SecondsInYear;

        // Weeks conversions
        public double WeeksToMilliseconds(double weeks) => SecondsToMilliseconds(weeks * SecondsInWeek);
        public double WeeksToSeconds(double weeks) => weeks * SecondsInWeek;
        public double WeeksToMinutes(double weeks) => WeeksToSeconds(weeks) / SecondsInMinute;
        public double WeeksToHours(double weeks) => WeeksToSeconds(weeks) / SecondsInHour;
        public double WeeksToDays(double weeks) => weeks * 7.0;
        public double WeeksToMonths(double weeks) => WeeksToSeconds(weeks) / SecondsInMonth;
        public double WeeksToYears(double weeks) => WeeksToSeconds(weeks) / SecondsInYear;

        // Months conversions
        public double MonthsToMilliseconds(double months) => SecondsToMilliseconds(months * SecondsInMonth);
        public double MonthsToSeconds(double months) => months * SecondsInMonth;
        public double MonthsToMinutes(double months) => MonthsToSeconds(months) / SecondsInMinute;
        public double MonthsToHours(double months) => MonthsToSeconds(months) / SecondsInHour;
        public double MonthsToDays(double months) => MonthsToSeconds(months) / SecondsInDay;
        public double MonthsToWeeks(double months) => MonthsToSeconds(months) / SecondsInWeek;
        public double MonthsToYears(double months) => months / 12.0;

        // Years conversions
        public double YearsToMilliseconds(double years) => SecondsToMilliseconds(years * SecondsInYear);
        public double YearsToSeconds(double years) => years * SecondsInYear;
        public double YearsToMinutes(double years) => YearsToSeconds(years) / SecondsInMinute;
        public double YearsToHours(double years) => YearsToSeconds(years) / SecondsInHour;
        public double YearsToDays(double years) => YearsToSeconds(years) / SecondsInDay;
        public double YearsToWeeks(double years) => YearsToSeconds(years) / SecondsInWeek;
        public double YearsToMonths(double years) => years * 12.0;
    }
}
