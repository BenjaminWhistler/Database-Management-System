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
    public partial class AlumniEditForm : Form
    {
        AlumniMainForm1 epic = (AlumniMainForm1)Application.OpenForms["AlumniMainForm1"];
        public int e_id;
        public AlumniEditForm()
        {
            InitializeComponent();
        }

        private void AlumniDeleteForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Alumni' table. You can move, or remove it, as needed.
            this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Alumni);

            this.alumniBindingSource.Position = this.alumniBindingSource.Find("Alumni_ID", e_id);
        }

        private void AlumniDeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AlumniMainForm1.restrictEdit = false;
            epic.loadData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Validate();

            try
            {
                this.alumniBindingSource.EndEdit();
                this.alumniTableAdapter.Update(this.alumni_Association_DocumentationDataSet.Alumni);
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to save. System says;    " + ex.Message);
            }
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
    }
}
