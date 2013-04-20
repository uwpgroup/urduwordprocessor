using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Facebook;
using System.Text.RegularExpressions;
using UrduWordProcessor.Properties;

namespace UrduWordProcessor
{
    partial class FacebookAuthentication : Form
    {
        /// <summary>
        /// This is the default constructor for FacebookAuthentication form,
        /// it is used to let the user log in and get the authentication key for 
        /// FacebookClient dll
        /// </summary>
        public FacebookAuthentication() // constructor
        {
            InitializeComponent();
        }

        /// <summary>
        /// This gets the ID for facebook application in string format
        /// </summary>
        public string ApplicationId
        {
            get
            {
                return "235801556561461";
            }
        }

        /// <summary>
        /// This gets the Prmissions for the facebook application in string format
        /// </summary>
        public string ExtendedPermissions
        {
            get
            {
                return "user_about_me,publish_stream,photo_upload,status_update,manage_pages";
            }
        }

        /// <summary>
        /// This gets the secret key of facebook application in string format
        /// </summary>
        public string AppSecret
        {
            get
            {
                return "0b8781f093c8dbe938594dad76483420";
            }
        }

        /// <summary>
        /// This gets or sets the Access Token provided by facebook after authentication in string
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// This gets or sets the Type of post that should be used, i.e. post to user's wall
        /// or post to user's page
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// This Loads the authentication page
        /// </summary>
        public void LoadAuthorize()
        {
            var destinationURL = String.Format(@"https://www.facebook.com/dialog/oauth?client_id={0}&scope={1}&redirect_uri=http://www.facebook.com/connect/login_success.html&response_type=token",
                                    this.ApplicationId,
                                    this.ExtendedPermissions);
            webBrowser.Navigated += WebBrowserNavigated;
            webBrowser.Navigate(destinationURL);
        }

        private void WebBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // get token
            string url = e.Url.Fragment;

            if (url.Contains("access_token") && url.Contains("#"))
            {
                // this.Hide();
                url = (new Regex("#")).Replace(url, "?", 1);
                string at = System.Web.HttpUtility.ParseQueryString(url).Get("access_token");
                if (!at.Equals(""))
                {
                    this.AccessToken = at;
                    this.Hide();

                    FacebookPublishForm fpf = new FacebookPublishForm();
                    fpf.AccessToken = at;
                    fpf.Type = this.Type;
                    fpf.PageID = Settings.Default.FacebookPageID;
                    fpf.Show();
                } // end if()
            } // end if()
        }
    }
}
