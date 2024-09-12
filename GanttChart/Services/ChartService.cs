using GanttChart.Models.Enums;

namespace GanttChart.Services
{
    public static class ChartService
    {
        public static DateTime CalculateStartDate(DateTime reference, TimePeriod period)
        {
            switch (period)
            {
                case TimePeriod.Year:
                    return reference.AddDays((reference.DayOfYear - 1) * -1);

                case TimePeriod.Month:
                    return reference.AddDays((reference.Day - 1) * -1);

                case TimePeriod.FiveDayWeek:
                case TimePeriod.SevenDayWeek:
                    return reference.AddDays(((int)reference.DayOfWeek - 1) * -1);

                case TimePeriod.Hour:
                case TimePeriod.Day:
                default:
                    return reference;
            }
        }

        public static DateTime CalculateEndDate(DateTime chartStart, TimePeriod timePeriod)
        {
            if (timePeriod == TimePeriod.Day) return chartStart.AddDays(1);
            if(timePeriod == TimePeriod.Month) return chartStart.AddDays(DateTime.DaysInMonth(chartStart.Year, chartStart.Month));

            return chartStart.AddDays((int)timePeriod);
        }
    }
}
