namespace SunamoWf.Controls;

/// <summary>
/// A ToolStripTextBox with Ctrl+A select-all support.
/// </summary>
public class ToolStripTextBox : System.Windows.Forms.ToolStripTextBox
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
