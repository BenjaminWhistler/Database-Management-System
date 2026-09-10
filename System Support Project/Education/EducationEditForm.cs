using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Support_Project.Account;

namespace System_Support_Project.Education
{
    public partial class EducationEditForm : Form
    {
        EducationMainForm epic = (EducationMainForm)Application.OpenForms["EducationMainForm"];
        public int e_id;
        public EducationEditForm()
        {
            InitializeComponent();
        }

        private void EducationEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Education' table. You can move, or remove it, as needed.
            this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
            this.educationBindingSource.Position = this.educationBindingSource.Find("Education_ID", e_id);

        }

        private void EducationEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EducationMainForm.restrictEdit = false;
            epic.loadData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.educationBindingSource.CancelEdit();

            string prompt = "You will lose any data you may have entered. Do you wish to cancel and exit?";
            DialogResult result = MessageBox.Show(prompt, "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Validate();

            try
            {
                this.educationBindingSource.EndEdit();
                this.educationTableAdapter.Update(this.alumni_Association_DocumentationDataSet.Education);
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to save. System says;    " + ex.Message);
            }
        }
    }
}

