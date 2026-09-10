namespace System_Support_Project.Account
{
    partial class AccountEditForm
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
            System.Windows.Forms.Label account_NumberLabel;
            System.Windows.Forms.Label account_NameLabel;
            System.Windows.Forms.Label parent_NumberLabel;
            System.Windows.Forms.Label active_Label;
            System.Windows.Forms.Label record_IDLabel;
            this.alumni_Association_DocumentationDataSet = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.account_NumberTextBox = new System.Windows.Forms.TextBox();
            this.account_NameTextBox = new System.Windows.Forms.TextBox();
            this.parent_NumberTextBox = new System.Windows.Forms.TextBox();
            this.active_CheckBox = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.record_IDTextBox = new System.Windows.Forms.TextBox();
            account_NumberLabel = new System.Windows.Forms.Label();
            account_NameLabel = new System.Windows.Forms.Label();
            parent_NumberLabel = new System.Windows.Forms.Label();
            active_Label = new System.Windows.Forms.Label();
            record_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // account_NumberLabel
            // 
            account_NumberLabel.AutoSize = true;
            account_NumberLabel.Location = new System.Drawing.Point(12, 35);
            account_NumberLabel.Name = "account_NumberLabel";
            account_NumberLabel.Size = new System.Drawing.Size(90, 13);
            account_NumberLabel.TabIndex = 3;
            account_NumberLabel.Text = "Account Number:";
            // 
            // account_NameLabel
            // 
            account_NameLabel.AutoSize = true;
            account_NameLabel.Location = new System.Drawing.Point(12, 61);
            account_NameLabel.Name = "account_NameLabel";
            account_NameLabel.Size = new System.Drawing.Size(81, 13);
            account_NameLabel.TabIndex = 5;
            account_NameLabel.Text = "Account Name:";
            // 
            // parent_NumberLabel
            // 
            parent_NumberLabel.AutoSize = true;
            parent_NumberLabel.Location = new System.Drawing.Point(12, 87);
            parent_NumberLabel.Name = "parent_NumberLabel";
            parent_NumberLabel.Size = new System.Drawing.Size(81, 13);
            parent_NumberLabel.TabIndex = 7;
            parent_NumberLabel.Text = "Parent Number:";
            // 
            // active_Label
            // 
            active_Label.AutoSize = true;
            active_Label.Location = new System.Drawing.Point(12, 115);
            active_Label.Name = "active_Label";
            active_Label.Size = new System.Drawing.Size(43, 13);
            active_Label.TabIndex = 9;
            active_Label.Text = "Active?";
            // 
            // record_IDLabel
            // 
            record_IDLabel.AutoSize = true;
            record_IDLabel.Location = new System.Drawing.Point(12, 9);
            record_IDLabel.Name = "record_IDLabel";
            record_IDLabel.Size = new System.Drawing.Size(59, 13);
            record_IDLabel.TabIndex = 12;
            record_IDLabel.Text = "Record ID:";
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
            // account_NumberTextBox
            // 
            this.account_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Account_Number", true));
            this.account_NumberTextBox.Location = new System.Drawing.Point(108, 32);
            this.account_NumberTextBox.Name = "account_NumberTextBox";
            this.account_NumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.account_NumberTextBox.TabIndex = 4;
            // 
            // account_NameTextBox
            // 
            this.account_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Account_Name", true));
            this.account_NameTextBox.Location = new System.Drawing.Point(108, 58);
            this.account_NameTextBox.Name = "account_NameTextBox";
            this.account_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.account_NameTextBox.TabIndex = 6;
            // 
            // parent_NumberTextBox
            // 
            this.parent_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Parent_Number", true));
            this.parent_NumberTextBox.Location = new System.Drawing.Point(108, 84);
            this.parent_NumberTextBox.Name = "parent_NumberTextBox";
            this.parent_NumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.parent_NumberTextBox.TabIndex = 8;
            // 
            // active_CheckBox
            // 
            this.active_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accountBindingSource, "Active?", true));
            this.active_CheckBox.Location = new System.Drawing.Point(108, 110);
            this.active_CheckBox.Name = "active_CheckBox";
            this.active_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.active_CheckBox.TabIndex = 10;
            this.active_CheckBox.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(338, 35);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(102, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Cancel and Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(338, 64);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save and Finish";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // record_IDTextBox
            // 
            this.record_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Record_ID", true));
            this.record_IDTextBox.Location = new System.Drawing.Point(108, 6);
            this.record_IDTextBox.Name = "record_IDTextBox";
            this.record_IDTextBox.ReadOnly = true;
            this.record_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.record_IDTextBox.TabIndex = 13;
            // 
            // AccountEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 142);
            this.Controls.Add(record_IDLabel);
            this.Controls.Add(this.record_IDTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(account_NumberLabel);
            this.Controls.Add(this.account_NumberTextBox);
            this.Controls.Add(account_NameLabel);
            this.Controls.Add(this.account_NameTextBox);
            this.Controls.Add(parent_NumberLabel);
            this.Controls.Add(this.parent_NumberTextBox);
            this.Controls.Add(active_Label);
            this.Controls.Add(this.active_CheckBox);
            this.Name = "AccountEditForm";
            this.Text = "Edit an Account record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountEditForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox account_NumberTextBox;
        private System.Windows.Forms.TextBox account_NameTextBox;
        private System.Windows.Forms.TextBox parent_NumberTextBox;
        private System.Windows.Forms.CheckBox active_CheckBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox record_IDTextBox;
    }
}