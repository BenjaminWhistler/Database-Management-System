using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Support_Project.Alumni;

namespace System_Support_Project.Account
{
    public partial class AccountMainForm : Form
    {
        public static AccountMainForm Instance;
        public static Boolean restrictAdd = false;
        public static Boolean restrictEdit = false;
        public static Boolean restrictView = false;
        public static Boolean restrictFilter = false;
        public static (string f1, string f2, string f3, string f4, bool f5, bool f6) savedFilter;
        public static string savedFilterLabel;

        public AccountMainForm()
        {
            InitializeComponent();
            Instance = this;
        }
        private void AccountMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            savedFilterLabel = filtersAppliedLabel.Text;
            this.accountDataGridView.Sort((this.accountDataGridView.Columns[1]), ListSortDirection.Ascending);
        }

        public void loadData()
        {
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
        }

        private void AccountMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccountMainForm.restrictAdd = false;
            AccountMainForm.restrictEdit = false;
            AccountMainForm.restrictFilter = false;
            AccountMainForm.restrictView = false;
        }

        public void filterAll(string f1 = null, string f2 = null, string f3 = null, string f4 = null, Boolean f5 = true, Boolean f6 = true)
        {
            List<string> filters = new List<string>();

            if (!string.IsNullOrWhiteSpace(f1))
                filters.Add("Convert([Record_ID], 'System.String') LIKE '" + f1 + "%'");

            if (!string.IsNullOrWhiteSpace(f2))
                filters.Add("[Account_Number] LIKE '%" + f2 + "%'");

            if (!string.IsNullOrWhiteSpace(f3))
                filters.Add("[Account_Name] LIKE '%" + f3 + "%'");

            if (!string.IsNullOrWhiteSpace(f4))
                filters.Add("[Parent_Number] LIKE '%" + f4 + "%'");

            if (f5 == true)
                filters.Add("[Active?] = False");
            if (f6 == true)
                filters.Add("[Active?] = True");

            accountBindingSource.Filter = string.Join(" AND ", filters);
        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (restrictFilter == false)
            {
                restrictFilter = true;
                AccountFilters frm = new AccountFilters();
                frm.Show();
                frm.Owner = this;

            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void addARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (restrictAdd == false)
            {
                restrictAdd = true;
                AccountAddForm frm = new AccountAddForm();
                frm.Show();
                frm.Owner = this;
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void editARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountEditForm frm = new AccountEditForm();

            int rowCount = accountDataGridView.SelectedRows.Count;

            if (rowCount > 1)
            {
                MessageBox.Show("Too many rows selected. You may only edit one record at a time.");
            }
            else if (rowCount < 1)
            {
                MessageBox.Show("Use the mouse to select an alumni record in the grid to edit.");
            }
            else if (restrictEdit == false)
            {
                int m_id = (int)(accountDataGridView.CurrentRow.Cells[0].Value);
                frm.e_id = m_id;
                restrictEdit = true;
                frm.Owner = this;
                frm.Show();
                this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void viewARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountViewForm frm = new AccountViewForm();

            int rowCount = accountDataGridView.SelectedRows.Count;

            if (rowCount > 1)
            {
                MessageBox.Show("Too many rows selected. You may only view one record at a time.");
            }
            else if (rowCount < 1)
            {
                MessageBox.Show("Use the mouse to select an account record in the grid to view.");
            }
            else if (restrictView == false)
            {
                string m_id = (accountDataGridView.CurrentRow.Cells[1].Value.ToString());
                frm.e_id = m_id;
                restrictView = true;
                frm.Owner = this;
                frm.Show();
                this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        public void filterLabel()
        {
            filtersAppliedLabel.Text = savedFilterLabel;
        }

        private void exportFunction()
        {
            if (accountDataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        if (accountDataGridView.SelectedRows.Count > 0)
                        {
                            try
                            {
                                int columnCount = accountDataGridView.Columns.Count;
                                string columnNames = "";
                                string[] outputCsv = new string[accountDataGridView.SelectedRows.Count + 1];
                                for (int i = 0; i < columnCount; i++)
                                {
                                    columnNames += accountDataGridView.Columns[i].HeaderText.ToString() + ",";
                                }
                                outputCsv[0] += columnNames;

                                for (int i = 1; (i - 1) < accountDataGridView.SelectedRows.Count; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        outputCsv[i] += accountDataGridView.SelectedRows[i - 1].Cells[j].Value.ToString() + ",";
                                    }   
                                }

                                File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                                MessageBox.Show("Note: only the selected rows were exported. Data Exported Successfully!", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                        else if (accountDataGridView.SelectedRows.Count == 0)
                        {
                            try
                            {
                                int columnCount = accountDataGridView.Columns.Count;
                                string columnNames = "";
                                string[] outputCsv = new string[accountDataGridView.Rows.Count + 1];
                                for (int i = 0; i < columnCount; i++)
                                {
                                    columnNames += accountDataGridView.Columns[i].HeaderText.ToString() + ",";
                                }
                                outputCsv[0] += columnNames;

                                for (int i = 1; (i - 1) < accountDataGridView.Rows.Count; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        outputCsv[i] += accountDataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }

                                File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                                MessageBox.Show("Data Exported Successfully !!!", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Records to export.", "Info");
            }
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filtersAppliedLabel.Text != "")
            {
                string prompt = "You have filters applied. Only the filtered data will be exported, would you like to proceed?";
                DialogResult result = MessageBox.Show(prompt, "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    exportFunction();
                }
            }
            else if (filtersAppliedLabel.Text == "")
            {
                exportFunction();
            }
        }
    }
}
