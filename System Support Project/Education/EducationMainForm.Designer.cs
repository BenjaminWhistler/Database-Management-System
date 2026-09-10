namespace System_Support_Project.Education
{
    partial class EducationMainForm
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
            this.educationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.EducationTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.educationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersAppliedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alumni_Association_DocumentationDataSet
            // 
            this.alumni_Association_DocumentationDataSet.DataSetName = "Alumni_Association_DocumentationDataSet";
            this.alumni_Association_DocumentationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // educationBindingSource
            // 
            this.educationBindingSource.DataMember = "Education";
            this.educationBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // educationTableAdapter
            // 
            this.educationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AlumniTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DonationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = this.educationTableAdapter;
            this.tableAdapterManager.UpdateOrder = System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // educationDataGridView
            // 
            this.educationDataGridView.AllowUserToAddRows = false;
            this.educationDataGridView.AllowUserToDeleteRows = false;
            this.educationDataGridView.AutoGenerateColumns = false;
            this.educationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.educationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.educationDataGridView.DataSource = this.educationBindingSource;
            this.educationDataGridView.Location = new System.Drawing.Point(22, 27);
            this.educationDataGridView.Name = "educationDataGridView";
            this.educationDataGridView.ReadOnly = true;
            this.educationDataGridView.Size = new System.Drawing.Size(710, 244);
            this.educationDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Education_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Education_ID";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Degree";
            this.dataGridViewTextBoxColumn3.HeaderText = "Degree";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Institution";
            this.dataGridViewTextBoxColumn4.HeaderText = "Institution";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Graduation_Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Graduation_Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addARecordToolStripMenuItem,
            this.editARecordToolStripMenuItem,
            this.viewARecordToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.returnToMainMenuToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
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
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.deleteToolStripMenuItem.Text = "Delete a record";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
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
            this.filtersAppliedLabel.Location = new System.Drawing.Point(56, 284);
            this.filtersAppliedLabel.Name = "filtersAppliedLabel";
            this.filtersAppliedLabel.Size = new System.Drawing.Size(0, 13);
            this.filtersAppliedLabel.TabIndex = 3;
            // 
            // EducationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 308);
            this.Controls.Add(this.filtersAppliedLabel);
            this.Controls.Add(this.educationDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EducationMainForm";
            this.Text = "Education Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EducationMainForm_FormClosing);
            this.Load += new System.EventHandler(this.EducationMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet;
        private System.Windows.Forms.BindingSource educationBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.EducationTableAdapter educationTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView educationDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Label filtersAppliedLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}