namespace SunamoWf.Controls;

/// <summary>
/// A ComboBox pre-filled with the names of enum T. Cannot be added in the Designer since it is generic -
/// use ComboBoxEnumHelper there instead.
/// </summary>
/// <typeparam name="T">The enum type whose names populate the combo box.</typeparam>
public class ComboBoxEnum<T> : ComboBox
{
    /// <summary>
    /// Populates the combo box with the enum's names.
    /// </summary>
    public ComboBoxEnum()
        : base()
    {
        AddItems();
    }

    /// <summary>
    /// Returns the currently selected item parsed back into the enum type.
    /// </summary>
    public T GetSelected()
    {
        return (T)Enum.Parse(typeof(T), SelectedItem.ToString());
    }

    /// <summary>
    /// Selects the item matching the given enum value.
    /// </summary>
    public void SetSelected(T value)
    {
        for (int i = 0; i < Items.Count; i++)
        {
            string itemText = Items[i].ToString();
            if (itemText == value.ToString())
            {
                SelectedIndex = i;
                break;
            }
        }
    }

    private void AddItems()
    {
        if (!DesignMode)
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string item in Enum.GetNames(typeof(T)))
            {
                if (!Items.Contains(item))
                {
                    this.Items.Add(item);
                }
            }
            this.SelectedIndex = 0;
            this.Text = Items[0].ToString();
        }
    }
}
