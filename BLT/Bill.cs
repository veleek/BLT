using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace BLT
{
    public class Bill
    {
        #region Constructors

        public Bill()
            : this(new Transaction(Decimal.Zero, DateTime.Now, String.Empty), new Dictionary<int, Payment>(), new Dictionary<int, Payment>())
        { }

        public Bill(string description, Decimal amount)
            : this(new Transaction( amount, DateTime.Now, description), new Dictionary<int, Payment>(), new Dictionary<int, Payment>())
        { }

        public Bill(string description, Decimal amount, DateTime date)
            : this(new Transaction(amount, date, description), new Dictionary<int, Payment>(), new Dictionary<int, Payment>())
        { }

        public Bill(string description, Decimal amount, DateTime date, Dictionary<int, Payment> payers, Dictionary<int, Payment> debtors)
            : this(new Transaction(amount, date, description), payers, debtors)
        { }

        public Bill(Transaction transaction, Dictionary<int, Payment> payers, Dictionary<int, Payment> debtors)
        {
            _transaction = transaction;

            _payers = payers;
            _debtors = debtors;
        }

        #endregion

        public bool AddPayer(Payment payment)
        {
            int userId = payment.User.ID;
            if (ValidateNewPayment(payment))
            {
                _payers.Add(userId, payment);
                return true;
            }
            return false;
        }

        public bool AddDebtor(Payment payment)
        {
            int userId = payment.User.ID;
            if (ValidateNewPayment(payment))
            {
                _debtors.Add(userId, payment);
                return true;
            }
            return false;
        }

        private bool ValidateNewPayment(Payment payment)
        {
            int userId = payment.User.ID;
            return (!_payers.ContainsKey(userId)) && (!_debtors.ContainsKey(userId));
        }

        #region Public Properties

        public String Description
        {
            get { return _transaction.Description; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("description");
                }
                _transaction.Description = value;
            }
        }

        public DateTime Date
        {
            get { return _transaction.Date; }
            set { _transaction.Date = value; }
        }

        public Decimal Amount
        {
            get { return _transaction.Amount; }
            set { _transaction.Amount = value; }
        }

        public Transaction Transaction
        {
            get { return _transaction; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("transaction");
                }
                _transaction = value;
            }
        }

        public ReadOnlyCollection<Payment> Payers
        {
            get
            {
                return new List<Payment>(_payers.Values).AsReadOnly();
            }
        }

        public ReadOnlyCollection<Payment> Debtors
        {
            get
            {
                return new List<Payment>(_debtors.Values).AsReadOnly();
            }
        }

        public bool IsTransactionSet
        {
            get
            {
                return _transaction != null;
            }
        }

        #endregion

        #region Private Fields

        private Transaction _transaction = null;

        private Dictionary<int, Payment> _payers = null;
        private Dictionary<int, Payment> _debtors = null;

        #endregion
    }
}
