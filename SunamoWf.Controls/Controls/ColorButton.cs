namespace SunamoWf.Controls;

/// <summary>
/// A Button that opens a color picker dialog on click and shows the chosen color as its background.
/// </summary>
public class ColorButton : Button
{
    /// <summary>
    /// Clears the button text.
    /// </summary>
    public ColorButton()
    {
        Text = "";
    }

    /// <summary>
    /// Raised when a new color is selected.
    /// </summary>
    public event VoidColor ColorChanged;

    /// <inheritdoc/>
    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);

        ColorDialog colorDialog = new ColorDialog();
        colorDialog.SolidColorOnly = true;
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            SelectedColor = colorDialog.Color;
        }
    }

    private Color TextColor
    {
        set
        {
            ForeColor = value;
        }
    }

    /// <summary>
    /// Gets/sets the selected color, shown as the button's background.
    /// </summary>
    public Color SelectedColor
    {
        get
        {
            return BackColor;
        }
        set
        {
            if (ColorChanged != null)
            {
                ColorChanged(value);
            }
            BackColor = value;
        }
    }
}
