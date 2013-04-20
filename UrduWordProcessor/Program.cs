using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using UrduWordProcessor.Properties;
using DevExpress.LookAndFeel;

namespace UrduWordProcessor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.CurrentLanguage);
            urduWordProcessor uwp = new urduWordProcessor();
            Application.Run(uwp);
        }
    }
}