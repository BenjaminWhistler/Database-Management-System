using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Support_Project.Education
{
    public partial class EducationAddForm : Form
    {

        EducationMainForm epic = (EducationMainForm)Application.OpenForms["EducationMainForm"];
        public EducationAddForm()
        {
            InitializeComponent();
        }

        private void EducationAddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Education' table. You can move, or remove it, as needed.
            this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
            this.educationBindingSource.AddNew();
        }

        private void EducationAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EducationMainForm.restrictAdd = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.educationBindingSource.EndEdit();
                this.educationTableAdapter.Update(this.alumni_Association_DocumentationDataSet.Education);

                if (epic != null)
                {
                    epic.loadData();
                }

                this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
                this.educationBindingSource.AddNew();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (alumni_IDTextBox.Text != "" || degreeTextBox.Text != "" || institutionTextBox.Text != "" || graduation_DateTextBox.Text != "")
            {
                string prompt = "You will lose any data entered data. Do you wish to cancel and exit?";
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
