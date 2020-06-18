using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLT.SQL;

namespace BLT
{
    public partial class AddUserForm : Form
    {
        private User user;
        public User User
        {
            get 
            {
                user = new User(this.firstNameTextbox.Text, this.lastNameTextbox.Text);
                return user; 
            }
        }

        public AddUserForm()
        {
            InitializeComponent();
            this.Shown += new EventHandler(AddUserForm_Shown);
        }

        void AddUserForm_Shown(object sender, EventArgs e)
        {
            this.firstNameTextbox.Focus();
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.firstNameTextbox.Clear();
            this.lastNameTextbox.Clear();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearForm();

            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}