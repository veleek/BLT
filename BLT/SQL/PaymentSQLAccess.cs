using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace BLT.SQL
{
    public class PaymentSQLAccess
    {
        #region Public Static Methods

        public static List<Payment> GetAllPayments()
        {
            List<Payment> payments = new List<Payment>();

            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select userid, tid, amount from payment";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            int transactionId = reader.GetInt32(1);
                            Decimal amount = reader.GetDecimal(2);
                            bool isDebt = (amount < 0);

                            User user = UserSQLAccess.GetUser(userId);
                            Transaction transaction = TransactionSQLAccess.GetTransaction(transactionId);
                            Payment payment = new Payment(user, amount, transaction, isDebt);

                            payments.Add(payment);
                        }
                    }
                }
            }

            return payments;
        }

        public static List<Payment> GetPayments(User user)
        {
            List<User> users = new List<User>(1);
            users.Add(user);
            return GetPayments(users);
        }

        public static List<Payment> GetPayments(IList<User> users)
        {
            List<Payment> payments = new List<Payment>();

            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    StringBuilder cmdText = new StringBuilder();
                    foreach (User currentUser in users)
                    {
                        if(cmdText.Length > 0)
                        {
                            cmdText.Append(" or ");
                        }
                        cmdText.Append(String.Format(" userid = {0}", currentUser.ID));
                    }
                    cmdText.Insert(0, "select userid, tid, amount from payment where");

                    cmd.CommandText = cmdText.ToString();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            int tid = reader.GetInt32(1);
                            Decimal amount = reader.GetDecimal(2);
                            bool isDebt = (amount < 0);

                            User user = UserSQLAccess.GetUser(userId);
                            Transaction transaction = TransactionSQLAccess.GetTransaction(tid);
                            Payment payment = new Payment(user, amount, transaction, isDebt);

                            payments.Add(payment);
                        }
                    }
                }
            }

            return payments;
        }

        public static List<Payment> GetPayments(Int32 transactionID)
        {
            List<Payment> payments = new List<Payment>();
            Transaction t = TransactionSQLAccess.GetTransaction(transactionID);

            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select userid, amount from payment where tid=?tid";
                    cmd.Parameters.Add("?tid", MySqlDbType.Int32).Value = transactionID;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            Decimal amount = reader.GetDecimal(1);
                            bool isDebt = (amount < 0);

                            User user = UserSQLAccess.GetUser(userId);
                            Payment payment = new Payment(user, amount, t, isDebt);

                            payments.Add(payment);
                        }
                    }
                }
            }

            return payments;
        }

        public static void AddPayment(Payment payment)
        {
            if (payment == null)
            {
                throw new ArgumentNullException("payment");
            }

            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "insert into payment (userid, tid, amount) values (?userid, ?tid, ?amount)";
                        cmd.Parameters.Add("?userid", MySqlDbType.Int32).Value = payment.User.ID;
                        cmd.Parameters.Add("?tid", MySqlDbType.Int32).Value = payment.Transaction.TransactionId;
                        cmd.Parameters.Add("?amount", MySqlDbType.Decimal).Value = payment.Amount;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
        }

        public static void UpdateAmount(Payment payment)
        {
            if (payment == null)
            {
                throw new ArgumentNullException("payment");
            }

            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "update payment set amount = ?amount where userid = ?userid and tid = ?tid";
                        cmd.Parameters.Add("?amount", MySqlDbType.Decimal).Value = payment.Amount;
                        cmd.Parameters.Add("?userid", MySqlDbType.Int32).Value = payment.User.ID;
                        cmd.Parameters.Add("?tid", MySqlDbType.Int32).Value = payment.Transaction.TransactionId;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
        }

        #endregion
    }
}
