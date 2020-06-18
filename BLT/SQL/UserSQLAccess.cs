using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MySql.Data.MySqlClient;

namespace BLT.SQL
{
    public class UserSQLAccess
    {
        #region Public Static Methods

        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select firstName, lastName, userid from user";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string firstName = reader.GetString(0);
                            string lastName = reader.GetString(1);
                            int id = reader.GetInt32(2);

                            User user = new User(firstName, lastName, id);
                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }

        public static User GetUser(int userId)
        {
            User user = null;

            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select firstName, lastName, userid from user where userid = ?userid";
                    cmd.Parameters.Add("?userid", MySqlDbType.Int16).Value = userId;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader.GetString(0);
                            string lastName = reader.GetString(1);
                            user = new User(firstName, lastName, userId);
                        }
                    }
                }
            }

            return user;
        }

        public static int AddUser(User user)
        {
            return AddUser(user.FirstName, user.LastName, user.ID);
        }

        public static int AddUser(string firstName, string lastName, int userId)
        {
            int newUserId = userId;
            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();

                if (userId == Constants.DEFAULT_USER_ID)
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select GetNextUserID();";
                        newUserId = (int)cmd.ExecuteScalar();

                        /*
                        cmd.CommandText = "select @numUser";
                        newUserId = Int32.Parse(cmd.ExecuteScalar().ToString()) + 1;
                         */
                    }
                }

                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "insert into user (firstName, lastName, userid) values (?firstName, ?lastName, ?userid)";
                        cmd.Parameters.AddWithValue("?firstName", firstName);
                        cmd.Parameters.AddWithValue("?lastName", lastName);
                        cmd.Parameters.Add("?userid", MySqlDbType.Int32).Value = newUserId;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
            return newUserId;
        }

        public static void UpdateFirstName(string firstName, int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "update user set firstName = ?firstName where userid = ?userid";
                        cmd.Parameters.AddWithValue("?firstName", firstName);
                        cmd.Parameters.Add("?userid", MySqlDbType.Int32).Value = userId;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
        }

        public static void UpdateLastName(string lastName, int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "update user set lastName = ?lastName where userid = ?userid";
                        cmd.Parameters.AddWithValue("?lastName", lastName);
                        cmd.Parameters.Add("?userid", MySqlDbType.Int32).Value = userId;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
        }

        public static void DeleteUser(int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(SQLConstants.CONNECTION_STRING))
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "delete from user where userid = ?userid";
                        cmd.Parameters.Add("?userid", MySqlDbType.Int32).Value = userId;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
        }

        #endregion
    }
}
