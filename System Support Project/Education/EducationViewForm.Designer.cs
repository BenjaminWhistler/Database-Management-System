namespace System_Support_Project.Education
{
    partial class EducationViewForm
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
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label mobile_PhoneLabel;
            System.Windows.Forms.Label home_PhoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zip_CodeLabel;
            System.Windows.Forms.Label active_Label;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label education_IDLabel;
            System.Windows.Forms.Label alumni_IDLabel1;
            System.Windows.Forms.Label degreeLabel;
            System.Windows.Forms.Label institutionLabel;
            System.Windows.Forms.Label graduation_DateLabel;
            this.alumni_Association_DocumentationDataSet = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.alumniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumniTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AlumniTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.educationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.EducationTableAdapter();
            this.alumni_IDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.mobile_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.home_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zip_CodeTextBox = new System.Windows.Forms.TextBox();
            this.active_CheckBox = new System.Windows.Forms.CheckBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.educationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.education_IDTextBox = new System.Windows.Forms.TextBox();
            this.alumni_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.institutionTextBox = new System.Windows.Forms.TextBox();
            this.graduation_DateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            alumni_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            mobile_PhoneLabel = new System.Windows.Forms.Label();
            home_PhoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            zip_CodeLabel = new System.Windows.Forms.Label();
            active_Label = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            education_IDLabel = new System.Windows.Forms.Label();
            alumni_IDLabel1 = new System.Windows.Forms.Label();
            degreeLabel = new System.Windows.Forms.Label();
            institutionLabel = new System.Windows.Forms.Label();
            graduation_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alumni_IDLabel
            // 
            alumni_IDLabel.AutoSize = true;
            alumni_IDLabel.Location = new System.Drawing.Point(308, 28);
            alumni_IDLabel.Name = "alumni_IDLabel";
            alumni_IDLabel.Size = new System.Drawing.Size(55, 13);
            alumni_IDLabel.TabIndex = 1;
            alumni_IDLabel.Text = "Alumni ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(308, 54);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(308, 80);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Last Name:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(308, 106);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(308, 210);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 9;
            streetLabel.Text = "Street:";
            // 
            // mobile_PhoneLabel
            // 
            mobile_PhoneLabel.AutoSize = true;
            mobile_PhoneLabel.Location = new System.Drawing.Point(308, 132);
            mobile_PhoneLabel.Name = "mobile_PhoneLabel";
            mobile_PhoneLabel.Size = new System.Drawing.Size(75, 13);
            mobile_PhoneLabel.TabIndex = 11;
            mobile_PhoneLabel.Text = "Mobile Phone:";
            // 
            // home_PhoneLabel
            // 
            home_PhoneLabel.AutoSize = true;
            home_PhoneLabel.Location = new System.Drawing.Point(308, 158);
            home_PhoneLabel.Name = "home_PhoneLabel";
            home_PhoneLabel.Size = new System.Drawing.Size(72, 13);
            home_PhoneLabel.TabIndex = 13;
            home_PhoneLabel.Text = "Home Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(308, 184);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(308, 262);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 17;
            cityLabel.Text = "City:";
            // 
            // zip_CodeLabel
            // 
            zip_CodeLabel.AutoSize = true;
            zip_CodeLabel.Location = new System.Drawing.Point(308, 236);
            zip_CodeLabel.Name = "zip_CodeLabel";
            zip_CodeLabel.Size = new System.Drawing.Size(53, 13);
            zip_CodeLabel.TabIndex = 19;
            zip_CodeLabel.Text = "Zip Code:";
            // 
            // active_Label
            // 
            active_Label.AutoSize = true;
            active_Label.Location = new System.Drawing.Point(308, 316);
            active_Label.Name = "active_Label";
            active_Label.Size = new System.Drawing.Size(46, 13);
            active_Label.TabIndex = 21;
            active_Label.Text = "Active?:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(308, 344);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 23;
            notesLabel.Text = "Notes:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(308, 288);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 25;
            stateLabel.Text = "State:";
            // 
            // education_IDLabel
            // 
            education_IDLabel.AutoSize = true;
            education_IDLabel.Location = new System.Drawing.Point(12, 28);
            education_IDLabel.Name = "education_IDLabel";
            education_IDLabel.Size = new System.Drawing.Size(72, 13);
            education_IDLabel.TabIndex = 37;
            education_IDLabel.Text = "Education ID:";
            // 
            // alumni_IDLabel1
            // 
            alumni_IDLabel1.AutoSize = true;
            alumni_IDLabel1.Location = new System.Drawing.Point(12, 54);
            alumni_IDLabel1.Name = "alumni_IDLabel1";
            alumni_IDLabel1.Size = new System.Drawing.Size(55, 13);
            alumni_IDLabel1.TabIndex = 39;
            alumni_IDLabel1.Text = "Alumni ID:";
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.Location = new System.Drawing.Point(12, 80);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new System.Drawing.Size(45, 13);
            degreeLabel.TabIndex = 41;
            degreeLabel.Text = "Degree:";
            // 
            // institutionLabel
            // 
            institutionLabel.AutoSize = true;
            institutionLabel.Location = new System.Drawing.Point(12, 106);
            institutionLabel.Name = "institutionLabel";
            institutionLabel.Size = new System.Drawing.Size(55, 13);
            institutionLabel.TabIndex = 43;
            institutionLabel.Text = "Institution:";
            // 
            // graduation_DateLabel
            // 
            graduation_DateLabel.AutoSize = true;
            graduation_DateLabel.Location = new System.Drawing.Point(12, 132);
            graduation_DateLabel.Name = "graduation_DateLabel";
            graduation_DateLabel.Size = new System.Drawing.Size(88, 13);
            graduation_DateLabel.TabIndex = 45;
            graduation_DateLabel.Text = "Graduation Date:";
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
            this.tableAdapterManager.EducationTableAdapter = this.educationTableAdapter;
            this.tableAdapterManager.UpdateOrder = System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // educationTableAdapter
            // 
            this.educationTableAdapter.ClearBeforeFill = true;
            // 
            // alumni_IDTextBox
            // 
            this.alumni_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Alumni_ID", true));
            this.alumni_IDTextBox.Location = new System.Drawing.Point(389, 25);
            this.alumni_IDTextBox.Name = "alumni_IDTextBox";
            this.alumni_IDTextBox.ReadOnly = true;
            this.alumni_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.alumni_IDTextBox.TabIndex = 2;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(389, 51);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.ReadOnly = true;
            this.first_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.first_NameTextBox.TabIndex = 4;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(389, 77);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.ReadOnly = true;
            this.last_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.last_NameTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(389, 103);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(104, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(389, 207);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.ReadOnly = true;
            this.streetTextBox.Size = new System.Drawing.Size(130, 20);
            this.streetTextBox.TabIndex = 10;
            // 
            // mobile_PhoneTextBox
            // 
            this.mobile_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Mobile_Phone", true));
            this.mobile_PhoneTextBox.Location = new System.Drawing.Point(389, 129);
            this.mobile_PhoneTextBox.Name = "mobile_PhoneTextBox";
            this.mobile_PhoneTextBox.ReadOnly = true;
            this.mobile_PhoneTextBox.Size = new System.Drawing.Size(81, 20);
            this.mobile_PhoneTextBox.TabIndex = 12;
            // 
            // home_PhoneTextBox
            // 
            this.home_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Home_Phone", true));
            this.home_PhoneTextBox.Location = new System.Drawing.Point(389, 155);
            this.home_PhoneTextBox.Name = "home_PhoneTextBox";
            this.home_PhoneTextBox.ReadOnly = true;
            this.home_PhoneTextBox.Size = new System.Drawing.Size(81, 20);
            this.home_PhoneTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(389, 181);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(130, 20);
            this.emailTextBox.TabIndex = 16;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(389, 259);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(104, 20);
            this.cityTextBox.TabIndex = 18;
            // 
            // zip_CodeTextBox
            // 
            this.zip_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Zip_Code", true));
            this.zip_CodeTextBox.Location = new System.Drawing.Point(389, 233);
            this.zip_CodeTextBox.Name = "zip_CodeTextBox";
            this.zip_CodeTextBox.ReadOnly = true;
            this.zip_CodeTextBox.Size = new System.Drawing.Size(37, 20);
            this.zip_CodeTextBox.TabIndex = 20;
            // 
            // active_CheckBox
            // 
            this.active_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.alumniBindingSource, "Active?", true));
            this.active_CheckBox.Enabled = false;
            this.active_CheckBox.Location = new System.Drawing.Point(389, 311);
            this.active_CheckBox.Name = "active_CheckBox";
            this.active_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.active_CheckBox.TabIndex = 22;
            this.active_CheckBox.UseVisualStyleBackColor = true;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(389, 341);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(234, 127);
            this.notesTextBox.TabIndex = 24;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(389, 285);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(30, 20);
            this.stateTextBox.TabIndex = 26;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(66, 275);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 37;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // educationBindingSource
            // 
            this.educationBindingSource.DataMember = "Education";
            this.educationBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // education_IDTextBox
            // 
            this.education_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Education_ID", true));
            this.education_IDTextBox.Location = new System.Drawing.Point(106, 25);
            this.education_IDTextBox.Name = "education_IDTextBox";
            this.education_IDTextBox.ReadOnly = true;
            this.education_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.education_IDTextBox.TabIndex = 38;
            // 
            // alumni_IDTextBox1
            // 
            this.alumni_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Alumni_ID", true));
            this.alumni_IDTextBox1.Location = new System.Drawing.Point(106, 51);
            this.alumni_IDTextBox1.Name = "alumni_IDTextBox1";
            this.alumni_IDTextBox1.ReadOnly = true;
            this.alumni_IDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.alumni_IDTextBox1.TabIndex = 40;
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Degree", true));
            this.degreeTextBox.Location = new System.Drawing.Point(106, 77);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.ReadOnly = true;
            this.degreeTextBox.Size = new System.Drawing.Size(167, 20);
            this.degreeTextBox.TabIndex = 42;
            // 
            // institutionTextBox
            // 
            this.institutionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Institution", true));
            this.institutionTextBox.Location = new System.Drawing.Point(106, 103);
            this.institutionTextBox.Name = "institutionTextBox";
            this.institutionTextBox.ReadOnly = true;
            this.institutionTextBox.Size = new System.Drawing.Size(167, 20);
            this.institutionTextBox.TabIndex = 44;
            // 
            // graduation_DateTextBox
            // 
            this.graduation_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Graduation_Date", true));
            this.graduation_DateTextBox.Location = new System.Drawing.Point(106, 129);
            this.graduation_DateTextBox.Name = "graduation_DateTextBox";
            this.graduation_DateTextBox.ReadOnly = true;
            this.graduation_DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.graduation_DateTextBox.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Alumni connected to this Education record";
            // 
            // EducationViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(education_IDLabel);
            this.Controls.Add(this.education_IDTextBox);
            this.Controls.Add(alumni_IDLabel1);
            this.Controls.Add(this.alumni_IDTextBox1);
            this.Controls.Add(degreeLabel);
            this.Controls.Add(this.degreeTextBox);
            this.Controls.Add(institutionLabel);
            this.Controls.Add(this.institutionTextBox);
            this.Controls.Add(graduation_DateLabel);
            this.Controls.Add(this.graduation_DateTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(alumni_IDLabel);
            this.Controls.Add(this.alumni_IDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(mobile_PhoneLabel);
            this.Controls.Add(this.mobile_PhoneTextBox);
            this.Controls.Add(home_PhoneLabel);
            this.Controls.Add(this.home_PhoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(zip_CodeLabel);
            this.Controls.Add(this.zip_CodeTextBox);
            this.Controls.Add(active_Label);
            this.Controls.Add(this.active_CheckBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Name = "EducationViewForm";
            this.Text = "View an Education record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EducationViewForm_FormClosing);
            this.Load += new System.EventHandler(this.EducationViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet;
        private System.Windows.Forms.BindingSource alumniBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.AlumniTableAdapter alumniTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox alumni_IDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox mobile_PhoneTextBox;
        private System.Windows.Forms.TextBox home_PhoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zip_CodeTextBox;
        private System.Windows.Forms.CheckBox active_CheckBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Button closeButton;
        private Alumni_Association_DocumentationDataSetTableAdapters.EducationTableAdapter educationTableAdapter;
        private System.Windows.Forms.BindingSource educationBindingSource;
        private System.Windows.Forms.TextBox education_IDTextBox;
        private System.Windows.Forms.TextBox alumni_IDTextBox1;
        private System.Windows.Forms.TextBox degreeTextBox;
        private System.Windows.Forms.TextBox institutionTextBox;
        private System.Windows.Forms.TextBox graduation_DateTextBox;
        private System.Windows.Forms.Label label1;
    }
}