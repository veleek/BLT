using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BLT
{
    public partial class AccountSummaryForm : Form
    {
        public AccountSummaryForm()
        {
            InitializeComponent();
        }

        private void userComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = userComboBox1.SelectedUser;
            if (selectedUser != null)
            {
                accountViewControl1.User = selectedUser;
                accountViewControl1.Refresh();
            }
        }
    }
}