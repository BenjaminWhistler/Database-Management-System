using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace System_Support_Project.Alumni
{
    public partial class AlumniViewForm : Form
    {

        public int e_id;
        public AlumniViewForm()
        {
            InitializeComponent();
        }

        private void alumniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alumni_Association_DocumentationDataSet);

        }

        private void AlumniViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Education' table. You can move, or remove it, as needed.
            this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Alumni' table. You can move, or remove it, as needed.
            this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Alumni);
            active_CheckBox.AutoCheck = false;

            this.alumniBindingSource.Position = this.alumniBindingSource.Find("Alumni_ID", e_id);

        }

        private void AlumniViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AlumniMainForm1.restrictView = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void donationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
