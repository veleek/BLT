using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace BLT.SQL
{
    public class TransactionSQLAccess
    {
        #region Public Static Methods

        public static List<Transaction> GetAllTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();

            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select tid, description, amount, date from transaction";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int tid = reader.GetInt32(0);
                            string desc = reader.GetString(1);
                            Decimal amount = reader.GetDecimal(2);
                            DateTime date = reader.GetDateTime(3);

                            Transaction tsc = new Transaction(amount, date, tid, desc);
                            transactions.Add(tsc);
                        }
                    }
                }
            }

            return transactions;
        }

        public static Transaction GetTransaction(int transactionId)
        {
            Transaction transaction = null;

            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select tid, description, amount, date from transaction where tid = ?tid";
                    cmd.Parameters.Add("?tid", MySqlDbType.Int32).Value = transactionId;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int tid = reader.GetInt32(0);
                            string description = reader.GetString(1);
                            Decimal amount = reader.GetDecimal(2);
                            DateTime date = reader.GetDateTime(3);

                            transaction = new Transaction(amount, date, tid, description);
                        }
                    }
                }
            }

            return transaction;
        }

        public static int AddTransaction(Transaction transaction)
        {
            if (transaction == null)
            {
                throw new ArgumentNullException("transaction");
            }

            return AddTransaction(transaction.TransactionId, transaction.Description, transaction.Amount, transaction.Date);
        }

        public static int AddTransaction(int transactionId, string description, Decimal amount, DateTime time)
        {
            int newTransactionId = transactionId;
            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();

                if (transactionId == Constants.DEFAULT_TRANSACTION_ID)
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "call GetNextTransactionID(@nextTransactionID)";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "select @nextTransactionID";
                        newTransactionId = Int32.Parse(cmd.ExecuteScalar().ToString());
                    }
                }

                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "insert into transaction (tid, description, amount, date) values (?tid, ?description, ?amount, ?date)";
                        cmd.Parameters.Add("?tid", MySqlDbType.Int32).Value = newTransactionId;
                        cmd.Parameters.AddWithValue("?description", description);
                        cmd.Parameters.Add("?amount", MySqlDbType.Decimal).Value = amount;
                        cmd.Parameters.Add("?date", MySqlDbType.Datetime).Value = time;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
            return newTransactionId;
        }

        public static void UpdateDescription(string description, int transactionId)
        {
            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "update transaction set description = ?description where tid = ?transactionId";
                        cmd.Parameters.AddWithValue("?description", description);
                        cmd.Parameters.Add("?transactionId", MySqlDbType.Int32).Value = transactionId;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
        }

        public static void UpdateAmount(float amount, int transactionId)
        {
            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "update transaction set amount = ?amount where tid = ?transactionId";
                        cmd.Parameters.Add("?amount", MySqlDbType.Decimal).Value = amount;
                        cmd.Parameters.Add("?transactionId", MySqlDbType.Int32).Value = transactionId;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
        }

        public static void UpdateDate(DateTime date, int transactionId)
        {
            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "update transaction set date = ?date where tid = ?transactionId";
                        cmd.Parameters.Add("?date", MySqlDbType.Datetime).Value = date;
                        cmd.Parameters.Add("?transactionId", MySqlDbType.Int32).Value = transactionId;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
        }

        public static void DeleteTransaction(int transactionId)
        {
            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "delete from transaction where transactionId = ?transactionId";
                        cmd.Parameters.Add("?transactionId", MySqlDbType.Int32).Value = transactionId;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
        }

        #endregion
    }
}
