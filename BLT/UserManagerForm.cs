using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLT.Data;
using BLT.SQL;

namespace BLT
{
    public partial class UserManagerForm : Form
    {
        private AddUserForm addUserForm;

        public User SelectedUser
        {
            get
            {
                return (User)this.usersListbox.SelectedItem;
            }
        }

        public UserManagerForm()
        {
            InitializeComponent();

            this.addUserForm = new AddUserForm();

            this.Load += new EventHandler(UserManagerForm_Load);
        }

        void UserManagerForm_Load(object sender, EventArgs e)
        {
            ResetUsers();
        }

        private void ResetUsers()
        {
            try
            {
                usersListbox.Items.Clear();
                usersListbox.Items.AddRange(UserSQLAccess.GetAllUsers().ToArray());

                ShowDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usersListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetails();
        }

        private void ShowDetails()
        {
            User user = this.SelectedUser;

            bool validUser = (user != null);

            if (validUser)
            {
                this.firstNameTextBox.Text = user.FirstName;
                this.lastNameTextBox.Text = user.LastName;
                this.displayNameValue.Text = user.DisplayName;
                this.idValue.Text = user.ID.ToString();                
            }
            else
            {
                this.firstNameTextBox.Text = "";
                this.lastNameTextBox.Text = "";
                this.displayNameValue.Text = "";
                this.idValue.Text = "";
            }

            this.saveChangesButton.Enabled = false;
            this.resetChangesButton.Enabled = validUser;
            this.firstNameTextBox.Enabled = validUser;
            this.lastNameTextBox.Enabled = validUser;
        }

        private void detailTextBox_TextChanged(object sender, EventArgs e)
        {
            this.saveChangesButton.Enabled = true;
        }

        private void resetChangesButton_Click(object sender, EventArgs e)
        {
            ShowDetails();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (this.firstNameTextBox.Text.Length == 0
                && this.lastNameTextBox.Text.Length == 0)
            {
                userManagerErrorProvider.SetError(firstNameTextBox, "A name must be provided");
                return;
            }

            User user = this.SelectedUser;
            
            UserSQLAccess.UpdateFirstName(this.firstNameTextBox.Text, user.ID);
            UserSQLAccess.UpdateLastName(this.lastNameTextBox.Text, user.ID);

            this.saveChangesButton.Enabled = false;
            this.resetChangesButton.Enabled = false;

            ResetUsers();
        }

        void UserManagerForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            UserSQLAccess.DeleteUser(this.SelectedUser.ID);

            ResetUsers();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                UserSQLAccess.AddUser(addUserForm.User);

                ResetUsers();
            }
        }
    }
}