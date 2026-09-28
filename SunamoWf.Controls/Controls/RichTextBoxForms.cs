namespace SunamoWf.Controls;

/// <summary>
/// A RichTextBox with Ctrl+A select-all support.
/// </summary>
public class RichTextBoxForms : RichTextBox
{
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
