namespace SunamoWf.Controls;

/// <summary>
/// A TextBoxForms restricted to digits within a configurable [min,max] range.
/// </summary>
public class NumberTextBoxForms : TextBoxForms
{
    private string _previousText;
    private int _min;
    private int _max;

    /// <summary>
    /// Creates a number text box accepting any non-negative int value.
    /// </summary>
    public NumberTextBoxForms() : this(0, int.MaxValue) { }

    /// <summary>
    /// Creates a number text box accepting values in [min,max].
    /// </summary>
    public NumberTextBoxForms(int min, int max)
        : base()
    {
        if ((min > max) || min < 0 || max < 0)
        {
            throw new ArgumentException("Minimum and maximum values are not supported");
        }
        _min = min;
        _max = max;
        this.Text = min.ToString();
    }

    /// <inheritdoc/>
    protected override void OnKeyPress(KeyPressEventArgs eventArgs)
    {
        _previousText = this.Text;
        eventArgs.Handled = !char.IsDigit(eventArgs.KeyChar) && !char.IsControl(eventArgs.KeyChar);
    }

    /// <inheritdoc/>
    protected override void OnTextChanged(EventArgs eventArgs)
    {
        if (this.Text == string.Empty)
        {
            return;
        }

        int number;
        if (int.TryParse(this.Text, out number))
        {
            if (number > _max)
            {
                this.Text = _previousText;
                this.Select(this.Text.Length, 0);
            }
        }
        else
        {
            this.Text = _previousText;
            this.Select(this.Text.Length, 0);
        }
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
        int number;
        if (!int.TryParse(this.Text, out number) || number < _min || number > _max)
        {
            this.Text = _previousText;
            this.Select(this.Text.Length, 0);
        }
    }
}
