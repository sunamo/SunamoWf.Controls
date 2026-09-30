namespace SunamoWf.Controls;

/// <summary>
/// Fills an existing ComboBox (for example one created in the Designer) with the names of enum T
/// and provides typed access to the selection. Use it where the generic ComboBoxEnum cannot be used.
/// </summary>
/// <typeparam name="T">The enum type whose names populate the combo box.</typeparam>
public class ComboBoxEnumHelper<T>
{
    private readonly ComboBox comboBox;

    /// <summary>
    /// Makes the combo box a drop-down list, adds the enum names and selects the first one.
    /// </summary>
    public ComboBoxEnumHelper(ComboBox comboBox)
    {
        this.comboBox = comboBox;
        AddItems();
    }

    /// <summary>
    /// Returns the currently selected item parsed back into the enum type.
    /// </summary>
    public T GetSelected()
    {
        return (T)Enum.Parse(typeof(T), comboBox.SelectedItem.ToString());
    }

    /// <summary>
    /// Selects the item matching the given enum value.
    /// </summary>
    public void SetSelected(T value)
    {
        for (int i = 0; i < comboBox.Items.Count; i++)
        {
            if (comboBox.Items[i].ToString() == value.ToString())
            {
                comboBox.SelectedIndex = i;
                break;
            }
        }
    }

    /// <summary>
    /// Removes the item of the given enum value from the combo box.
    /// </summary>
    public void RemoveEnumItem(T value)
    {
        int index = comboBox.Items.IndexOf(value.ToString());
        if (index >= 0)
        {
            comboBox.Items.RemoveAt(index);
        }
    }

    /// <summary>
    /// Selects the item at the given index.
    /// </summary>
    public void SetSelectedIndex(int index)
    {
        comboBox.SelectedIndex = index;
    }

    private void AddItems()
    {
        comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        foreach (string name in Enum.GetNames(typeof(T)))
        {
            if (!comboBox.Items.Contains(name))
            {
                comboBox.Items.Add(name);
            }
        }
        comboBox.SelectedIndex = 0;
    }
}
