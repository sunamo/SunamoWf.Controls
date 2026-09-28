namespace SunamoWf.Controls;

/// <summary>
/// Raised when a color-related event occurs (e.g. ColorButton.ColorChanged).
/// </summary>
public delegate void VoidColor(Color color);

/// <summary>
/// Sets text into a TextBoxForms.
/// </summary>
public delegate void SetTextInTextBoxForms(TextBoxForms textBox, string text);

/// <summary>
/// Appends a line of text into a TextBoxForms.
/// </summary>
public delegate void AppendLineInTextBoxForms(TextBoxForms textBox, string text);

/// <summary>
/// Appends a line of text into a plain TextBox.
/// </summary>
public delegate void AppendLineInTextBox(TextBox textBox, string text);

/// <summary>
/// Reads the current text of a TextBoxForms.
/// </summary>
public delegate string GetTextInTextBoxForms(TextBoxForms textBox);

/// <summary>
/// Clears all nodes of a TreeView.
/// </summary>
public delegate void ClearAllNodesTreeView(TreeView treeView);

/// <summary>
/// Carries a string together with an icon.
/// </summary>
public delegate void VoidStringIcon(string text, Icon icon);
