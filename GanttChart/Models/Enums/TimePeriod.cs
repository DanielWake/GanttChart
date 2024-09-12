namespace GanttChart.Models.Enums;

/// <summary>
/// Integer besides the enum represents days.
/// This value is used to determine what the end date of a given Gantt chart is,
/// for the purposes of indicating whether the bar continues into the future with a flat | bar end 
/// or ends at the end of the chart with a curved ) bar end.
/// </summary>
public enum TimePeriod
{
    Hour = 0,
    Day = 1,
    FiveDayWeek = 5,
    SevenDayWeek = 7,
    Month,
    Quarter = 91,
    Year = 365
}
