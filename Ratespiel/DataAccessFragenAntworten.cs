using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
    class DataAccessFragenAntworten : IDataAccessFragenAntworten
    {
        public string getConnectionString()
        {
            string str = "Server:localhost;Port=3307;Database=Ratespiel;Uid=root;Pwd=pa$$w0rd;Charset=UTF8;";

            return str;
        }

        public int Count()
        {
            int count = 0;

            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select count(*) from Spiel";
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

        public int Create(FragenAntworten fragenAntworten)
        {
            int id = 0;

            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Insert into FragenAntowrten (frage, antwort1, antwort2, antwort3, antwort4, richtigeAntwort, schwierigkeit) " +
                                          "values (@frage, @antwort1, @antwort2, @antwort3, @antwort4, @richtigeAntwort, @schwierigkeit)";


                    command.Parameters.AddWithValue("@frage", fragenAntworten.Frage);
                    command.Parameters.AddWithValue("@antwort1", fragenAntworten.Antwort1);
                    command.Parameters.AddWithValue("@antwort2", fragenAntworten.Antwort2);
                    command.Parameters.AddWithValue("@antwort3", fragenAntworten.Antwort3);
                    command.Parameters.AddWithValue("@antwort4", fragenAntworten.Antwort4);
                    command.Parameters.AddWithValue("@richtigeAntwort", fragenAntworten.RichtigeAntwort);
                    command.Parameters.AddWithValue("@schwierigkeit", fragenAntworten.Schwierigkeit);

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

            return id;
        }

        public void Delete(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Delete from FragenAntworten where id = @id";
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
            }
        }

        public int MaxID()
        {
            int id = 0;

            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select ID from FragenAntworten order by Id desc Limit 0, 1";
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

        public List<FragenAntworten> ReadALL()
        {
            List<FragenAntworten> lstfragenAntworten = new List<FragenAntworten>();
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select * from FragenAntworten;";
                    try
                    {
                        connection.Open();

                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                FragenAntworten fragenAntworten = new FragenAntworten();
                                fragenAntworten.Id = reader.GetInt32("Id");
                                fragenAntworten.Frage = reader.IsDBNull(1) ? "" : reader.GetString("Frage");
                                fragenAntworten.Antwort1 = reader.IsDBNull(2) ? "" : reader.GetString("Antwort1");
                                fragenAntworten.Antwort2 = reader.IsDBNull(3) ? "" : reader.GetString("Antwort2");
                                fragenAntworten.Antwort3 = reader.IsDBNull(4) ? "" : reader.GetString("Antwort3");
                                fragenAntworten.Antwort4 = reader.IsDBNull(4) ? "" : reader.GetString("Antwort4");
                                fragenAntworten.RichtigeAntwort = reader.IsDBNull(4) ? 0 : reader.GetInt32("RichtigeAntwort");
                                fragenAntworten.Schwierigkeit = reader.IsDBNull(4) ? 0 : reader.GetInt32("Schwierigkeit");
                                lstfragenAntworten.Add(fragenAntworten);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Fehler! " + ex);
                    }
                }
            }
            return lstfragenAntworten;
        }

        public void Update(FragenAntworten fragenAntworten)
        {
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Update User set frage = @frage, antwort1 = @antwort1, antwort2 = @antwort2, antwort3 = @antwort3, antwort4 = @antwort4, richtigeAntwort = @richtigeAntwort, schwierigkeit = @schwierigkeit where Id = @Id";
                    command.Parameters.AddWithValue("@id", fragenAntworten.Id);
                    command.Parameters.AddWithValue("@frage", fragenAntworten.Frage);
                    command.Parameters.AddWithValue("@antwort1", fragenAntworten.Antwort1);
                    command.Parameters.AddWithValue("@antwort2", fragenAntworten.Antwort2);
                    command.Parameters.AddWithValue("@antwort3", fragenAntworten.Antwort3);
                    command.Parameters.AddWithValue("@antwort4", fragenAntworten.Antwort4);
                    command.Parameters.AddWithValue("@richtigeAntwort", fragenAntworten.RichtigeAntwort);
                    command.Parameters.AddWithValue("@schwierigkeit", fragenAntworten.Schwierigkeit);

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
