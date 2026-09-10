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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace System_Support_Project.Account
{
    public partial class AccountAddForm : Form
    {

        AccountMainForm epic = (AccountMainForm)Application.OpenForms["AccountMainForm"];
        public AccountAddForm()
        {
            InitializeComponent();
        }

        private void AccountAddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            this.accountBindingSource.AddNew();
            active_CheckBox.ThreeState = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.accountBindingSource.EndEdit();
                this.accountTableAdapter.Update(this.alumni_Association_DocumentationDataSet.Account);

                if (epic != null)
                {
                    epic.loadData();
                }

                this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
                this.accountBindingSource.AddNew();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void account_NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccountMainForm.restrictAdd = false;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (account_NameTextBox.Text != "" || account_NumberTextBox.Text != "" || parent_NumberTextBox.Text != "")
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
