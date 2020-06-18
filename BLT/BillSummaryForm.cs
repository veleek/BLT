using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLT.SQL;
using System.Collections;

namespace BLT
{
    public partial class BillSummaryForm : Form
    {
        private BindingSource bindingSource;

        public BillSummaryForm()
        {
            InitializeComponent();

            Dictionary<User, Decimal> balances = new Dictionary<User, Decimal>();

            foreach(Payment p in PaymentSQLAccess.GetAllPayments())
            {
                if(balances.ContainsKey(p.User))
                {
                    balances[p.User] += p.Amount;
                }
                else
                {
                    balances[p.User] = p.Amount;
                }
            }

            bindingSource = new BindingSource();

            foreach(User u in balances.Keys)
            {

                bindingSource.Add(new BalanceData(u, balances[u]));
            }

            balanceTable.AutoGenerateColumns = true;
            balanceTable.AutoSize = true;
            balanceTable.DataSource = bindingSource;

            /*
            DataGridViewColumn nameColumn = new DataGridViewColumn();
            nameColumn.DataPropertyName = "User.DisplayName";
            nameColumn.Name = "Name";
            balanceTable
             */
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (balanceTable.SelectedRows.Count > 0)
            {
                User selectedUser = ((BalanceData)balanceTable.SelectedRows[0].DataBoundItem).User;

                BillDetailForm.ShowBillDetails(selectedUser);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class BalanceData
    {
        private User _user;
        public User User
        {
            get { return _user; }
        }


        private Decimal _balance;
        public Decimal Balance
        {
            get { return _balance; }
        }

        public BalanceData(User user, Decimal balance)
        {
            this._user = user;
            this._balance = balance;
        }
    }
}