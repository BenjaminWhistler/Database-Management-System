using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Support_Project.Account;
using System_Support_Project.Alumni;
using System_Support_Project.Donation;
using System_Support_Project.Education;

namespace System_Support_Project
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fileExitToolstrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          AlumniMainForm1 alumniMainForm = new AlumniMainForm1();
          alumniMainForm.ShowDialog();
        }

        private void accountRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccountMainForm accountMainForm = new AccountMainForm();
            accountMainForm.ShowDialog();
        }

        private void donationRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonationMainForm donationMainForm = new DonationMainForm();
            donationMainForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Such Alumni Database Management System\nVersion 1.0\nCreated by Benjamin Whistler");
        }

        private void educationRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EducationMainForm educationMainForm = new EducationMainForm();
            educationMainForm.ShowDialog();
        }
    }
}
