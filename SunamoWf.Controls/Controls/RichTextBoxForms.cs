namespace SunamoWf.Controls;

/// <summary>
/// A RichTextBox with Ctrl+A select-all support.
/// </summary>
public class RichTextBoxForms : RichTextBox
{
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
