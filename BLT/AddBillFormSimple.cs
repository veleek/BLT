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
    public partial class AddBillFormSimple : Form
    {
        public AddBillFormSimple()
        {
            InitializeComponent();
        }

        private void AddBillFormSimple_Load(object sender, EventArgs e)
        {
            debtorsListBox.DisplayMember = "DisplayName";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            debtorsListBox.Items.Clear();
            transactionDatePicker.Value = DateTime.Today;
            amountTextBox.Text = String.Empty;
            descriptionTextbox.Text = String.Empty;

            payerComboBox.SelectedIndex = 0;
            debtorComboBox.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (debtorsListBox.SelectedIndex > 0)
            {
                debtorsListBox.Items.Remove(debtorsListBox.SelectedItem);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            User selectedUser = debtorComboBox.SelectedUser;

            if (selectedUser != null)
            {
                debtorsListBox.Items.Add(selectedUser);
            }
        }

        private void submitBillButton_Click(object sender, EventArgs e)
        {
            uint index = 1;
            int debtorCount = debtorsListBox.Items.Count;
            Payment[] payments = new Payment[debtorCount + 1];

            Transaction t = new Transaction(amountTextBox.Value, transactionDatePicker.Value, descriptionTextbox.Text);

            Decimal debitAmount = t.Amount / debtorCount;

            payments[0] = new Payment(payerComboBox.SelectedUser, t.Amount, t, false);

            foreach (User u in debtorsListBox.Items)
            {
                payments[index] = new Payment(u, debitAmount, t, true);
            }

            TransactionSQLAccess.AddTransaction(t);

            foreach (Payment p in payments)
            {
                PaymentSQLAccess.AddPayment(p);
            }
        }
    }
}