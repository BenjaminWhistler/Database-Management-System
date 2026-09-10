using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Support_Project.Alumni
{
    public partial class AlumniAddForm : Form
    {

        AlumniMainForm1 epic = (AlumniMainForm1)Application.OpenForms["AlumniMainForm1"];
        public AlumniAddForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AlumniAddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet1.Alumni' table. You can move, or remove it, as needed.
            this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet1.Alumni);
            this.alumniBindingSource.AddNew();
            checkBox1.Checked = true;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.alumniBindingSource.EndEdit();
                this.alumniTableAdapter.Update(this.alumni_Association_DocumentationDataSet1.Alumni);

                if (epic != null)
                {
                    epic.loadData();
                }

                this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet1.Alumni);
                this.alumniBindingSource.AddNew();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void AlumniAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {            
                AlumniMainForm1.restrictAdd = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.alumniBindingSource.CancelEdit();

            string prompt = "You will lose any data you may have entered. Do you wish to cancel and exit?";
            DialogResult result = MessageBox.Show(prompt, "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox1.Text != "" || streetTextBox1.Text != ""
                || mobile_PhoneTextBox.Text != "(   )    -" || home_PhoneTextBox.Text != "(   )    -" || emailTextBox1.Text != "" || cityTextBox1.Text != "" || zip_CodeTextBox.Text != ""
                || stateTextBox1.Text != "" || notesTextBox1.Text != "")
            {
                string prompt = "You will lose any data entered data. Do you wish to exit?";
                DialogResult result = MessageBox.Show(prompt, "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
              this.Close();
            }
        }
    }
}

