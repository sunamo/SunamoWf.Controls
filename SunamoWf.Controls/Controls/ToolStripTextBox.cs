namespace SunamoWf.Controls;

/// <summary>
/// A ToolStripTextBox with Ctrl+A select-all support.
/// </summary>
public class ToolStripTextBox : System.Windows.Forms.ToolStripTextBox
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
