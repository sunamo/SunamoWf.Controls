namespace SunamoWf.Controls;

/// <summary>
/// Base DataGridView with helpers for building strongly typed columns.
/// </summary>
/// <remarks>
/// Subclasses that need edit-safety should override: OnCellBeginEdit (save the original value before an edit
/// that cannot be prevented), OnDataError (restore the original value), OnCurrentCellDirtyStateChanged (must call
/// CommitEdit(DataGridViewDataErrorContexts.Commit), otherwise the last edited value may not be saved), and
/// OnCellValueChanged (restore the old value when the new one cannot be parsed).
/// </remarks>
public class BaseDataGridView : DataGridView
{
    private int _columnOrder = 0;

    /// <summary>
    /// Disables automatic column generation so columns are added manually.
    /// </summary>
    public virtual void CreateColumns()
    {
        this.AutoGenerateColumns = false;
    }

    /// <summary>
    /// Creates a combo box column bound to the given property.
    /// </summary>
    protected DataGridViewColumn NewComboBoxColumn(string propertyName)
    {
        DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
        column.DataPropertyName = propertyName;
        column.HeaderText = propertyName;
        _columnOrder++;
        return column;
    }

    /// <summary>
    /// Creates a checkbox column bound to the given boolean property.
    /// </summary>
    protected DataGridViewColumn NewCheckedBoxColumn(string propertyName)
    {
        DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
        column.DataPropertyName = propertyName;
        column.HeaderText = propertyName;
        column.ValueType = typeof(bool);
        _columnOrder++;
        return column;
    }

    /// <summary>
    /// Creates a combo box column populated with the names of the given enum type.
    /// </summary>
    protected DataGridViewComboBoxColumn NewComboBoxColumn(string propertyName, Type enumType)
    {
        DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
        column.Items.AddRange(Enum.GetNames(enumType));
        column.Name = propertyName;
        column.DisplayMember = propertyName;
        column.HeaderText = propertyName;
        _columnOrder++;
        return column;
    }

    /// <summary>
    /// Creates a text box column bound to the given property, restricted to the given CLR type.
    /// </summary>
    protected DataGridViewTextBoxColumn NewTextBoxColumn(string propertyName, Type allowedType)
    {
        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
        column.DataPropertyName = propertyName;
        column.HeaderText = propertyName;
        column.ValueType = allowedType;
        _columnOrder++;
        return column;
    }

    /// <summary>
    /// Creates a text box column bound to the given property.
    /// </summary>
    protected DataGridViewColumn NewTextBoxColumn(string propertyName)
    {
        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
        column.DataPropertyName = propertyName;
        column.HeaderText = propertyName;
        _columnOrder++;
        return column;
    }
}
