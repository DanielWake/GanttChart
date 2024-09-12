namespace GanttChart.Models;

public class Settings
{
    /// <summary>
    /// Enable to make the chart scroll horizontally
    /// </summary>
    public bool ChartIsScrollable { get; set; } = false;

    /// <summary>
    /// Enable to hide titles on the bars
    /// </summary>
    public bool HideBarTitles { get; set; } = false;
}
