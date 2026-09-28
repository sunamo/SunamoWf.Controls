namespace SunamoWf.Controls;

/// <summary>
/// A PictureBox that can receive focus/selection (ControlStyles.Selectable).
/// </summary>
public class SelectablePictureBox : PictureBox
{
    /// <summary>
    /// Enables the Selectable control style.
    /// </summary>
    public SelectablePictureBox()
    {
        SetStyle(ControlStyles.Selectable, true);
    }
}
