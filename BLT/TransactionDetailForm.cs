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
    public partial class TransactionDetailForm : Form
    {
        private static TransactionDetailForm _instance;
        public static TransactionDetailForm Instance
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new TransactionDetailForm();
                }
                
                return _instance; 
            }
        }       

        public static void ShowTransactionDetails(Int32 transactionID)
        {
            Instance.SetTransaction(transactionID);            

            Instance.Show();
        }

        private void SetTransaction(Int32 transactionID)
        {
            this.transactionDetailView.Rows.Clear();

            foreach (Payment p in PaymentSQLAccess.GetPayments(transactionID))
            {
                this.transactionDetailView.Rows.Add(new object[] { p.User, p.Amount });
            }
        }

        private TransactionDetailForm()
        {
            InitializeComponent();

            this.transactionDetailView.Columns.Add("user", "User");
            this.transactionDetailView.Columns.Add("amount", "Amount");

            this.transactionDetailView.AutoSize = true;
            this.transactionDetailView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.Closing += new CancelEventHandler(TransactionDetailForm_Closing);
        }

        void TransactionDetailForm_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}