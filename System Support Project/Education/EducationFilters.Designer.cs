namespace System_Support_Project.Education
{
    partial class EducationFilters
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
            System.Windows.Forms.Label education_IDLabel;
            System.Windows.Forms.Label alumni_IDLabel;
            System.Windows.Forms.Label degreeLabel;
            System.Windows.Forms.Label institutionLabel;
            System.Windows.Forms.Label graduation_DateLabel;
            this.alumni_Association_DocumentationDataSet = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.educationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.EducationTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.education_IDTextBox = new System.Windows.Forms.TextBox();
            this.alumni_IDTextBox = new System.Windows.Forms.TextBox();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.institutionTextBox = new System.Windows.Forms.TextBox();
            this.graduation_DateTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            education_IDLabel = new System.Windows.Forms.Label();
            alumni_IDLabel = new System.Windows.Forms.Label();
            degreeLabel = new System.Windows.Forms.Label();
            institutionLabel = new System.Windows.Forms.Label();
            graduation_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // education_IDLabel
            // 
            education_IDLabel.AutoSize = true;
            education_IDLabel.Location = new System.Drawing.Point(12, 9);
            education_IDLabel.Name = "education_IDLabel";
            education_IDLabel.Size = new System.Drawing.Size(72, 13);
            education_IDLabel.TabIndex = 1;
            education_IDLabel.Text = "Education ID:";
            // 
            // alumni_IDLabel
            // 
            alumni_IDLabel.AutoSize = true;
            alumni_IDLabel.Location = new System.Drawing.Point(12, 35);
            alumni_IDLabel.Name = "alumni_IDLabel";
            alumni_IDLabel.Size = new System.Drawing.Size(55, 13);
            alumni_IDLabel.TabIndex = 3;
            alumni_IDLabel.Text = "Alumni ID:";
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.Location = new System.Drawing.Point(12, 61);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new System.Drawing.Size(45, 13);
            degreeLabel.TabIndex = 5;
            degreeLabel.Text = "Degree:";
            // 
            // institutionLabel
            // 
            institutionLabel.AutoSize = true;
            institutionLabel.Location = new System.Drawing.Point(12, 87);
            institutionLabel.Name = "institutionLabel";
            institutionLabel.Size = new System.Drawing.Size(55, 13);
            institutionLabel.TabIndex = 7;
            institutionLabel.Text = "Institution:";
            // 
            // graduation_DateLabel
            // 
            graduation_DateLabel.AutoSize = true;
            graduation_DateLabel.Location = new System.Drawing.Point(12, 113);
            graduation_DateLabel.Name = "graduation_DateLabel";
            graduation_DateLabel.Size = new System.Drawing.Size(87, 13);
            graduation_DateLabel.TabIndex = 9;
            graduation_DateLabel.Text = "Graduation Year:";
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
            // education_IDTextBox
            // 
            this.education_IDTextBox.CausesValidation = false;
            this.education_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Education_ID", true));
            this.education_IDTextBox.Location = new System.Drawing.Point(106, 6);
            this.education_IDTextBox.Name = "education_IDTextBox";
            this.education_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.education_IDTextBox.TabIndex = 2;
            this.education_IDTextBox.TextChanged += new System.EventHandler(this.education_IDTextBox_TextChanged);
            // 
            // alumni_IDTextBox
            // 
            this.alumni_IDTextBox.CausesValidation = false;
            this.alumni_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Alumni_ID", true));
            this.alumni_IDTextBox.Location = new System.Drawing.Point(106, 32);
            this.alumni_IDTextBox.Name = "alumni_IDTextBox";
            this.alumni_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.alumni_IDTextBox.TabIndex = 4;
            this.alumni_IDTextBox.TextChanged += new System.EventHandler(this.alumni_IDTextBox_TextChanged);
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.CausesValidation = false;
            this.degreeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Degree", true));
            this.degreeTextBox.Location = new System.Drawing.Point(106, 58);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.Size = new System.Drawing.Size(165, 20);
            this.degreeTextBox.TabIndex = 6;
            this.degreeTextBox.TextChanged += new System.EventHandler(this.degreeTextBox_TextChanged);
            // 
            // institutionTextBox
            // 
            this.institutionTextBox.CausesValidation = false;
            this.institutionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Institution", true));
            this.institutionTextBox.Location = new System.Drawing.Point(106, 84);
            this.institutionTextBox.Name = "institutionTextBox";
            this.institutionTextBox.Size = new System.Drawing.Size(165, 20);
            this.institutionTextBox.TabIndex = 8;
            this.institutionTextBox.TextChanged += new System.EventHandler(this.institutionTextBox_TextChanged);
            // 
            // graduation_DateTextBox
            // 
            this.graduation_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Graduation_Date", true));
            this.graduation_DateTextBox.Location = new System.Drawing.Point(106, 110);
            this.graduation_DateTextBox.Name = "graduation_DateTextBox";
            this.graduation_DateTextBox.Size = new System.Drawing.Size(40, 20);
            this.graduation_DateTextBox.TabIndex = 10;
            this.graduation_DateTextBox.TextChanged += new System.EventHandler(this.graduation_DateTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(289, 25);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save Filters";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(289, 54);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear Filters";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(289, 108);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EducationFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 141);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(education_IDLabel);
            this.Controls.Add(this.education_IDTextBox);
            this.Controls.Add(alumni_IDLabel);
            this.Controls.Add(this.alumni_IDTextBox);
            this.Controls.Add(degreeLabel);
            this.Controls.Add(this.degreeTextBox);
            this.Controls.Add(institutionLabel);
            this.Controls.Add(this.institutionTextBox);
            this.Controls.Add(graduation_DateLabel);
            this.Controls.Add(this.graduation_DateTextBox);
            this.Name = "EducationFilters";
            this.Text = "Filter Education records";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EducationFilters_FormClosing);
            this.Load += new System.EventHandler(this.EducationFilters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet;
        private System.Windows.Forms.BindingSource educationBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.EducationTableAdapter educationTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox education_IDTextBox;
        private System.Windows.Forms.TextBox alumni_IDTextBox;
        private System.Windows.Forms.TextBox degreeTextBox;
        private System.Windows.Forms.TextBox institutionTextBox;
        private System.Windows.Forms.TextBox graduation_DateTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
    }
}