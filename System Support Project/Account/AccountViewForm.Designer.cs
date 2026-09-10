namespace System_Support_Project.Account
{
    partial class AccountViewForm
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
            System.Windows.Forms.Label record_IDLabel;
            System.Windows.Forms.Label account_NumberLabel;
            System.Windows.Forms.Label account_NameLabel;
            System.Windows.Forms.Label parent_NumberLabel;
            System.Windows.Forms.Label active_Label;
            this.alumni_Association_DocumentationDataSet = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.record_IDTextBox = new System.Windows.Forms.TextBox();
            this.account_NumberTextBox = new System.Windows.Forms.TextBox();
            this.account_NameTextBox = new System.Windows.Forms.TextBox();
            this.parent_NumberTextBox = new System.Windows.Forms.TextBox();
            this.active_CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.donationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter();
            this.donationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            record_IDLabel = new System.Windows.Forms.Label();
            account_NumberLabel = new System.Windows.Forms.Label();
            account_NameLabel = new System.Windows.Forms.Label();
            parent_NumberLabel = new System.Windows.Forms.Label();
            active_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // record_IDLabel
            // 
            record_IDLabel.AutoSize = true;
            record_IDLabel.Location = new System.Drawing.Point(12, 32);
            record_IDLabel.Name = "record_IDLabel";
            record_IDLabel.Size = new System.Drawing.Size(59, 13);
            record_IDLabel.TabIndex = 1;
            record_IDLabel.Text = "Record ID:";
            // 
            // account_NumberLabel
            // 
            account_NumberLabel.AutoSize = true;
            account_NumberLabel.Location = new System.Drawing.Point(12, 58);
            account_NumberLabel.Name = "account_NumberLabel";
            account_NumberLabel.Size = new System.Drawing.Size(90, 13);
            account_NumberLabel.TabIndex = 3;
            account_NumberLabel.Text = "Account Number:";
            // 
            // account_NameLabel
            // 
            account_NameLabel.AutoSize = true;
            account_NameLabel.Location = new System.Drawing.Point(12, 84);
            account_NameLabel.Name = "account_NameLabel";
            account_NameLabel.Size = new System.Drawing.Size(81, 13);
            account_NameLabel.TabIndex = 5;
            account_NameLabel.Text = "Account Name:";
            // 
            // parent_NumberLabel
            // 
            parent_NumberLabel.AutoSize = true;
            parent_NumberLabel.Location = new System.Drawing.Point(12, 110);
            parent_NumberLabel.Name = "parent_NumberLabel";
            parent_NumberLabel.Size = new System.Drawing.Size(81, 13);
            parent_NumberLabel.TabIndex = 7;
            parent_NumberLabel.Text = "Parent Number:";
            // 
            // active_Label
            // 
            active_Label.AutoSize = true;
            active_Label.Location = new System.Drawing.Point(12, 138);
            active_Label.Name = "active_Label";
            active_Label.Size = new System.Drawing.Size(43, 13);
            active_Label.TabIndex = 9;
            active_Label.Text = "Active?";
            // 
            // alumni_Association_DocumentationDataSet
            // 
            this.alumni_Association_DocumentationDataSet.DataSetName = "Alumni_Association_DocumentationDataSet";
            this.alumni_Association_DocumentationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
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
            // record_IDTextBox
            // 
            this.record_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Record_ID", true));
            this.record_IDTextBox.Location = new System.Drawing.Point(108, 29);
            this.record_IDTextBox.Name = "record_IDTextBox";
            this.record_IDTextBox.ReadOnly = true;
            this.record_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.record_IDTextBox.TabIndex = 2;
            // 
            // account_NumberTextBox
            // 
            this.account_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Account_Number", true));
            this.account_NumberTextBox.Location = new System.Drawing.Point(108, 55);
            this.account_NumberTextBox.Name = "account_NumberTextBox";
            this.account_NumberTextBox.ReadOnly = true;
            this.account_NumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.account_NumberTextBox.TabIndex = 4;
            // 
            // account_NameTextBox
            // 
            this.account_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Account_Name", true));
            this.account_NameTextBox.Location = new System.Drawing.Point(108, 81);
            this.account_NameTextBox.Name = "account_NameTextBox";
            this.account_NameTextBox.ReadOnly = true;
            this.account_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.account_NameTextBox.TabIndex = 6;
            // 
            // parent_NumberTextBox
            // 
            this.parent_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Parent_Number", true));
            this.parent_NumberTextBox.Location = new System.Drawing.Point(108, 107);
            this.parent_NumberTextBox.Name = "parent_NumberTextBox";
            this.parent_NumberTextBox.ReadOnly = true;
            this.parent_NumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.parent_NumberTextBox.TabIndex = 8;
            // 
            // active_CheckBox
            // 
            this.active_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accountBindingSource, "Active?", true));
            this.active_CheckBox.Location = new System.Drawing.Point(108, 133);
            this.active_CheckBox.Name = "active_CheckBox";
            this.active_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.active_CheckBox.TabIndex = 10;
            this.active_CheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Donation Records tied to this Account";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(108, 205);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // donationBindingSource
            // 
            this.donationBindingSource.DataMember = "AccountDonation";
            this.donationBindingSource.DataSource = this.accountBindingSource;
            // 
            // donationTableAdapter
            // 
            this.donationTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.donationDataGridView.DataSource = this.donationBindingSource;
            this.donationDataGridView.Location = new System.Drawing.Point(329, 32);
            this.donationDataGridView.Name = "donationDataGridView";
            this.donationDataGridView.ReadOnly = true;
            this.donationDataGridView.Size = new System.Drawing.Size(860, 235);
            this.donationDataGridView.TabIndex = 12;
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
            // AccountViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 288);
            this.Controls.Add(this.donationDataGridView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(record_IDLabel);
            this.Controls.Add(this.record_IDTextBox);
            this.Controls.Add(account_NumberLabel);
            this.Controls.Add(this.account_NumberTextBox);
            this.Controls.Add(account_NameLabel);
            this.Controls.Add(this.account_NameTextBox);
            this.Controls.Add(parent_NumberLabel);
            this.Controls.Add(this.parent_NumberTextBox);
            this.Controls.Add(active_Label);
            this.Controls.Add(this.active_CheckBox);
            this.Name = "AccountViewForm";
            this.Text = "View an Account record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlumniViewForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox record_IDTextBox;
        private System.Windows.Forms.TextBox account_NumberTextBox;
        private System.Windows.Forms.TextBox account_NameTextBox;
        private System.Windows.Forms.TextBox parent_NumberTextBox;
        private System.Windows.Forms.CheckBox active_CheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.BindingSource donationBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter donationTableAdapter;
        private System.Windows.Forms.DataGridView donationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}