using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BLT.Components
{
    public partial class AccountViewControl : UserControl
    {
        public AccountViewControl()
        {
            InitializeComponent();
            Initialize(); 
        }

        private void Initialize()
        {
            RefreshGroupBox();
            RefreshDataGrid();
        }

        public override void Refresh()
        {
            RefreshGroupBox();
            RefreshDataGrid();

            base.Refresh();
        }

        private void RefreshGroupBox()
        {
            string name = null;
            if(_user == null)
            {
                name = NO_USER;
            }
            else
            {
                name = _user.DisplayName;
            }

            accountGroupBox.Text = name;
        }

        public void RefreshDataGrid()
        {
            if (_user != null)
            {
                _payments = SQL.PaymentSQLAccess.GetPayments(_user);

                accountInfoDataGrid.Rows.Clear();

                Decimal totalAmount = Decimal.Zero;
                foreach (Payment payment in _payments)
                {
                    accountInfoDataGrid.Rows.Add(
                        new object[] { payment.Transaction.TransactionId, 
                            payment.Transaction.Description, payment.Transaction.Date, 
                            payment.Amount });
                    totalAmount = Decimal.Add(totalAmount, payment.Amount);
                }
                totalAmount = Decimal.Round(totalAmount, Constants.DECIMAL_POINT_PRECISION);
                amountLabel.Text = totalAmount.ToString();
            }
        }

        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                /*
                if (value == null)
                {
                    throw new ArgumentNullException("user");
                }
                 */
                _user = value;
                RefreshDataGrid();
            }
        }

        private User _user = null;
        private List<Payment> _payments = new List<Payment>();
        private static string NO_USER = "No User";
    }
}
