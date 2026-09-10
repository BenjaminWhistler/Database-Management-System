namespace System_Support_Project.Account
{
    partial class AccountMainForm
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
            this.addARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumni_Association_DocumentationDataSet = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.accountTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.filtersAppliedLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addARecordToolStripMenuItem,
            this.editARecordToolStripMenuItem,
            this.viewARecordToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.returnToMainMenuToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
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
            // accountDataGridView
            // 
            this.accountDataGridView.AllowUserToAddRows = false;
            this.accountDataGridView.AllowUserToDeleteRows = false;
            this.accountDataGridView.AutoGenerateColumns = false;
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Active});
            this.accountDataGridView.DataSource = this.accountBindingSource;
            this.accountDataGridView.Location = new System.Drawing.Point(35, 36);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.ReadOnly = true;
            this.accountDataGridView.Size = new System.Drawing.Size(610, 338);
            this.accountDataGridView.TabIndex = 1;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // alumni_Association_DocumentationDataSet
            // 
            this.alumni_Association_DocumentationDataSet.DataSetName = "Alumni_Association_DocumentationDataSet";
            this.alumni_Association_DocumentationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = this.accountTableAdapter;
            this.tableAdapterManager.AlumniTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DonationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // filtersAppliedLabel
            // 
            this.filtersAppliedLabel.AutoSize = true;
            this.filtersAppliedLabel.Location = new System.Drawing.Point(62, 384);
            this.filtersAppliedLabel.Name = "filtersAppliedLabel";
            this.filtersAppliedLabel.Size = new System.Drawing.Size(0, 13);
            this.filtersAppliedLabel.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Record_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Record_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Account_Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Account_Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Account_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Account_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Parent_Number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Parent_Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active?";
            this.Active.HeaderText = "Active?";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Width = 50;
            // 
            // AccountMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 406);
            this.Controls.Add(this.filtersAppliedLabel);
            this.Controls.Add(this.accountDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AccountMainForm";
            this.Text = "Account Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountMainForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.DataGridView accountDataGridView;
        private System.Windows.Forms.Label filtersAppliedLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
    }
}