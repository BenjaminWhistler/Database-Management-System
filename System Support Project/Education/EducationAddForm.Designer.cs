namespace System_Support_Project.Education
{
    partial class EducationAddForm
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
            System.Windows.Forms.Label degreeLabel;
            System.Windows.Forms.Label institutionLabel;
            System.Windows.Forms.Label graduation_DateLabel;
            this.alumni_Association_DocumentationDataSet = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.educationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.EducationTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.alumni_IDTextBox = new System.Windows.Forms.TextBox();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.institutionTextBox = new System.Windows.Forms.TextBox();
            this.graduation_DateTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            alumni_IDLabel = new System.Windows.Forms.Label();
            degreeLabel = new System.Windows.Forms.Label();
            institutionLabel = new System.Windows.Forms.Label();
            graduation_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).BeginInit();
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
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.Location = new System.Drawing.Point(12, 35);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new System.Drawing.Size(45, 13);
            degreeLabel.TabIndex = 5;
            degreeLabel.Text = "Degree:";
            // 
            // institutionLabel
            // 
            institutionLabel.AutoSize = true;
            institutionLabel.Location = new System.Drawing.Point(12, 61);
            institutionLabel.Name = "institutionLabel";
            institutionLabel.Size = new System.Drawing.Size(55, 13);
            institutionLabel.TabIndex = 7;
            institutionLabel.Text = "Institution:";
            // 
            // graduation_DateLabel
            // 
            graduation_DateLabel.AutoSize = true;
            graduation_DateLabel.Location = new System.Drawing.Point(12, 87);
            graduation_DateLabel.Name = "graduation_DateLabel";
            graduation_DateLabel.Size = new System.Drawing.Size(88, 13);
            graduation_DateLabel.TabIndex = 9;
            graduation_DateLabel.Text = "Graduation Date:";
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
            // alumni_IDTextBox
            // 
            this.alumni_IDTextBox.CausesValidation = false;
            this.alumni_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Alumni_ID", true));
            this.alumni_IDTextBox.Location = new System.Drawing.Point(106, 6);
            this.alumni_IDTextBox.Name = "alumni_IDTextBox";
            this.alumni_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.alumni_IDTextBox.TabIndex = 4;
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.CausesValidation = false;
            this.degreeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Degree", true));
            this.degreeTextBox.Location = new System.Drawing.Point(106, 32);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.Size = new System.Drawing.Size(154, 20);
            this.degreeTextBox.TabIndex = 6;
            // 
            // institutionTextBox
            // 
            this.institutionTextBox.CausesValidation = false;
            this.institutionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Institution", true));
            this.institutionTextBox.Location = new System.Drawing.Point(106, 58);
            this.institutionTextBox.Name = "institutionTextBox";
            this.institutionTextBox.Size = new System.Drawing.Size(154, 20);
            this.institutionTextBox.TabIndex = 8;
            // 
            // graduation_DateTextBox
            // 
            this.graduation_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Graduation_Date", true));
            this.graduation_DateTextBox.Location = new System.Drawing.Point(106, 84);
            this.graduation_DateTextBox.Name = "graduation_DateTextBox";
            this.graduation_DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.graduation_DateTextBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(280, 30);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save and Continue";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(299, 59);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 12;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // EducationAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 123);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(alumni_IDLabel);
            this.Controls.Add(this.alumni_IDTextBox);
            this.Controls.Add(degreeLabel);
            this.Controls.Add(this.degreeTextBox);
            this.Controls.Add(institutionLabel);
            this.Controls.Add(this.institutionTextBox);
            this.Controls.Add(graduation_DateLabel);
            this.Controls.Add(this.graduation_DateTextBox);
            this.Name = "EducationAddForm";
            this.Text = "Add Education records";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EducationAddForm_FormClosing);
            this.Load += new System.EventHandler(this.EducationAddForm_Load);
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
        private System.Windows.Forms.TextBox alumni_IDTextBox;
        private System.Windows.Forms.TextBox degreeTextBox;
        private System.Windows.Forms.TextBox institutionTextBox;
        private System.Windows.Forms.TextBox graduation_DateTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button finishButton;
    }
}