namespace SunamoWf.Controls;

/// <summary>
/// A TextBoxForms that rejects whitespace key presses.
/// </summary>
public class AlphaNumericTextBox : TextBoxForms
{
    private string _previousText;

    /// <inheritdoc/>
    protected override void OnKeyPress(KeyPressEventArgs eventArgs)
    {
        _previousText = this.Text;
        eventArgs.Handled = !char.IsWhiteSpace(eventArgs.KeyChar);
    }

    /// <inheritdoc/>
    protected override void OnTextChanged(EventArgs eventArgs)
    {
    }

    /// <summary>
    /// Parses the current text as an int, returning 0 when it is not a valid number.
    /// </summary>
    public int Number
    {
        get
        {
            int number = 0;
            if (int.TryParse(Text, out number))
            {
                return number;
            }
            return 0;
        }
    }

    /// <inheritdoc/>
    protected override void OnLeave(EventArgs eventArgs)
    {
    }
}
