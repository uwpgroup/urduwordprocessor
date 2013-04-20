namespace UrduWordProcessor
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.tabControlGeneral = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxUILayout = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUILangSelection = new System.Windows.Forms.ComboBox();
            this.tabPageSocialMedia = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxFBPageID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonFBPageNo = new System.Windows.Forms.RadioButton();
            this.radioButtonFBPageYes = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonSaveFBPageID = new System.Windows.Forms.Button();
            this.tabControlGeneral.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageSocialMedia.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlGeneral
            // 
            this.tabControlGeneral.Controls.Add(this.tabPageGeneral);
            this.tabControlGeneral.Controls.Add(this.tabPageSocialMedia);
            resources.ApplyResources(this.tabControlGeneral, "tabControlGeneral");
            this.tabControlGeneral.Name = "tabControlGeneral";
            this.tabControlGeneral.SelectedIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPageGeneral, "tabPageGeneral");
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxUILayout);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxUILangSelection);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // comboBoxUILayout
            // 
            this.comboBoxUILayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUILayout.FormattingEnabled = true;
            this.comboBoxUILayout.Items.AddRange(new object[] {
            resources.GetString("comboBoxUILayout.Items"),
            resources.GetString("comboBoxUILayout.Items1")});
            resources.ApplyResources(this.comboBoxUILayout, "comboBoxUILayout");
            this.comboBoxUILayout.Name = "comboBoxUILayout";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBoxUILangSelection
            // 
            this.comboBoxUILangSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUILangSelection.FormattingEnabled = true;
            this.comboBoxUILangSelection.Items.AddRange(new object[] {
            resources.GetString("comboBoxUILangSelection.Items"),
            resources.GetString("comboBoxUILangSelection.Items1")});
            resources.ApplyResources(this.comboBoxUILangSelection, "comboBoxUILangSelection");
            this.comboBoxUILangSelection.Name = "comboBoxUILangSelection";
            this.comboBoxUILangSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxUILangSelection_SelectedIndexChanged);
            // 
            // tabPageSocialMedia
            // 
            this.tabPageSocialMedia.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPageSocialMedia, "tabPageSocialMedia");
            this.tabPageSocialMedia.Name = "tabPageSocialMedia";
            this.tabPageSocialMedia.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSaveFBPageID);
            this.groupBox3.Controls.Add(this.textBoxFBPageID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.radioButtonFBPageNo);
            this.groupBox3.Controls.Add(this.radioButtonFBPageYes);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // textBoxFBPageID
            // 
            resources.ApplyResources(this.textBoxFBPageID, "textBoxFBPageID");
            this.textBoxFBPageID.Name = "textBoxFBPageID";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // radioButtonFBPageNo
            // 
            resources.ApplyResources(this.radioButtonFBPageNo, "radioButtonFBPageNo");
            this.radioButtonFBPageNo.Name = "radioButtonFBPageNo";
            this.radioButtonFBPageNo.TabStop = true;
            this.radioButtonFBPageNo.UseVisualStyleBackColor = true;
            this.radioButtonFBPageNo.CheckedChanged += new System.EventHandler(this.radioButtonFBPageNo_CheckedChanged);
            // 
            // radioButtonFBPageYes
            // 
            resources.ApplyResources(this.radioButtonFBPageYes, "radioButtonFBPageYes");
            this.radioButtonFBPageYes.Name = "radioButtonFBPageYes";
            this.radioButtonFBPageYes.TabStop = true;
            this.radioButtonFBPageYes.UseVisualStyleBackColor = true;
            this.radioButtonFBPageYes.CheckedChanged += new System.EventHandler(this.radioButtonFBPageYes_CheckedChanged);
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonSaveFBPageID
            // 
            resources.ApplyResources(this.buttonSaveFBPageID, "buttonSaveFBPageID");
            this.buttonSaveFBPageID.Name = "buttonSaveFBPageID";
            this.buttonSaveFBPageID.UseVisualStyleBackColor = true;
            this.buttonSaveFBPageID.Click += new System.EventHandler(this.buttonSaveFBPageID_Click);
            // 
            // Options
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tabControlGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.tabControlGeneral.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSocialMedia.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGeneral;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageSocialMedia;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxUILangSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxUILayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxFBPageID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonFBPageNo;
        private System.Windows.Forms.RadioButton radioButtonFBPageYes;
        private System.Windows.Forms.Button buttonSaveFBPageID;

    }
}
