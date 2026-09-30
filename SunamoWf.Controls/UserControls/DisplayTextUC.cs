namespace SunamoWf.Controls;



/// <summary>
/// User control showing one or two texts (second in a collapsible panel).
/// </summary>
public class DisplayTextUC : UserControl
{
    SplitContainer sc = new SplitContainer();
    TextBoxForms txt = new TextBoxForms();
    TextBoxForms txt2 = new TextBoxForms();

    /// <summary>
    /// Creates the control; when text2 is null the second panel is not created.
    /// </summary>
    public DisplayTextUC(string text, string text2)
    {
        this.SuspendLayout();
        if (text2 == null)
        {
            txt.Dock = DockStyle.Fill;
            txt.Multiline = true;
            txt.Text = text;
            Controls.Add(txt);
        }
        else
        {
            sc.SuspendLayout();
            sc.Dock = DockStyle.Fill;
            if (text2 == null)
            {
                sc.Panel2Collapsed = true;
            }
            else
            {
                txt2.Text = text2;
            }

            txt.Dock = DockStyle.Fill;
            txt.Multiline = true;
            sc.Panel1.Controls.Add(txt);

            txt2.Dock = DockStyle.Fill;
            txt2.Multiline = true;
            sc.Panel2.Controls.Add(txt2);

            txt.Text = text;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(sc);
            sc.ResumeLayout(false);
        }
        this.ResumeLayout(false);
    }

    /// <summary>
    /// Gets or sets the text of the first box, marshalled to the UI thread.
    /// </summary>
    public string Content
    {
        get
        {
            
            return (string)this.Invoke(new Func<string>(() => txt.Text));
        }
        set
        {
            this.Invoke(new Action(() => txt.Text = value));
        }
    } 

    /// <summary>
    /// Keeps the split container divided evenly after the form is resized.
    /// </summary>
    protected override void OnResize(System.EventArgs e)
    {
        base.OnResize(e);
        if (true)
        {
            // Pro jistotu to je nastavene na vyssi nez 200
            if (ClientSize.Width > 210)
            {

                sc.SplitterDistance = ClientSize.Width - 200;
                sc.Panel2Collapsed = false;
            }
            else
            {
                sc.Panel2Collapsed = true;
            }
        }
        
        
    }
}
