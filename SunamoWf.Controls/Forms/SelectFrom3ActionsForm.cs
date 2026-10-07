namespace SunamoWf.Controls;

    /// <summary>
    /// Dialog with a list and Yes / No / Cancel buttons.
    /// </summary>
    public partial class SelectFrom3ActionsForm : Form
    {
        /// <summary>
        /// Creates the dialog with the given title, introduction, list items and button captions.
        /// </summary>
        public SelectFrom3ActionsForm(string formTitle, string labelIntroduction, object[] lbitems, string buttonYes, string buttonNo, string buttonCancel)
        {
            InitializeComponent();

            Text = formTitle;
            label1.Text = labelIntroduction;
            listBox1.Items.AddRange(lbitems);
            button3.Text = buttonYes;
            button2.Text = buttonNo;
            button1.Text = buttonCancel;
        }

        /// <summary>
        /// Handles the third button click.
        /// </summary>
        private void button3_Click(object sender, EventArgs eventArgs)
        {
            DialogResult = DialogResult.Yes;
        }

        /// <summary>
        /// Handles the second button click.
        /// </summary>
        private void button2_Click(object sender, EventArgs eventArgs)
        {
            DialogResult = DialogResult.No;
        }

        /// <summary>
        /// Handles the first button click.
        /// </summary>
        private void button1_Click(object sender, EventArgs eventArgs)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
