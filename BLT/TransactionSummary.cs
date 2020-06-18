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
    public partial class TransactionSummary : Form
    {
        public TransactionSummary()
        {
            InitializeComponent();

            foreach (Transaction t in TransactionSQLAccess.GetAllTransactions())
            {
                transactionTable.Rows.Add(
                    new object[] { t.TransactionId, t.Description, t.Amount, t.Date.ToShortDateString() }
                );
            }
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if(transactionTable.SelectedCells.Count > 0)
            {
                DataGridViewRow row = transactionTable.Rows[transactionTable.SelectedCells[0].RowIndex];

                Int32 transactionID = (Int32)row.Cells[0].Value;

                TransactionDetailForm.ShowTransactionDetails(transactionID);
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