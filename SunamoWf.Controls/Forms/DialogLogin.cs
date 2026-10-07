namespace SunamoWf.Controls;

    /// <summary>
    /// Simple login dialog with login, password and a remember-password option.
    /// </summary>
    public partial class DialogLogin : Form
    {
        //bool publicSaveLogic = false;
        //const string h = "h";
        //const string l = "l";

        ///// <summary>
        ///// 
        ///// </summary>
        //public DialogLogin()
        //{
        //    InitializeComponent();
        //}

        ///// <summary>
        ///// A1 je vhodna tehdy kdyz napriklad poustim python skripty, ve kterych nemuzu overit zda se mi podarilo nalogovat
        ///// </summary>
        ///// <param name="publicSaveLogic"></param>
        //public DialogLogin(bool publicSaveLogic)
        //    : this()
        //{
        //    this.publicSaveLogic = publicSaveLogic;
        //    if (publicSaveLogic)
        //    {
        //        this.txtHeslo.Text = RA.ReturnValueString(h);
        //        this.txtLogin.Text = RA.ReturnValueString(l);
        //        this.chbUlozHeslo.Checked = this.txtHeslo.Text != "";
        //    }
        //}

        /// <summary>
        /// Handles the first button click.
        /// </summary>
        private void button1_Click(object sender, EventArgs eventArgs)
        {
            //    if (publicSaveLogic)
            //    {
            //        RA.WriteToKeyString(h, "");
            //        RA.WriteToKeyString(l, this.txtLogin.Text);

            //        if (this.chbUlozHeslo.Checked)
            //        {
            //            RA.WriteToKeyString(h, this.txtHeslo.Text);
            //        }

            //        if (txtLogin.Text.Trim() != "" && txtHeslo.Text.Trim() != "")
            //        {
            //            DialogResult = System.Windows.Forms.DialogResult.OK;
            //        }
            //        else
            //        {
            //            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //        }

            //    }
            //    else
            //    {
            //        DialogResult = System.Windows.Forms.DialogResult.OK;
            //    }
            }

        /// <summary>
        /// Handles the second button click.
        /// </summary>
        private void button2_Click(object sender, EventArgs eventArgs)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        //public bool HaveLoginedData()
        //{
        //    string he = RA.ReturnValueString(h);
        //    string lo = RA.ReturnValueString(l);

        //    return he != "" && lo != "";
        //}
    }
