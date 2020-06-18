using System;
using System.Collections.Generic;
using System.Text;

namespace BLT
{
    public class Transaction
    {
        #region Constructors

        public Transaction(Decimal amount, DateTime time)
            : this(amount, time, Constants.DEFAULT_TRANSACTION_ID, String.Empty)
        { }


        public Transaction(Decimal amount, DateTime time, string description)
            : this(amount, time, Constants.DEFAULT_TRANSACTION_ID, String.Empty)
        { }

        public Transaction(Decimal amount, DateTime time, int transactionId, string description)
        {
            if (description == null)
            {
                throw new ArgumentNullException();
            }

            _amount = amount;
            _date = time;
            _transactionId = transactionId;
            _description = description;
        }

        #endregion

        #region Public Methods

        public override bool Equals(object obj)
        {
            if (obj is Transaction)
            {
                return Equals(obj as Transaction);
            }

            return false;
        }

        public bool Equals(Transaction otherTransaction)
        {
            return (_amount.Equals(otherTransaction._amount)) 
                && (_date.Equals(otherTransaction._date)) 
                && (_transactionId == otherTransaction._transactionId) 
                && (_description.Equals(otherTransaction._description));
        }

        public override int GetHashCode()
        {
            int rc = 11 + GetType().GetHashCode();
            rc = +(71 * _transactionId);
            rc = +(53 * _date.GetHashCode());
            rc = +(97 * _amount.GetHashCode());
            rc = +(77 * ((_description == null) ? 57 : _description.GetHashCode()));

            return rc;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} - {2} ({3})", 
                _amount.ToString(), _description, 
                _date.ToString(), _transactionId.ToString() );
        }

        #endregion

        #region Public Properties

        public Decimal Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        public int TransactionId
        {
            get
            {
                return _transactionId;
            }
            set
            {
                _transactionId = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                _description = value;
            }
        }

        #endregion

        #region Private Fields

        private Decimal _amount = Decimal.Zero;
        private DateTime _date = DateTime.MinValue;
        private int _transactionId = Int32.MinValue;
        private string _description = null;

        #endregion
    }
}
