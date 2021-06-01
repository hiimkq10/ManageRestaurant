namespace ManageRestaurent1._1
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nHANVIENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyCaLamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerAnnounceSalaryList = new System.Windows.Forms.Timer(this.components);
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nHANVIENToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nHANVIENToolStripMenuItem
            // 
            this.nHANVIENToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInoutToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.manageEmployeeToolStripMenuItem,
            this.luongToolStripMenuItem,
            this.quanLyCaLamToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.nHANVIENToolStripMenuItem.Name = "nHANVIENToolStripMenuItem";
            this.nHANVIENToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.nHANVIENToolStripMenuItem.Text = "EMPLOYEE";
            // 
            // checkInoutToolStripMenuItem
            // 
            this.checkInoutToolStripMenuItem.Name = "checkInoutToolStripMenuItem";
            this.checkInoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checkInoutToolStripMenuItem.Text = "Check in/out";
            this.checkInoutToolStripMenuItem.Click += new System.EventHandler(this.checkInoutToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageEmployeeToolStripMenuItem.Text = "Manage employee ";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // luongToolStripMenuItem
            // 
            this.luongToolStripMenuItem.Name = "luongToolStripMenuItem";
            this.luongToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.luongToolStripMenuItem.Text = "Manage Salary";
            this.luongToolStripMenuItem.Click += new System.EventHandler(this.luongToolStripMenuItem_Click);
            // 
            // quanLyCaLamToolStripMenuItem
            // 
            this.quanLyCaLamToolStripMenuItem.Name = "quanLyCaLamToolStripMenuItem";
            this.quanLyCaLamToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLyCaLamToolStripMenuItem.Text = "Manage Shift";
            this.quanLyCaLamToolStripMenuItem.Click += new System.EventHandler(this.quanLyCaLamToolStripMenuItem_Click);
            // 
            // timerAnnounceSalaryList
            // 
            this.timerAnnounceSalaryList.Tick += new System.EventHandler(this.timerAnnounceSalaryList_Tick);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 678);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nHANVIENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyCaLamToolStripMenuItem;
        private System.Windows.Forms.Timer timerAnnounceSalaryList;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}