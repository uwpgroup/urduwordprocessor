using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using UrduWordProcessor.Properties;
using System.Globalization;
using System.Threading;

namespace UrduWordProcessor
{
    partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void comboBoxUILangSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUILangSelection.SelectedIndex == 0)
            {
                // MessageBox.Show("English");
                Settings.Default.CurrentLanguage = "en";
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
                Settings.Default.Save();
                Application.Restart();
            }
            else if (comboBoxUILangSelection.SelectedIndex == 1)
            {
                // MessageBox.Show("Urdu");
                Settings.Default.CurrentLanguage = "ur-PK";
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ur-PK");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("ur-PK");
                Settings.Default.Save();
                Application.Restart();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            this.Hide();
        }

        private void radioButtonFBPageNo_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFBPageID.Enabled = false;
            textBoxFBPageID.Text = "";
            Settings.Default.FacebookPageID = "-1";
            Settings.Default.Save();
        }

        private void radioButtonFBPageYes_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFBPageID.Enabled = true;
        }

        private void buttonSaveFBPageID_Click(object sender, EventArgs e)
        {
            Settings.Default.FacebookPageID = textBoxFBPageID.Text;
            Settings.Default.Save();
        }
    }
}
