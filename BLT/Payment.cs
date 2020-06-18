using System;
using System.Collections.Generic;
using System.Text;

namespace BLT
{
    public class Payment
    {
        #region Constructors

        public Payment(User user, Decimal amount, Transaction transaction, bool isDebt)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }

            if (transaction == null)
            {
                throw new ArgumentNullException("transaction");
            }

            _user = user;
            _transaction = transaction;

            if (isDebt && (amount > 0))
            {
                _amount = Decimal.Negate(amount);
            }
            else
            {
                _amount = amount;
            }
        }

        #endregion

        #region Public Methods

        public override bool Equals(object obj)
        {
            if (obj is Payment)
            {
                return Equals(obj as Payment);
            }

            return false;
        }

        public bool Equals(Payment otherPayment)
        {
            return (_user.Equals(otherPayment._user)) 
                && (_amount.Equals(otherPayment._amount)) 
                && (_transaction.Equals(otherPayment._transaction));
        }

        public override string ToString()
        {
            return String.Format("{0} : {1} : {2}", User.DisplayName, Transaction.TransactionId, Amount);
        }

        public override int GetHashCode()
        {
            int rc = 53 + GetType().GetHashCode();
            rc = +(59 * ((_user == null) ? 91 : _user.GetHashCode()));
            rc = +(61 * _amount.GetHashCode());
            rc = +(73 * ((_transaction == null) ? 83 : _transaction.GetHashCode()));

            return rc;
        }

        #endregion

        #region Public Properties

        public User User
        {
            get
            {
                return _user;
            }
        }

        public Decimal Amount
        {
            get
            {
                return _amount;
            }
        }

        public Transaction Transaction
        {
            get
            {
                return _transaction;
            }
        }

        #endregion

        #region Private Fields

        private User _user = null;
        private Decimal _amount = Decimal.Zero;
        private Transaction _transaction = null;

        #endregion
    }
}
