namespace System_Support_Project.Donation
{
    partial class DonationAddForm
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
            System.Windows.Forms.Label alumni_IDLabel;
            System.Windows.Forms.Label account_NumberLabel;
            System.Windows.Forms.Label donation_DateLabel;
            System.Windows.Forms.Label donation_AmountLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label account_NumberLabel1;
            this.alumni_Association_DocumentationDataSet = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.donationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.accountTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter();
            this.alumni_IDTextBox = new System.Windows.Forms.TextBox();
            this.account_NumberTextBox = new System.Windows.Forms.TextBox();
            this.donation_DateTextBox = new System.Windows.Forms.TextBox();
            this.donation_AmountTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.account_NumberComboBox = new System.Windows.Forms.ComboBox();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            alumni_IDLabel = new System.Windows.Forms.Label();
            account_NumberLabel = new System.Windows.Forms.Label();
            donation_DateLabel = new System.Windows.Forms.Label();
            donation_AmountLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            account_NumberLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alumni_IDLabel
            // 
            alumni_IDLabel.AutoSize = true;
            alumni_IDLabel.Location = new System.Drawing.Point(12, 9);
            alumni_IDLabel.Name = "alumni_IDLabel";
            alumni_IDLabel.Size = new System.Drawing.Size(55, 13);
            alumni_IDLabel.TabIndex = 3;
            alumni_IDLabel.Text = "Alumni ID:";
            // 
            // account_NumberLabel
            // 
            account_NumberLabel.AutoSize = true;
            account_NumberLabel.Location = new System.Drawing.Point(12, 61);
            account_NumberLabel.Name = "account_NumberLabel";
            account_NumberLabel.Size = new System.Drawing.Size(90, 13);
            account_NumberLabel.TabIndex = 5;
            account_NumberLabel.Text = "Account Number:";
            // 
            // donation_DateLabel
            // 
            donation_DateLabel.AutoSize = true;
            donation_DateLabel.Location = new System.Drawing.Point(12, 87);
            donation_DateLabel.Name = "donation_DateLabel";
            donation_DateLabel.Size = new System.Drawing.Size(79, 13);
            donation_DateLabel.TabIndex = 7;
            donation_DateLabel.Text = "Donation Date:";
            // 
            // donation_AmountLabel
            // 
            donation_AmountLabel.AutoSize = true;
            donation_AmountLabel.Location = new System.Drawing.Point(12, 113);
            donation_AmountLabel.Name = "donation_AmountLabel";
            donation_AmountLabel.Size = new System.Drawing.Size(92, 13);
            donation_AmountLabel.TabIndex = 9;
            donation_AmountLabel.Text = "Donation Amount:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(12, 139);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 11;
            notesLabel.Text = "Notes:";
            // 
            // account_NumberLabel1
            // 
            account_NumberLabel1.AutoSize = true;
            account_NumberLabel1.Location = new System.Drawing.Point(12, 34);
            account_NumberLabel1.Name = "account_NumberLabel1";
            account_NumberLabel1.Size = new System.Drawing.Size(81, 13);
            account_NumberLabel1.TabIndex = 14;
            account_NumberLabel1.Text = "Account Name:";
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
            // alumni_IDTextBox
            // 
            this.alumni_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Alumni_ID", true));
            this.alumni_IDTextBox.Location = new System.Drawing.Point(110, 6);
            this.alumni_IDTextBox.Name = "alumni_IDTextBox";
            this.alumni_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.alumni_IDTextBox.TabIndex = 4;
            // 
            // account_NumberTextBox
            // 
            this.account_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Account_Number", true));
            this.account_NumberTextBox.Location = new System.Drawing.Point(110, 58);
            this.account_NumberTextBox.Name = "account_NumberTextBox";
            this.account_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.account_NumberTextBox.TabIndex = 6;
            this.account_NumberTextBox.TextChanged += new System.EventHandler(this.account_NumberTextBox_TextChanged);
            // 
            // donation_DateTextBox
            // 
            this.donation_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Donation_Date", true));
            this.donation_DateTextBox.Location = new System.Drawing.Point(110, 84);
            this.donation_DateTextBox.Name = "donation_DateTextBox";
            this.donation_DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.donation_DateTextBox.TabIndex = 8;
            // 
            // donation_AmountTextBox
            // 
            this.donation_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Donation_Amount", true));
            this.donation_AmountTextBox.Location = new System.Drawing.Point(110, 110);
            this.donation_AmountTextBox.Name = "donation_AmountTextBox";
            this.donation_AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.donation_AmountTextBox.TabIndex = 10;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(110, 136);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(234, 127);
            this.notesTextBox.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(356, 55);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save and Continue";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(379, 84);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 14;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // account_NumberComboBox
            // 
            this.account_NumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Account_Number", true));
            this.account_NumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.donationBindingSource, "Account_Number", true));
            this.account_NumberComboBox.DataSource = this.accountBindingSource;
            this.account_NumberComboBox.DisplayMember = "Account_Name";
            this.account_NumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.account_NumberComboBox.FormattingEnabled = true;
            this.account_NumberComboBox.Location = new System.Drawing.Point(110, 31);
            this.account_NumberComboBox.Name = "account_NumberComboBox";
            this.account_NumberComboBox.Size = new System.Drawing.Size(225, 21);
            this.account_NumberComboBox.TabIndex = 15;
            this.account_NumberComboBox.ValueMember = "Account_Number";
            this.account_NumberComboBox.SelectedIndexChanged += new System.EventHandler(this.account_NumberComboBox_SelectedIndexChanged);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // DonationAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 278);
            this.Controls.Add(account_NumberLabel1);
            this.Controls.Add(this.account_NumberComboBox);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(alumni_IDLabel);
            this.Controls.Add(this.alumni_IDTextBox);
            this.Controls.Add(account_NumberLabel);
            this.Controls.Add(this.account_NumberTextBox);
            this.Controls.Add(donation_DateLabel);
            this.Controls.Add(this.donation_DateTextBox);
            this.Controls.Add(donation_AmountLabel);
            this.Controls.Add(this.donation_AmountTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Name = "DonationAddForm";
            this.Text = "Add a Donation record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DonationAddForm_FormClosing);
            this.Load += new System.EventHandler(this.DonationAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet;
        private System.Windows.Forms.BindingSource donationBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter donationTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox alumni_IDTextBox;
        private System.Windows.Forms.TextBox account_NumberTextBox;
        private System.Windows.Forms.TextBox donation_DateTextBox;
        private System.Windows.Forms.TextBox donation_AmountTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button finishButton;
        private Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.ComboBox account_NumberComboBox;
        private System.Windows.Forms.BindingSource accountBindingSource;
    }
}