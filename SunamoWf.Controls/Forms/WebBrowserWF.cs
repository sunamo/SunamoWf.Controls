using System.Collections.Generic;
namespace SunamoWf.Controls;



/// <summary>
/// Simple browser window with back, next, reload, home, close and custom buttons.
/// </summary>
public partial class WebBrowserWF : Form
    {
        Uri uri = null;
        bool canGoBack = false;
        bool canGoNext = false;
        List<Uri> lastUri = new List<Uri>();
        int actualIndex = 0;
        /// <summary>
        /// Raised when the custom button is clicked.
        /// </summary>
        public event UriEventHandler CustomButtonClick;
        /// <summary>
        /// Raised when the close button is clicked.
        /// </summary>
        public event Action CloseButtonClick;
        string homeAdressWithoutHttp = null;
        /// <summary>
        /// Raised when a navigation has completed.
        /// </summary>
        public event WebBrowserNavigatedEventHandler LoadCompleted;
        bool reload = false;
        List<bool> backnext = new List<bool>();

        /// <summary>
        /// Creates the window with the custom button text and home address.
        /// </summary>
        public WebBrowserWF(string TextCustomButton, string homeAdressWithoutHttp)
        {
            InitializeComponent();

            //this.homeAdressWithoutHttp = homeAdressWithoutHttp;
            //btnBack.Image = DrawingImagesHelper.MsAppx(true, AppPics.Previous);
            //btnNext.Image = DrawingImagesHelper.MsAppx(true, AppPics.Next);
            //btnReload.Image = DrawingImagesHelper.MsAppx(false, AppPics.Reload);
            //btnHome.Image = DrawingImagesHelper.MsAppx(false, AppPics.Home);
            //btnClose.Image = DrawingImagesHelper.MsAppx(false, AppPics.Logout);

            //if (TextCustomButton != "")
            //{
            //    btnCustom.Text = TextCustomButton;
            //    btnCustom.Visible = true;

            //    //btnCustom.Content = ImagesHelper.MsAppx(true, AppPics.BoardPin);
            //}
            //else
            //{
            //    btnCustom.Visible = false;
            //}

            //webView.Navigated += webView_Navigated;
            //NavigateHome();
        }

        /// <summary>
        /// Handles completed navigation of the embedded browser.
        /// </summary>
        void webView_Navigated(object sender, WebBrowserNavigatedEventArgs eventArgs)
        {
            //if (!reload)
            //{
            //    uri = e.Url;
            //    txtAddress.Text = uri.ToString();

            //    lastUri.Add(uri);

            //    if (actualIndex != 0)
            //    {
            //        btnBack.Image = DrawingImagesHelper.MsAppx(false, AppPics.Previous);
            //        canGoBack = true;
            //    }
            //    else
            //    {
            //        btnBack.Image = DrawingImagesHelper.MsAppx(true, AppPics.Previous);
            //        canGoBack = false;
            //    }
            //    if (actualIndex == lastUri.Count - 1 || (backnext[backnext.Count - 1] == true && backnext[backnext.Count - 2] == false))
            //    {
            //        btnNext.Image = DrawingImagesHelper.MsAppx(true, AppPics.Next);
            //        canGoNext = false;
            //    }
            //    else
            //    {
            //        btnNext.Image = DrawingImagesHelper.MsAppx(false, AppPics.Next);
            //        canGoNext = true;
            //    }
            //    LoadCompleted(sender, e);
            //}
        }

        //public void EnableCustomButton(bool enable)
        //{
        //    btnCustom.Enabled = enable;
        //    btnCustom.Image = DrawingImagesHelper.MsAppx(!enable, AppPics.BoardPin);
        //}

        /// <summary>
        /// Navigates one step back in the history.
        /// </summary>
        private void btnBack_Click_1(object sender, EventArgs eventArgs)
        {
            if (canGoBack)
            {
                reload = false;
                backnext.Add(false);
                actualIndex--;
                webView.Navigate(lastUri[actualIndex]);
            }
        }

        /// <summary>
        /// Navigates one step forward in the history.
        /// </summary>
        private void btnNext_Click_1(object sender, EventArgs eventArgs)
        {
            if (canGoNext)
            {
                reload = false;
                backnext.Add(true);
                actualIndex++;
                webView.Navigate(lastUri[actualIndex]);
            }
        }

        /// <summary>
        /// Reloads the current address.
        /// </summary>
        private void btnReload_Click_1(object sender, EventArgs eventArgs)
        {
            reload = true;
            backnext.Add(false);
            webView.Navigate(uri);
        }

        /// <summary>
        /// Clears the history and navigates home.
        /// </summary>
        private void btnHome_Click_1(object sender, EventArgs eventArgs)
        {
            reload = true;
            backnext.Clear();
            lastUri.Clear();
            backnext.Add(false);
            NavigateHome();
        }

        /// <summary>
        /// Navigates to the home address.
        /// </summary>
        private void NavigateHome()
        {
            reload = false;
            backnext.Add(false);
            webView.Navigate(new Uri("http://" + homeAdressWithoutHttp));
        }

        /// <summary>
        /// Raises CustomButtonClick with the current address.
        /// </summary>
        private void btnCustom_Click_1(object sender, EventArgs eventArgs)
        {
            CustomButtonClick(webView, new UriEventArgs(uri));
        }

        /// <summary>
        /// Raises CloseButtonClick.
        /// </summary>
        private void btnClose_Click_1(object sender, EventArgs eventArgs)
        {
            CloseButtonClick();
        }

        /// <summary>
        /// Navigates to the typed address when Enter is pressed.
        /// </summary>
        private void txtAddress_KeyUp_1(object sender, KeyEventArgs eventArgs)
        {
            if (eventArgs.KeyData == Keys.Enter)
            {
                Uri uriOut = null;
                if (Uri.TryCreate(txtAddress.Text, UriKind.Absolute, out uriOut))
                {
                    reload = false;
                    actualIndex++;
                    webView.Navigate(uriOut);
                }
            }
        }
    }
