namespace UrduWordProcessor
{
    partial class FindBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBox));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTermsTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findSearchBtn = new System.Windows.Forms.Button();
            this.findNextSearchBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findNextSearchBtn);
            this.groupBox1.Controls.Add(this.findSearchBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchTermsTxt);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // searchTermsTxt
            // 
            resources.ApplyResources(this.searchTermsTxt, "searchTermsTxt");
            this.searchTermsTxt.Name = "searchTermsTxt";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // findSearchBtn
            // 
            resources.ApplyResources(this.findSearchBtn, "findSearchBtn");
            this.findSearchBtn.Name = "findSearchBtn";
            this.findSearchBtn.UseVisualStyleBackColor = true;
            // 
            // findNextSearchBtn
            // 
            resources.ApplyResources(this.findNextSearchBtn, "findNextSearchBtn");
            this.findNextSearchBtn.Name = "findNextSearchBtn";
            this.findNextSearchBtn.UseVisualStyleBackColor = true;
            // 
            // FindBox
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindBox";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button findNextSearchBtn;
        public System.Windows.Forms.Button findSearchBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox searchTermsTxt;
    }
}
