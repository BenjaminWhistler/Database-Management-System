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
    public partial class EducationViewForm : Form
    {

        public int e_id;
        public EducationViewForm()
        {
            InitializeComponent();
        }

        private void EducationViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Education' table. You can move, or remove it, as needed.
            this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Education' table. You can move, or remove it, as needed.
            this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Alumni' table. You can move, or remove it, as needed.
            this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Alumni);
            this.educationBindingSource.Position = this.educationBindingSource.Find("Education_ID", e_id);
            this.alumniBindingSource.Position = this.alumniBindingSource.Find("Alumni_ID", alumni_IDTextBox1.Text);

        }

        private void EducationViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EducationMainForm.restrictView = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
