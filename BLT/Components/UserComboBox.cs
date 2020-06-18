using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BLT.SQL;

namespace BLT.Components
{
    public class UserComboBox : ComboBox
    {
        public UserComboBox() : base()
        {
            Initialize();
        }

        private void Initialize()
        {
            List<User> users = UserSQLAccess.GetAllUsers();
            base.Items.AddRange(users.ToArray());
        }

        public User SelectedUser
        {
            get
            {
                if (SelectedItem == null)
                {
                    return null;
                }

                if (!(SelectedItem is User))
                {
                    throw new ArgumentOutOfRangeException(SelectedItem!=null?SelectedItem.ToString():"SelectedItem");
                }
                return (SelectedItem as User);
            }
        }
    }
}
