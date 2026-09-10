namespace System_Support_Project
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
            this.mainFormTitle = new System.Windows.Forms.Label();
            this.mainFormSubtitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainFormFileToolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExitToolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormManageRecordsToolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.accountRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountRecordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.donationRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormTitle
            // 
            this.mainFormTitle.AutoSize = true;
            this.mainFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mainFormTitle.Location = new System.Drawing.Point(91, 169);
            this.mainFormTitle.Name = "mainFormTitle";
            this.mainFormTitle.Size = new System.Drawing.Size(597, 55);
            this.mainFormTitle.TabIndex = 1;
            this.mainFormTitle.Text = "NoSuch Alumni Database";
            // 
            // mainFormSubtitle
            // 
            this.mainFormSubtitle.AutoSize = true;
            this.mainFormSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormSubtitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.mainFormSubtitle.Location = new System.Drawing.Point(248, 237);
            this.mainFormSubtitle.Name = "mainFormSubtitle";
            this.mainFormSubtitle.Size = new System.Drawing.Size(278, 24);
            this.mainFormSubtitle.TabIndex = 2;
            this.mainFormSubtitle.Text = "Use the menustrip to get started!";
            this.mainFormSubtitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainFormFileToolstrip,
            this.mainFormManageRecordsToolstrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainFormFileToolstrip
            // 
            this.mainFormFileToolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExitToolstrip,
            this.aboutToolStripMenuItem});
            this.mainFormFileToolstrip.Name = "mainFormFileToolstrip";
            this.mainFormFileToolstrip.Size = new System.Drawing.Size(37, 20);
            this.mainFormFileToolstrip.Text = "File";
            // 
            // fileExitToolstrip
            // 
            this.fileExitToolstrip.Name = "fileExitToolstrip";
            this.fileExitToolstrip.Size = new System.Drawing.Size(107, 22);
            this.fileExitToolstrip.Text = "Exit";
            this.fileExitToolstrip.Click += new System.EventHandler(this.fileExitToolstrip_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainFormManageRecordsToolstrip
            // 
            this.mainFormManageRecordsToolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountRecordsToolStripMenuItem,
            this.accountRecordsToolStripMenuItem1,
            this.donationRecordsToolStripMenuItem,
            this.educationRecordsToolStripMenuItem});
            this.mainFormManageRecordsToolstrip.Name = "mainFormManageRecordsToolstrip";
            this.mainFormManageRecordsToolstrip.Size = new System.Drawing.Size(107, 20);
            this.mainFormManageRecordsToolstrip.Text = "Manage Records";
            // 
            // accountRecordsToolStripMenuItem
            // 
            this.accountRecordsToolStripMenuItem.Name = "accountRecordsToolStripMenuItem";
            this.accountRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accountRecordsToolStripMenuItem.Text = "Alumni Records";
            this.accountRecordsToolStripMenuItem.Click += new System.EventHandler(this.accountRecordsToolStripMenuItem_Click);
            // 
            // accountRecordsToolStripMenuItem1
            // 
            this.accountRecordsToolStripMenuItem1.Name = "accountRecordsToolStripMenuItem1";
            this.accountRecordsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.accountRecordsToolStripMenuItem1.Text = "Account Records";
            this.accountRecordsToolStripMenuItem1.Click += new System.EventHandler(this.accountRecordsToolStripMenuItem1_Click);
            // 
            // donationRecordsToolStripMenuItem
            // 
            this.donationRecordsToolStripMenuItem.Name = "donationRecordsToolStripMenuItem";
            this.donationRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.donationRecordsToolStripMenuItem.Text = "Donation Records";
            this.donationRecordsToolStripMenuItem.Click += new System.EventHandler(this.donationRecordsToolStripMenuItem_Click);
            // 
            // educationRecordsToolStripMenuItem
            // 
            this.educationRecordsToolStripMenuItem.Name = "educationRecordsToolStripMenuItem";
            this.educationRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.educationRecordsToolStripMenuItem.Text = "Education Records";
            this.educationRecordsToolStripMenuItem.Click += new System.EventHandler(this.educationRecordsToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainFormSubtitle);
            this.Controls.Add(this.mainFormTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "NoSuch Alumni Records Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainFormTitle;
        private System.Windows.Forms.Label mainFormSubtitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainFormFileToolstrip;
        private System.Windows.Forms.ToolStripMenuItem mainFormManageRecordsToolstrip;
        private System.Windows.Forms.ToolStripMenuItem fileExitToolstrip;
        private System.Windows.Forms.ToolStripMenuItem accountRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountRecordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem donationRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

