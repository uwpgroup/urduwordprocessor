// created by: Syed Tahir Ali Jan

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace UrduWordProcessor
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void navBarControl_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void findribbongroup_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void iClose_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}