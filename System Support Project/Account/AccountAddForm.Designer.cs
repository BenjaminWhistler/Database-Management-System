namespace System_Support_Project.Account
{
    partial class AccountAddForm
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
            this.alumni_Association_DocumentationDataSet = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.account_NumberTextBox = new System.Windows.Forms.TextBox();
            this.account_NameTextBox = new System.Windows.Forms.TextBox();
            this.parent_NumberTextBox = new System.Windows.Forms.TextBox();
            this.active_CheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            account_NumberLabel = new System.Windows.Forms.Label();
            account_NameLabel = new System.Windows.Forms.Label();
            parent_NumberLabel = new System.Windows.Forms.Label();
            active_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // account_NumberLabel
            // 
            account_NumberLabel.AutoSize = true;
            account_NumberLabel.Location = new System.Drawing.Point(12, 10);
            account_NumberLabel.Name = "account_NumberLabel";
            account_NumberLabel.Size = new System.Drawing.Size(90, 13);
            account_NumberLabel.TabIndex = 3;
            account_NumberLabel.Text = "Account Number:";
            // 
            // account_NameLabel
            // 
            account_NameLabel.AutoSize = true;
            account_NameLabel.Location = new System.Drawing.Point(12, 36);
            account_NameLabel.Name = "account_NameLabel";
            account_NameLabel.Size = new System.Drawing.Size(81, 13);
            account_NameLabel.TabIndex = 5;
            account_NameLabel.Text = "Account Name:";
            // 
            // parent_NumberLabel
            // 
            parent_NumberLabel.AutoSize = true;
            parent_NumberLabel.Location = new System.Drawing.Point(12, 62);
            parent_NumberLabel.Name = "parent_NumberLabel";
            parent_NumberLabel.Size = new System.Drawing.Size(81, 13);
            parent_NumberLabel.TabIndex = 7;
            parent_NumberLabel.Text = "Parent Number:";
            // 
            // active_Label
            // 
            active_Label.AutoSize = true;
            active_Label.Location = new System.Drawing.Point(12, 90);
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
            // account_NumberTextBox
            // 
            this.account_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Account_Number", true));
            this.account_NumberTextBox.Location = new System.Drawing.Point(108, 7);
            this.account_NumberTextBox.Name = "account_NumberTextBox";
            this.account_NumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.account_NumberTextBox.TabIndex = 4;
            this.account_NumberTextBox.TextChanged += new System.EventHandler(this.account_NumberTextBox_TextChanged);
            // 
            // account_NameTextBox
            // 
            this.account_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Account_Name", true));
            this.account_NameTextBox.Location = new System.Drawing.Point(108, 33);
            this.account_NameTextBox.Name = "account_NameTextBox";
            this.account_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.account_NameTextBox.TabIndex = 6;
            // 
            // parent_NumberTextBox
            // 
            this.parent_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Parent_Number", true));
            this.parent_NumberTextBox.Location = new System.Drawing.Point(108, 59);
            this.parent_NumberTextBox.Name = "parent_NumberTextBox";
            this.parent_NumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.parent_NumberTextBox.TabIndex = 8;
            // 
            // active_CheckBox
            // 
            this.active_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accountBindingSource, "Active?", true));
            this.active_CheckBox.Location = new System.Drawing.Point(108, 85);
            this.active_CheckBox.Name = "active_CheckBox";
            this.active_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.active_CheckBox.TabIndex = 10;
            this.active_CheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(336, 26);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save and Continue";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(361, 55);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 12;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // AccountAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 115);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(account_NumberLabel);
            this.Controls.Add(this.account_NumberTextBox);
            this.Controls.Add(account_NameLabel);
            this.Controls.Add(this.account_NameTextBox);
            this.Controls.Add(parent_NumberLabel);
            this.Controls.Add(this.parent_NumberTextBox);
            this.Controls.Add(active_Label);
            this.Controls.Add(this.active_CheckBox);
            this.Name = "AccountAddForm";
            this.Text = "Add Account records";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountAddForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountAddForm_Load);
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
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button finishButton;
    }
}