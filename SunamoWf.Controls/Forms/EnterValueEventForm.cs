using System.ComponentModel;
namespace SunamoWf.Controls;

    /// <summary>
    /// Small window with a label and a text box that raises an event when Enter is pressed.
    /// </summary>
    public partial class EnterValueEventForm : Form
    {
        private Button button1;
        /// <summary>
        /// The text box for the entered value.
        /// </summary>
        public TextBox TextBox1;
        private Label label1;

        #region wf
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Releases resources used by the form.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Creates and lays out the controls of the form.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(264, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.Location = new System.Drawing.Point(15, 27);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(243, 20);
            this.TextBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter a value and press enter" + ":";
            // 
            // EnterValueEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(326, 59);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label1);
            this.Name = "EnterValueEventForm";
            this.Text = "SMText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #endregion

        /// <summary>
        /// Raised with the entered text after Enter is pressed.
        /// </summary>
        public event Action<string> Zadani;

        /// <summary>
        /// Creates the form and wires the Enter handling.
        /// </summary>
        public EnterValueEventForm()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(VyvolejUdalostPoEntru);
            this.Closing += new CancelEventHandler(SMText_Closing);


        }

        /// <summary>
        /// Prevents closing the form with the close button.
        /// </summary>
        void SMText_Closing(object sender, CancelEventArgs eventArgs)
        {
            eventArgs.Cancel = true;
        }

        /// <summary>
        /// Hides the form and raises Zadani after Enter is pressed.
        /// </summary>
        void VyvolejUdalostPoEntru(object sender, KeyEventArgs eventArgs)
        {
            if (eventArgs.KeyData == Keys.Enter)
            {
                SkryjForm();

                if (Zadani != null)
                {
                    Zadani(TextBox1.Text);
                }
            }
        }

        /// <summary>
        /// Hides the form and sets DialogResult to OK.
        /// </summary>
        private void SkryjForm()
        {
            DialogResult = DialogResult.OK;
            this.Visible = false;
        }

        /// <summary>
        /// Creates the form with the given caption (without colon).
        /// </summary>
        public EnterValueEventForm(string label)
            : this()
        {
            Text = "Enter" + " " + label;
            label1.Text = "Enter" + " " + label + " and press enter: ";
        }

        /// <summary>
        /// Handles the first button click.
        /// </summary>
        private void button1_Click(object sender, EventArgs eventArgs)
        {
            SkryjForm();
        }
    }
