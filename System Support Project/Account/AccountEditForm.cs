using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Support_Project.Alumni;

namespace System_Support_Project.Account
{
    public partial class AccountEditForm : Form
    {
        AccountMainForm epic = (AccountMainForm)Application.OpenForms["AccountMainForm"];
        public int e_id;
        public AccountEditForm()
        {
            InitializeComponent();
        }
        private void AccountEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            this.accountBindingSource.Position = this.accountBindingSource.Find("Record_ID", e_id);
        }

        private void AccountEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccountMainForm.restrictEdit = false;
            epic.loadData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.accountBindingSource.CancelEdit();

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
                this.accountBindingSource.EndEdit();
                this.accountTableAdapter.Update(this.alumni_Association_DocumentationDataSet.Account);
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to save. System says;    " + ex.Message);
            }
        }
    }
}
