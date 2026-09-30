namespace SunamoWf.Controls;

    // Nemuze byt genericky protoze bych to musel dat jak tu tak do Designer
    /// <summary>
    /// Dialog showing a label and a CheckedListBox.
    /// </summary>
    public partial class CHLBForm : Form
    {


        /// <summary>
        /// Creates the dialog with the given caption and list items.
        /// </summary>
        public CHLBForm(string label, params object[] items)
        {
            InitializeComponent();


            label1.Text = label;
            checkedListBox1.Items.AddRange(items);
        }

        /// <summary>
        /// Number of items the user checked.
        /// </summary>
        public int CheckedCount
        {
            get
            {
                return checkedListBox1.CheckedIndices.Count;
            }
        }
    }
