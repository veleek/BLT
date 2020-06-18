using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLT.Data;

namespace BLT
{
    public partial class BLTMain : Form
    {
        private PersonManager pm;
        private UserManagerForm userManager;

        public BLTMain()
        {
            InitializeComponent();
            
            pm = PersonManager.Instance;
            pm.CreatePerson("Ben", "Randall", new DateTime(1985, 6, 26));
            pm.CreatePerson("Stephen", "Randall", DateTime.Today);
            pm.CreatePerson("Marie", "Randall", DateTime.Today);
            pm.CreatePerson("Alf", "Randall", DateTime.Today);
            pm.CreatePerson("Kristine", "Randall", DateTime.Today);

            userManager = new UserManagerForm();
        }

        private void manageUsersButton_Click(object sender, EventArgs e)
        {
            userManager.Show();
        }

        private void addBillButton_Click(object sender, EventArgs e)
        {
            AddBillForm f = new AddBillForm();

            f.ShowDialog();
        }

        private void viewBillsButton_Click(object sender, EventArgs e)
        {
            TransactionSummary f = new TransactionSummary();

            f.ShowDialog();
        }

        private void viewAccountsButton_Click(object sender, EventArgs e)
        {
            AccountSummaryForm f = new AccountSummaryForm();

            f.ShowDialog();
        }


    }
}