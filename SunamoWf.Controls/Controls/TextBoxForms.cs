namespace SunamoWf.Controls;

/// <summary>
/// A WinForms TextBox with a vertical scrollbar and Ctrl+A select-all support.
/// </summary>
public class TextBoxForms : TextBox
{
    /// <summary>
    /// Enables the vertical scrollbar.
    /// </summary>
    public TextBoxForms()
    {
        ScrollBars = ScrollBars.Vertical;
    }

    /// <inheritdoc/>
    protected override void OnKeyUp(KeyEventArgs eventArgs)
    {
        base.OnKeyUp(eventArgs);

        if (eventArgs.Control)
        {
            if (eventArgs.KeyCode == Keys.A)
            {
                this.SelectAll();
            }
        }
    }
}
