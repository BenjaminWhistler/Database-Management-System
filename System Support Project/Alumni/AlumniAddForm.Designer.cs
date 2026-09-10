namespace System_Support_Project.Alumni
{
    partial class AlumniAddForm
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
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label titleLabel1;
            System.Windows.Forms.Label streetLabel1;
            System.Windows.Forms.Label mobile_PhoneLabel;
            System.Windows.Forms.Label home_PhoneLabel;
            System.Windows.Forms.Label emailLabel1;
            System.Windows.Forms.Label cityLabel1;
            System.Windows.Forms.Label zip_CodeLabel;
            System.Windows.Forms.Label active_Label;
            System.Windows.Forms.Label notesLabel1;
            System.Windows.Forms.Label stateLabel1;
            this.alumni_Association_DocumentationDataSet1 = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.alumniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumniTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AlumniTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox1 = new System.Windows.Forms.TextBox();
            this.streetTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.cityTextBox1 = new System.Windows.Forms.TextBox();
            this.zip_CodeTextBox = new System.Windows.Forms.TextBox();
            this.active_CheckBox = new System.Windows.Forms.CheckBox();
            this.notesTextBox1 = new System.Windows.Forms.TextBox();
            this.stateTextBox1 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.mobile_PhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.home_PhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            streetLabel1 = new System.Windows.Forms.Label();
            mobile_PhoneLabel = new System.Windows.Forms.Label();
            home_PhoneLabel = new System.Windows.Forms.Label();
            emailLabel1 = new System.Windows.Forms.Label();
            cityLabel1 = new System.Windows.Forms.Label();
            zip_CodeLabel = new System.Windows.Forms.Label();
            active_Label = new System.Windows.Forms.Label();
            notesLabel1 = new System.Windows.Forms.Label();
            stateLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(9, 9);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 29;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(9, 35);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 31;
            last_NameLabel.Text = "Last Name:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Location = new System.Drawing.Point(9, 61);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(30, 13);
            titleLabel1.TabIndex = 33;
            titleLabel1.Text = "Title:";
            // 
            // streetLabel1
            // 
            streetLabel1.AutoSize = true;
            streetLabel1.Location = new System.Drawing.Point(9, 165);
            streetLabel1.Name = "streetLabel1";
            streetLabel1.Size = new System.Drawing.Size(38, 13);
            streetLabel1.TabIndex = 35;
            streetLabel1.Text = "Street:";
            // 
            // mobile_PhoneLabel
            // 
            mobile_PhoneLabel.AutoSize = true;
            mobile_PhoneLabel.Location = new System.Drawing.Point(9, 87);
            mobile_PhoneLabel.Name = "mobile_PhoneLabel";
            mobile_PhoneLabel.Size = new System.Drawing.Size(75, 13);
            mobile_PhoneLabel.TabIndex = 37;
            mobile_PhoneLabel.Text = "Mobile Phone:";
            // 
            // home_PhoneLabel
            // 
            home_PhoneLabel.AutoSize = true;
            home_PhoneLabel.Location = new System.Drawing.Point(9, 113);
            home_PhoneLabel.Name = "home_PhoneLabel";
            home_PhoneLabel.Size = new System.Drawing.Size(72, 13);
            home_PhoneLabel.TabIndex = 39;
            home_PhoneLabel.Text = "Home Phone:";
            // 
            // emailLabel1
            // 
            emailLabel1.AutoSize = true;
            emailLabel1.Location = new System.Drawing.Point(9, 139);
            emailLabel1.Name = "emailLabel1";
            emailLabel1.Size = new System.Drawing.Size(35, 13);
            emailLabel1.TabIndex = 41;
            emailLabel1.Text = "Email:";
            // 
            // cityLabel1
            // 
            cityLabel1.AutoSize = true;
            cityLabel1.Location = new System.Drawing.Point(9, 217);
            cityLabel1.Name = "cityLabel1";
            cityLabel1.Size = new System.Drawing.Size(27, 13);
            cityLabel1.TabIndex = 43;
            cityLabel1.Text = "City:";
            // 
            // zip_CodeLabel
            // 
            zip_CodeLabel.AutoSize = true;
            zip_CodeLabel.Location = new System.Drawing.Point(9, 191);
            zip_CodeLabel.Name = "zip_CodeLabel";
            zip_CodeLabel.Size = new System.Drawing.Size(53, 13);
            zip_CodeLabel.TabIndex = 45;
            zip_CodeLabel.Text = "Zip Code:";
            // 
            // active_Label
            // 
            active_Label.AutoSize = true;
            active_Label.Location = new System.Drawing.Point(9, 271);
            active_Label.Name = "active_Label";
            active_Label.Size = new System.Drawing.Size(43, 13);
            active_Label.TabIndex = 47;
            active_Label.Text = "Active?";
            // 
            // notesLabel1
            // 
            notesLabel1.AutoSize = true;
            notesLabel1.Location = new System.Drawing.Point(9, 299);
            notesLabel1.Name = "notesLabel1";
            notesLabel1.Size = new System.Drawing.Size(38, 13);
            notesLabel1.TabIndex = 49;
            notesLabel1.Text = "Notes:";
            // 
            // stateLabel1
            // 
            stateLabel1.AutoSize = true;
            stateLabel1.Location = new System.Drawing.Point(9, 243);
            stateLabel1.Name = "stateLabel1";
            stateLabel1.Size = new System.Drawing.Size(35, 13);
            stateLabel1.TabIndex = 51;
            stateLabel1.Text = "State:";
            // 
            // alumni_Association_DocumentationDataSet1
            // 
            this.alumni_Association_DocumentationDataSet1.DataSetName = "Alumni_Association_DocumentationDataSet";
            this.alumni_Association_DocumentationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumniBindingSource
            // 
            this.alumniBindingSource.DataMember = "Alumni";
            this.alumniBindingSource.DataSource = this.alumni_Association_DocumentationDataSet1;
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
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(90, 6);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.first_NameTextBox.TabIndex = 30;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(90, 32);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.last_NameTextBox.TabIndex = 32;
            // 
            // titleTextBox1
            // 
            this.titleTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Title", true));
            this.titleTextBox1.Location = new System.Drawing.Point(90, 58);
            this.titleTextBox1.Name = "titleTextBox1";
            this.titleTextBox1.Size = new System.Drawing.Size(104, 20);
            this.titleTextBox1.TabIndex = 34;
            // 
            // streetTextBox1
            // 
            this.streetTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Street", true));
            this.streetTextBox1.Location = new System.Drawing.Point(90, 162);
            this.streetTextBox1.Name = "streetTextBox1";
            this.streetTextBox1.Size = new System.Drawing.Size(150, 20);
            this.streetTextBox1.TabIndex = 36;
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(90, 136);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(150, 20);
            this.emailTextBox1.TabIndex = 42;
            // 
            // cityTextBox1
            // 
            this.cityTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "City", true));
            this.cityTextBox1.Location = new System.Drawing.Point(90, 214);
            this.cityTextBox1.Name = "cityTextBox1";
            this.cityTextBox1.Size = new System.Drawing.Size(104, 20);
            this.cityTextBox1.TabIndex = 44;
            // 
            // zip_CodeTextBox
            // 
            this.zip_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Zip_Code", true));
            this.zip_CodeTextBox.Location = new System.Drawing.Point(90, 188);
            this.zip_CodeTextBox.Name = "zip_CodeTextBox";
            this.zip_CodeTextBox.Size = new System.Drawing.Size(37, 20);
            this.zip_CodeTextBox.TabIndex = 46;
            // 
            // active_CheckBox
            // 
            this.active_CheckBox.Checked = true;
            this.active_CheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.active_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.alumniBindingSource, "Active?", true));
            this.active_CheckBox.Location = new System.Drawing.Point(90, 266);
            this.active_CheckBox.Name = "active_CheckBox";
            this.active_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.active_CheckBox.TabIndex = 48;
            this.active_CheckBox.UseVisualStyleBackColor = true;
            // 
            // notesTextBox1
            // 
            this.notesTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Notes", true));
            this.notesTextBox1.Location = new System.Drawing.Point(90, 296);
            this.notesTextBox1.Multiline = true;
            this.notesTextBox1.Name = "notesTextBox1";
            this.notesTextBox1.Size = new System.Drawing.Size(234, 127);
            this.notesTextBox1.TabIndex = 50;
            // 
            // stateTextBox1
            // 
            this.stateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "State", true));
            this.stateTextBox1.Location = new System.Drawing.Point(90, 240);
            this.stateTextBox1.Name = "stateTextBox1";
            this.stateTextBox1.Size = new System.Drawing.Size(30, 20);
            this.stateTextBox1.TabIndex = 52;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(310, 207);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(123, 23);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "Save and Continue";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(310, 236);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(123, 23);
            this.finishButton.TabIndex = 55;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // mobile_PhoneTextBox
            // 
            this.mobile_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Mobile_Phone", true));
            this.mobile_PhoneTextBox.Location = new System.Drawing.Point(90, 84);
            this.mobile_PhoneTextBox.Mask = "(999) 000-0000";
            this.mobile_PhoneTextBox.Name = "mobile_PhoneTextBox";
            this.mobile_PhoneTextBox.Size = new System.Drawing.Size(83, 20);
            this.mobile_PhoneTextBox.TabIndex = 56;
            // 
            // home_PhoneTextBox
            // 
            this.home_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Home_Phone", true));
            this.home_PhoneTextBox.Location = new System.Drawing.Point(90, 110);
            this.home_PhoneTextBox.Mask = "(999) 000-0000";
            this.home_PhoneTextBox.Name = "home_PhoneTextBox";
            this.home_PhoneTextBox.Size = new System.Drawing.Size(83, 20);
            this.home_PhoneTextBox.TabIndex = 57;
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.alumniBindingSource, "Active?", true));
            this.checkBox1.Location = new System.Drawing.Point(90, 266);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AlumniAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 435);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.home_PhoneTextBox);
            this.Controls.Add(this.mobile_PhoneTextBox);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(titleLabel1);
            this.Controls.Add(this.titleTextBox1);
            this.Controls.Add(streetLabel1);
            this.Controls.Add(this.streetTextBox1);
            this.Controls.Add(mobile_PhoneLabel);
            this.Controls.Add(home_PhoneLabel);
            this.Controls.Add(emailLabel1);
            this.Controls.Add(this.emailTextBox1);
            this.Controls.Add(cityLabel1);
            this.Controls.Add(this.cityTextBox1);
            this.Controls.Add(zip_CodeLabel);
            this.Controls.Add(this.zip_CodeTextBox);
            this.Controls.Add(active_Label);
            this.Controls.Add(this.active_CheckBox);
            this.Controls.Add(notesLabel1);
            this.Controls.Add(this.notesTextBox1);
            this.Controls.Add(stateLabel1);
            this.Controls.Add(this.stateTextBox1);
            this.Name = "AlumniAddForm";
            this.Text = "Add Alumni records";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlumniAddForm_FormClosing);
            this.Load += new System.EventHandler(this.AlumniAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet1;
        private System.Windows.Forms.BindingSource alumniBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.AlumniTableAdapter alumniTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox titleTextBox1;
        private System.Windows.Forms.TextBox streetTextBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.TextBox cityTextBox1;
        private System.Windows.Forms.TextBox zip_CodeTextBox;
        private System.Windows.Forms.CheckBox active_CheckBox;
        private System.Windows.Forms.TextBox notesTextBox1;
        private System.Windows.Forms.TextBox stateTextBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.MaskedTextBox mobile_PhoneTextBox;
        private System.Windows.Forms.MaskedTextBox home_PhoneTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}