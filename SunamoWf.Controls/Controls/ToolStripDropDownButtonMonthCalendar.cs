namespace SunamoWf.Controls;

/// <summary>
/// A ToolStripDropDownButton whose dropdown contains a ToolStripMonthCalendar.
/// </summary>
public class ToolStripDropDownButtonMonthCalendar : ToolStripDropDownButton
{
    /// <summary>
    /// The hosted month calendar dropdown item.
    /// </summary>
    public ToolStripMonthCalendar MonthCalendar = new ToolStripMonthCalendar();

    /// <summary>
    /// Wires the calendar's DateChanged event and adds it to the dropdown items.
    /// </summary>
    public ToolStripDropDownButtonMonthCalendar()
    {
        MonthCalendar.DateChanged += MonthCalendar_DateChanged;
        DropDownItems.Add(MonthCalendar);
    }

    private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
    {
        OnDateChanged(sender, e);
    }

    /// <summary>
    /// Gets/sets the first day of the week shown by the calendar.
    /// </summary>
    public Day FirstDayOfWeek
    {
        get
        {
            return MonthCalendar.FirstDayOfWeek;
        }
        set { MonthCalendar.FirstDayOfWeek = value; }
    }

    /// <summary>
    /// Sets the maximum number of selectable days.
    /// </summary>
    public int MaxSelectionDays
    {
        set
        {
            MonthCalendar.MaxSelectionDays = value;
        }
    }

    /// <summary>
    /// Raised when the selected date range changes.
    /// </summary>
    public event DateRangeEventHandler DateChanged;

    private void OnDateChanged(object sender, DateRangeEventArgs e)
    {
        if (DateChanged != null)
        {
            DateChanged(this, e);
        }
    }
}
