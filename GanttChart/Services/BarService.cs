using GanttChart.Models.Enums;
using GanttChart.Models;

namespace GanttChart.Services
{
    internal static class BarService
    {

        public static MultiKeyDictionary<TimePeriodInternal, TimeInterval, string> ColumnStructure => new()
    {
        {
            TimePeriodInternal.Day,
            new Dictionary<TimeInterval, string>()
            {
                { TimeInterval.Minute, "day-in-minutes" },
                { TimeInterval.Minute5, "day-in-minutes5" },
                { TimeInterval.Minute10, "day-in-minutes10" },
                { TimeInterval.Minute15, "day-in-minutes15" },
                { TimeInterval.Minute30, "day-in-minutes30" },
                { TimeInterval.Hour, "day-in-hours" },
            }
        },
        {
            TimePeriodInternal.FiveDayWeek,
            new Dictionary<TimeInterval, string>()
            {
                { TimeInterval.Minute, "five-day-week-in-minutes" },
                { TimeInterval.Minute5, "five-day-week-in-minutes5" },
                { TimeInterval.Minute15, "five-day-week-in-minutes15" },
                { TimeInterval.Minute30, "five-day-week-in-minutes30" },
                { TimeInterval.Hour, "five-day-week-in-hours" },
            }
        },
        {
            TimePeriodInternal.SevenDayWeek,
            new Dictionary<TimeInterval, string>()
            {
                { TimeInterval.Minute, "seven-day-week-in-minutes" },
                { TimeInterval.Minute5, "seven-day-week-in-minutes5" },
                { TimeInterval.Minute15, "seven-day-week-in-minutes15" },
                { TimeInterval.Minute30, "seven-day-week-in-minutes30" },
                { TimeInterval.Hour, "seven-day-week-in-hours" },
            }
        },
        {
                TimePeriodInternal.TwentyEightDayMonth,
            new Dictionary<TimeInterval, string>()
            {
                { TimeInterval.Minute, "twenty-eight-day-month-in-minutes" },
                { TimeInterval.Minute5, "twenty-eight-day-month-in-minutes5" },
                { TimeInterval.Minute15, "twenty-eight-day-month-in-minutes15" },
                { TimeInterval.Minute30, "twenty-eight-day-month-in-minutes30" },
                { TimeInterval.Hour, "twenty-eight-day-month-in-hours" },
            }
        },
        {
            TimePeriodInternal.TwentyNineDayMonth,
            new Dictionary<TimeInterval, string>()
            {
                { TimeInterval.Minute, "twenty-nine-day-month-in-minutes" },
                { TimeInterval.Minute5, "twenty-nine-day-month-in-minutes5" },
                { TimeInterval.Minute15, "twenty-nine-day-month-in-minutes15" },
                { TimeInterval.Minute30, "twenty-nine-day-month-in-minutes30" },
                { TimeInterval.Hour, "twenty-nine-day-month-in-hours" },
            }
        },
        {
            TimePeriodInternal.ThirtyDayMonth,
            new Dictionary<TimeInterval, string>()
            {
                { TimeInterval.Minute, "thirty-day-month-in-minutes" },
                { TimeInterval.Minute5, "thirty-day-month-in-minutes5" },
                { TimeInterval.Minute15, "thirty-day-month-in-minutes15" },
                { TimeInterval.Minute30, "thirty-day-month-in-minutes30" },
                { TimeInterval.Hour, "thirty-day-month-in-hours" },
            }
        },
        {
            TimePeriodInternal.ThirtyOneDayMonth,
            new Dictionary<TimeInterval, string>()
            {
                { TimeInterval.Minute, "thirty-one-day-month-in-minutes" },
                { TimeInterval.Minute5, "thirty-one-day-month-in-minutes5" },
                { TimeInterval.Minute15, "thirty-one-day-month-in-minutes15" },
                { TimeInterval.Minute30, "thirty-one-day-month-in-minutes30" },
                { TimeInterval.Hour, "thirty-one-day-month-in-hours" },
            }
        }
    };

        public static IEnumerable<Bar> ThatOccurredInTimePeriod(this IEnumerable<Bar> bars, DateTime periodStart, DateTime periodEnd)
            => bars.Where(b => !(b.To < periodStart || b.From > periodEnd));

        public static int GetStartColumn(this Bar bar, DateTime chartStart, TimeInterval interval)
        {
            if (bar.From.HasValue is false || bar.From.Value < chartStart) return 0;

            var result = PlotColumn(interval, chartStart, bar.From.Value);

            return result;
        }

        public static int GetEndColumn(this Bar bar, DateTime chartStart, TimeInterval interval, TimePeriodInternal timePeriod)
        {
            if (bar.To.HasValue is false || bar.To.Value > chartStart.AddDays((int)timePeriod)) return -1;

            var result = PlotColumn(interval, chartStart, bar.To.Value);

            return result;
        }

        private static int PlotColumn(TimeInterval interval, DateTime chart, DateTime bar)
        {
            var value = 0.0;

            value = (bar - chart).TotalMinutes / (int)interval;

            value += 1.0;

            value = Math.Round(value, 0);

            return (int)value;
        }

        public static string GetBarStyleCss(BarStyle style) 
        {
            switch (style)
            {
                case BarStyle.BackwardStripes:
                    return "backward-stripes";

                case BarStyle.ForwardStripes:
                    return "forward-stripes";

                case BarStyle.HorizontalStripes:
                    return "horizontal-stripes";

                case BarStyle.VerticalStripes:
                    return "vertical-stripes";

                case BarStyle.None:
                default:
                    return string.Empty;
            }
        }
    }
}
