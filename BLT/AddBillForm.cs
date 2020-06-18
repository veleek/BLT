using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace BLT
{
    public partial class AddBillForm : Form
    {
        #region Constructors

        public AddBillForm()
        {
            InitializeComponent();
            Initialize();
        }

        #endregion

        #region Private Methods

        private void Initialize()
        {
            _bill = new Bill();
            ClearForm();
        }

        private void ClearForm()
        {
            billDateTimePicker.Value = DateTime.Today;
            transactionAmountTextBox.Clear();
            billDescriptionTextBox.Clear();
            payeeAmountTextbox.Clear();
            debtorAmountTextbox.Clear();
            payeeListBox.Items.Clear();
            debtorListBox.Items.Clear();
        }

        private void EnsureTransaction()
        {
            if (!_bill.IsTransactionSet)
            {
                _bill.Transaction = new Transaction(transactionAmountTextBox.Value, billDateTimePicker.Value, billDescriptionTextBox.Text);
            }
            else
            {
                UpdateTransaction();
            }
        }

        private void UpdateTransaction()
        {
            _bill.Transaction.Amount = transactionAmountTextBox.Value;
            _bill.Transaction.Date = billDateTimePicker.Value;
            _bill.Transaction.Description = billDescriptionTextBox.Text;
        }

        private void ResetPayeeInformation()
        {
            payeeComboBox.SelectedItem = null;
            payeeComboBox.Text = String.Empty;
            payeeComboBox.Refresh();
            payeeAmountTextbox.Clear();
        }

        private void ResetDebtorInformation()
        {
            debtorComboBox.SelectedItem = null;
            debtorComboBox.Text = String.Empty;
            debtorComboBox.Refresh();
            debtorAmountTextbox.Clear();
        }

        private void ValidateAmount()
        {
            Decimal transactionAmount = transactionAmountTextBox.Value;

            Decimal totalPayment = Decimal.Zero;
            foreach (Payment payment in Payments)
            {
                totalPayment = Decimal.Add(totalPayment, payment.Amount);
            }

            Decimal totalDebt = Decimal.Zero;
            foreach (Payment debt in Debts)
            {
                totalDebt = Decimal.Add(totalDebt, debt.Amount);
            }

            if (Decimal.Compare(transactionAmount, totalPayment) != 0)
            {
                throw new ArgumentException("Unequal total payment with transaction amount");
            }

            if (Decimal.Add(totalPayment, totalDebt) != 0)
            {
                throw new ArgumentException("Unequal total payment with total debt");
            }
        }

        private bool TryGetPayment(User user, out Payment payment)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }

            foreach (Payment currentPayment in Payments)
            {
                if (user.Equals(currentPayment.User))
                {
                    payment = currentPayment;
                    return true;
                }
            }
            payment = null;
            return false;
        }

        private bool TryGetDebt(User user, out Payment debt)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }

            foreach (Payment currentDebt in Debts)
            {
                if (user.Equals(currentDebt.User))
                {
                    debt = currentDebt;
                    return true;
                }
            }
            debt = null;
            return false;
        }

        private void payeeAddButton_Click(object sender, EventArgs e)
        {
            if (payeeComboBox.SelectedUser != null)
            {
                Payment payment = null;
                if (TryGetPayment(payeeComboBox.SelectedUser, out payment))
                {
                    DialogResult choice =
                        MessageBox.Show("Payment for the same user exists.\r\nDo you want to replace it?", 
                        "Payment", MessageBoxButtons.YesNo);
                    if (choice.Equals(DialogResult.No))
                    {
                        return;
                    }
                    payeeListBox.Items.Remove(payment);
                }

                EnsureTransaction();
                try
                {
                    User payee = payeeComboBox.SelectedUser;
                    Payment newPayment = new Payment(payee, payeeAmountTextbox.Value, _bill.Transaction, false);
                    payeeListBox.Items.Add(newPayment);
                    ResetPayeeInformation();
                    debtorComboBox.Refresh();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("No user is selected");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void debtorAddButton_Click(object sender, EventArgs e)
        {
            if (debtorComboBox.SelectedUser != null)
            {
                Payment debt = null;
                if (TryGetDebt(debtorComboBox.SelectedUser, out debt))
                {
                    DialogResult choice =
                        MessageBox.Show("Debt for the same user exists.\r\nDo you want to replace it?",
                        "Debt", MessageBoxButtons.YesNo);
                    if (choice.Equals(DialogResult.No))
                    {
                        return;
                    }
                    debtorListBox.Items.Remove(debt);
                }

                EnsureTransaction();
                try
                {
                    User debtor = debtorComboBox.SelectedUser;
                    Payment newPayment = new Payment(debtor, debtorAmountTextbox.Value, _bill.Transaction, true);
                    debtorListBox.Items.Add(newPayment);
                    ResetDebtorInformation();
                    payeeComboBox.Refresh();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("No user is selected");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void payeeRemoveButton_Click(object sender, EventArgs e)
        {
            if (payeeListBox.SelectedItem != null)
            {
                payeeListBox.Items.Remove(payeeListBox.SelectedItem);
            }
        }

        private void debtorRemoveButton_Click(object sender, EventArgs e)
        {
            if (debtorListBox.SelectedItem != null)
            {
                debtorListBox.Items.Remove(debtorListBox.SelectedItem);
            }
        }

        private void submitBillButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateAmount();

                UpdateTransaction();

                _bill.Transaction.TransactionId = SQL.TransactionSQLAccess.AddTransaction(_bill.Transaction);

                foreach (Payment payment in Payments)
                {
                    SQL.PaymentSQLAccess.AddPayment(payment);
                }

                foreach (Payment debt in Debts)
                {
                    SQL.PaymentSQLAccess.AddPayment(debt);
                }

                DialogResult choice = MessageBox.Show("Do you want to enter another transaction?", "Transaction", MessageBoxButtons.YesNo);
                if (choice.Equals(DialogResult.Yes))
                {
                    Initialize();
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearBillButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        #endregion

        #region Private Properties

        private Payment[] Payments
        {
            get
            {
                Payment[] payments = new Payment[payeeListBox.Items.Count];

                for(int index = 0; index < payeeListBox.Items.Count; index++)
                {
                    Object obj = payeeListBox.Items[index];
                    if (!(obj is Payment))
                    {
                        throw new ArgumentOutOfRangeException(obj.ToString());
                    }

                    Payment payment = obj as Payment;
                    payments[index] = payment;
                }
                return payments;
            }
        }

        private Payment[] Debts
        {
            get
            {
                Payment[] debts = new Payment[debtorListBox.Items.Count];

                for (int index = 0; index < debtorListBox.Items.Count; index++)
                {
                    Object obj = debtorListBox.Items[index];
                    if (!(obj is Payment))
                    {
                        throw new ArgumentOutOfRangeException(obj.ToString());
                    }

                    Payment debt = obj as Payment;
                    debts[index] = debt;
                }
                return debts;
            }
        }

        #endregion

        #region Private Fields

        private Bill _bill = null;

        #endregion
    }
}