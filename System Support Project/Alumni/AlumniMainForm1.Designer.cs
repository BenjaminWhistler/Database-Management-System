namespace System_Support_Project.Alumni
{
    partial class AlumniMainForm1
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
            this.alumni_Association_DocumentationDataSet = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.alumniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumniTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AlumniTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.alumniDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersAppliedLabel1 = new System.Windows.Forms.Label();
            this.donationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter();
            this.educationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.EducationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alumni_Association_DocumentationDataSet
            // 
            this.alumni_Association_DocumentationDataSet.DataSetName = "Alumni_Association_DocumentationDataSet";
            this.alumni_Association_DocumentationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumniBindingSource
            // 
            this.alumniBindingSource.DataMember = "Alumni";
            this.alumniBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // alumniTableAdapter
            // 
            this.alumniTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AlumniTableAdapter = this.alumniTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DonationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alumniDataGridView
            // 
            this.alumniDataGridView.AllowUserToAddRows = false;
            this.alumniDataGridView.AllowUserToDeleteRows = false;
            this.alumniDataGridView.AutoGenerateColumns = false;
            this.alumniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumniDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn11});
            this.alumniDataGridView.DataSource = this.alumniBindingSource;
            this.alumniDataGridView.Location = new System.Drawing.Point(23, 41);
            this.alumniDataGridView.Name = "alumniDataGridView";
            this.alumniDataGridView.ReadOnly = true;
            this.alumniDataGridView.Size = new System.Drawing.Size(1302, 365);
            this.alumniDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Alumni_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Alumni_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn4.HeaderText = "Title";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Mobile_Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mobile_Phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Home_Phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Home_Phone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn5.HeaderText = "Street";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Zip_Code";
            this.dataGridViewTextBoxColumn10.HeaderText = "Zip_Code";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 65;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn9.HeaderText = "City";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn12.HeaderText = "State";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 42;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Active?";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Active?";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn11.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addARecordToolStripMenuItem,
            this.editARecordToolStripMenuItem,
            this.viewARecordToolStripMenuItem,
            this.deleteARecordToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.returnToMainMenuToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1353, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addARecordToolStripMenuItem
            // 
            this.addARecordToolStripMenuItem.Name = "addARecordToolStripMenuItem";
            this.addARecordToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.addARecordToolStripMenuItem.Text = "Add a record";
            this.addARecordToolStripMenuItem.Click += new System.EventHandler(this.addARecordToolStripMenuItem_Click);
            // 
            // editARecordToolStripMenuItem
            // 
            this.editARecordToolStripMenuItem.Name = "editARecordToolStripMenuItem";
            this.editARecordToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.editARecordToolStripMenuItem.Text = "Edit a record";
            this.editARecordToolStripMenuItem.Click += new System.EventHandler(this.editARecordToolStripMenuItem_Click);
            // 
            // viewARecordToolStripMenuItem
            // 
            this.viewARecordToolStripMenuItem.Name = "viewARecordToolStripMenuItem";
            this.viewARecordToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.viewARecordToolStripMenuItem.Text = "View a record";
            this.viewARecordToolStripMenuItem.Click += new System.EventHandler(this.viewARecordToolStripMenuItem_Click);
            // 
            // deleteARecordToolStripMenuItem
            // 
            this.deleteARecordToolStripMenuItem.Name = "deleteARecordToolStripMenuItem";
            this.deleteARecordToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.deleteARecordToolStripMenuItem.Text = "Delete a record";
            this.deleteARecordToolStripMenuItem.Click += new System.EventHandler(this.deleteARecordToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            this.filtersToolStripMenuItem.Click += new System.EventHandler(this.filtersToolStripMenuItem_Click);
            // 
            // returnToMainMenuToolStripMenuItem
            // 
            this.returnToMainMenuToolStripMenuItem.Name = "returnToMainMenuToolStripMenuItem";
            this.returnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.returnToMainMenuToolStripMenuItem.Text = "Return to Main Menu";
            this.returnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMainMenuToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // filtersAppliedLabel1
            // 
            this.filtersAppliedLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filtersAppliedLabel1.AutoSize = true;
            this.filtersAppliedLabel1.Location = new System.Drawing.Point(91, 414);
            this.filtersAppliedLabel1.Name = "filtersAppliedLabel1";
            this.filtersAppliedLabel1.Size = new System.Drawing.Size(0, 13);
            this.filtersAppliedLabel1.TabIndex = 3;
            // 
            // donationBindingSource
            // 
            this.donationBindingSource.DataMember = "AlumniDonation";
            this.donationBindingSource.DataSource = this.alumniBindingSource;
            // 
            // donationTableAdapter
            // 
            this.donationTableAdapter.ClearBeforeFill = true;
            // 
            // educationBindingSource
            // 
            this.educationBindingSource.DataMember = "AlumniEducation";
            this.educationBindingSource.DataSource = this.alumniBindingSource;
            // 
            // educationTableAdapter
            // 
            this.educationTableAdapter.ClearBeforeFill = true;
            // 
            // AlumniMainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 435);
            this.Controls.Add(this.filtersAppliedLabel1);
            this.Controls.Add(this.alumniDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AlumniMainForm1";
            this.Text = "Alumni Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlumniMainForm_FormClosing);
            this.Load += new System.EventHandler(this.AlumniMainForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet;
        private System.Windows.Forms.BindingSource alumniBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.AlumniTableAdapter alumniTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView alumniDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Label filtersAppliedLabel1;
        private System.Windows.Forms.BindingSource donationBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter donationTableAdapter;
        private System.Windows.Forms.BindingSource educationBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.EducationTableAdapter educationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}