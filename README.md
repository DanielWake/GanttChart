Author: Daniel Wake
Date: February 2024

Gantt Chart Component
======
This Gantt Chart component has been taken from a codepen (https://codepen.io/ph1p/pen/JBBjNy) and has been adapted to provide the following functionality:

Time Periods
-----
- Day broken down by hour (00 - 23)
- Five Day Week broken down by days of the week (Mon - Fri)
- Seven Day Week broken down by days of the week (Mon - Sun)
- Month broken down by day (auto detects 28, 29, 30, 31 - including leap years)

Time intervals
-----
- All data is displayed to the minute.
- A framework is in place to support the following intervals, however, they currently haven't been hooked up yet:
	- 5 minute
	- 10 minute
	- 15 minute
	- 30 minute
	- 60 minutes (1 hour)

Current hour/day highlighting
-----
- Depending on the Time Period, the current hour of the day or day of the week/month is highlighted when it matched the current date and time

Rows
-----
- Rows are displayed in the order they are passed to the Gantt Chart
- Heading text is customisable

Bars
-----
- Text is customisable
- Colour is customisable
- Colour styles are available:
	- striped horizontal/vertical/forward/backward

Settings
-----
- ChartIsScrollable
- HidebarTitles


Author Notes
-----
The chart has been designed to offer a great amount of flexibility to the consumer, either through C# above or via CSS below. 

If changes of appearance are required, they are to be done through a custom stylesheet and not by modifying the artefacts within the component.
If functionality such as toggling views, showing/hiding text, changing the chart size, is required it is to be done outside of this component and in no way incorporated within it.

Notable CSS classes
-----
Modify static chart width.
`.row-content` 

Modify scrollable chart width (class per time-period)
`.row-content-day` 
`.row-content-5dayweek`
`.row-content-7dayweek`
`.row-content-month`

Usage
-----
There are two ready to use pages within the Demo folder which can be consumed by a Blazor application to get a feel of how the Gantt Chart is intended to be used.
One page demonstrates a single Day in a static format, whilst the other shows a Day which is scrollable to give a granular look at the day’s events.


Todo
-----
- Confirm how UTC is being handled



