using GanttChart.Models.Enums;

namespace GanttChart.Models;

public class Bar
{
    public int? Id { get; set; }
    public string Title { get; set; } = "";

    public DateTime? From { get; set; }
    public DateTime? To { get; set; }

    public string Colour { get; set; } = "#2ecaac";
    public BarStyle Style { get; set; } = BarStyle.None;

        
}
