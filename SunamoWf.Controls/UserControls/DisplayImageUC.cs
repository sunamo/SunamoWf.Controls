namespace SunamoWf.Controls;



/// <summary>
/// User control showing an image next to a text with its basic info.
/// </summary>
public class DisplayImageUC : UserControl
    {
        SplitContainer sc = new SplitContainer();
        TextBoxForms infoOmage = new TextBoxForms();
        PictureBox pbImage = new PictureBox();

        /// <summary>
        /// Creates the control for the given image.
        /// </summary>
        public DisplayImageUC(Bitmap image)
        {
            this.SuspendLayout();
            sc.SuspendLayout();
            sc.Dock = DockStyle.Fill;
            infoOmage.Dock = DockStyle.Fill;
            infoOmage.Multiline = true;
            pbImage.Width = image.Width;
            pbImage.Height = image.Height;
            sc.Panel2.Controls.Add(infoOmage);
            sc.Panel1.Controls.Add(pbImage);

            infoOmage.Text = _sunamo.SunamoWfHelpers.PictureInfo.InfoAbout(image);
            pbImage.Image = image;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(sc);
            sc.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        /// <summary>
        /// Keeps the split container divided evenly after the form is resized.
        /// </summary>
        protected override void OnResize(System.EventArgs eventArgs)
        {
            base.OnResize(eventArgs);

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
//}
