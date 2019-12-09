using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
    class DataAccessUser : IDataAccessUser
    {
        public string getConnectionString()
        {
            string str = "Server=localhost;Port=3307;Database=ratespiel;Uid=root;Pwd=pa$$w0rd;CharSet=UTF8;";

            return str;
        }

        public int Count()
        {
            int count = 0;

            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select count(*) from User";
                    try
                    {
                        connection.Open();

                        count = Convert.ToInt32(command.ExecuteScalar());

                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Fehler! " + ex);
                    }
                }
            }

            return count;
        }

        public int Create(User user)
        {
            int id = 0;

            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Insert into User (username, passwort, vorname, nachname, mail) " +
                                          "values (@username, @passwort, @vorname, @nachname, @mail)";


                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@passwort", user.Passwort);
                    command.Parameters.AddWithValue("@vorname", user.Vorname);
                    command.Parameters.AddWithValue("@nachname", user.Nachname);
                    command.Parameters.AddWithValue("@mail", user.Mail);

                    try
                    {
                        connection.Open();

                        int rows = command.ExecuteNonQuery();
                        id = Convert.ToInt32(command.LastInsertedId);

                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Fehler! " + ex);
                    }
                }
            }

            return user.Id;
        }

        public void Delete(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Delete from Spiel where UserId = @id";
                    command.Parameters.AddWithValue("@id", id);
                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Fehler! " + ex);

                    }
                }

                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Delete from User where id = " + id;
                    try
                    {
                        command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Fehler! " + ex);
                    }
                }
            }
        }

        public int MaxID()
        {
            int id = 0;

            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select ID from User order by Id desc Limit 0, 1";
                    try
                    {
                        connection.Open();

                        id = Convert.ToInt32(command.ExecuteScalar());

                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Fehler! " + ex);
                    }
                }
            }

            return id;
        }

        public List<User> ReadALL()
        {
            List<User> lstUser = new List<User>();
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))

            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Select * from User order by Nachname";
                try
                {
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.Id = reader.GetInt32("Id");
                            user.Username = reader.IsDBNull(1) ? "" : reader.GetString("Username");
                            user.Passwort = reader.IsDBNull(2) ? "" : reader.GetString("Passwort");
                            user.Vorname = reader.IsDBNull(2) ? "" : reader.GetString("Vorname");
                            user.Nachname = reader.IsDBNull(2) ? "" : reader.GetString("Nachname");
                            user.Mail = reader.IsDBNull(3) ? "" : reader.GetString("Mail");
                            lstUser.Add(user);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Fehler! " + ex);
                }

                // Connection.Close() nicht notwendig, da using
            }
            return lstUser;
        }

        public void Update(User user)
        {
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Update User set username = @username, passwort = @passwort, vorname = @vorname, nachname = @nachname, mail = @mail where Id = @Id";
                    command.Parameters.AddWithValue("@id", user.Id);
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@passwort", user.Passwort);
                    command.Parameters.AddWithValue("@vorname", user.Vorname);
                    command.Parameters.AddWithValue("@nachname", user.Nachname);
                    command.Parameters.AddWithValue("@mail", user.Mail);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Fehler! " + ex);
                    }
                }
            }
        }
    }
}
