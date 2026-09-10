namespace System_Support_Project.Donation
{
    partial class DonationMainForm
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
            this.donationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.accountTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersAppliedLabel = new System.Windows.Forms.Label();
            this.donationDataGridView = new System.Windows.Forms.DataGridView();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Account_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alumni_Association_DocumentationDataSet
            // 
            this.alumni_Association_DocumentationDataSet.DataSetName = "Alumni_Association_DocumentationDataSet";
            this.alumni_Association_DocumentationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donationBindingSource
            // 
            this.donationBindingSource.DataMember = "Donation";
            this.donationBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // donationTableAdapter
            // 
            this.donationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = this.accountTableAdapter;
            this.tableAdapterManager.AlumniTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DonationTableAdapter = this.donationTableAdapter;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
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
            // filtersAppliedLabel
            // 
            this.filtersAppliedLabel.AutoSize = true;
            this.filtersAppliedLabel.Location = new System.Drawing.Point(70, 338);
            this.filtersAppliedLabel.Name = "filtersAppliedLabel";
            this.filtersAppliedLabel.Size = new System.Drawing.Size(0, 13);
            this.filtersAppliedLabel.TabIndex = 3;
            // 
            // donationDataGridView
            // 
            this.donationDataGridView.AllowUserToAddRows = false;
            this.donationDataGridView.AllowUserToDeleteRows = false;
            this.donationDataGridView.AutoGenerateColumns = false;
            this.donationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Account_Number,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.donationDataGridView.DataSource = this.donationBindingSource;
            this.donationDataGridView.Location = new System.Drawing.Point(12, 27);
            this.donationDataGridView.Name = "donationDataGridView";
            this.donationDataGridView.ReadOnly = true;
            this.donationDataGridView.Size = new System.Drawing.Size(960, 300);
            this.donationDataGridView.TabIndex = 3;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Donation_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Donation_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Alumni_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Alumni_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Account_Number";
            this.dataGridViewTextBoxColumn3.DataSource = this.accountBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Account_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Account_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Account_Number";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // Account_Number
            // 
            this.Account_Number.DataPropertyName = "Account_Number";
            this.Account_Number.HeaderText = "Account_Number";
            this.Account_Number.Name = "Account_Number";
            this.Account_Number.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Donation_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Donation_Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Donation_Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Donation_Amount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn6.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // DonationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 359);
            this.Controls.Add(this.donationDataGridView);
            this.Controls.Add(this.filtersAppliedLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DonationMainForm";
            this.Text = "Donation Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DonationMainForm_FormClosing);
            this.Load += new System.EventHandler(this.DonationMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet;
        private System.Windows.Forms.BindingSource donationBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter donationTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Label filtersAppliedLabel;
        private System.Windows.Forms.DataGridView donationDataGridView;
        private Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}