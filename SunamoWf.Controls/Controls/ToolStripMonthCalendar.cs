namespace SunamoWf.Controls;

/// <summary>
/// Hosts a MonthCalendar inside a ToolStrip, exposing FirstDayOfWeek, MaxSelectionDays and DateChanged.
/// </summary>
public class ToolStripMonthCalendar : ToolStripControlHost
{
    /// <summary>
    /// Creates the hosted MonthCalendar instance.
    /// </summary>
    public ToolStripMonthCalendar() : base(new MonthCalendar()) { }

    /// <summary>
    /// The hosted MonthCalendar control.
    /// </summary>
    public MonthCalendar MonthCalendar
    {
        get
        {
            return Control as MonthCalendar;
        }
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
            MonthCalendar.MaxSelectionCount = value;
        }
    }

    /// <summary>
    /// Bolds the given date on the calendar.
    /// </summary>
    public void AddBoldedDate(DateTime dateToBold)
    {
        MonthCalendar.AddBoldedDate(dateToBold);
    }

    /// <inheritdoc/>
    protected override void OnSubscribeControlEvents(Control control)
    {
        base.OnSubscribeControlEvents(control);

        MonthCalendar monthCalendarControl = (MonthCalendar)control;
        monthCalendarControl.DateChanged += OnDateChanged;
    }

    /// <inheritdoc/>
    protected override void OnUnsubscribeControlEvents(Control control)
    {
        base.OnUnsubscribeControlEvents(control);

        MonthCalendar monthCalendarControl = (MonthCalendar)control;
        monthCalendarControl.DateChanged -= OnDateChanged;
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
