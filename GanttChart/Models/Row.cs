namespace GanttChart.Models;

public class Row
{
    public string Title { get; set; } = "";

    public IEnumerable<Bar> Bars { get; set; } = new List<Bar>();
}
