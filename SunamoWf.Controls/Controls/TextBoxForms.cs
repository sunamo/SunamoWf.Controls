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
    protected override void OnKeyUp(KeyEventArgs e)
    {
        base.OnKeyUp(e);

        if (e.Control)
        {
            if (e.KeyCode == Keys.A)
            {
                this.SelectAll();
            }
        }
    }
}
