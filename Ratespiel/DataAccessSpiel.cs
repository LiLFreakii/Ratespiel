using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
    class DataAccessSpiel : IDataAccessSpiel
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

        public int Create(Spiel spiel)
        {
            int id = 0;

            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Insert into FragenAntowrten (spielnr, score, userid, fuaid, datum) " +
                                          "values (@spielnr, @score, @userid, @fuaid, @datum)";


                    command.Parameters.AddWithValue("@spielnr", spiel.SpielNr);
                    command.Parameters.AddWithValue("@score", spiel.Score);
                    command.Parameters.AddWithValue("@userid", spiel.UserId);
                    command.Parameters.AddWithValue("@fuaid", spiel.FuAId);
                    command.Parameters.AddWithValue("@datum", spiel.Datum);

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
                    command.CommandText = "Delete from Spiel where id = @id";
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
                    command.CommandText = "Select ID from Spiel order by Id desc Limit 0, 1";
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

        public List<Spiel> ReadAll()
        {
            List<Spiel> lstSpiel = new List<Spiel>();
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select * from Spiel;";
                    try
                    {
                        connection.Open();

                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Spiel spiel = new Spiel();
                                spiel.Id = reader.GetInt32("Id");
                                spiel.SpielNr = reader.IsDBNull(1) ? 0 : reader.GetInt32("SpielNr");
                                spiel.UserId = reader.IsDBNull(1) ? 0 : reader.GetInt32("UserId");
                                spiel.FuAId = reader.IsDBNull(1) ? 0 : reader.GetInt32("FuAId");
                                spiel.Score = reader.IsDBNull(1) ? 0 : reader.GetInt32("Score");
                                lstSpiel.Add(spiel);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Fehler! " + ex);
                    }
                }
            }
            return lstSpiel;
        }

        public void Update(Spiel spiel)
        {
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Update User set spielnr = @spielnr, score = @score, userid = @userid, fuaid = @fuaid, datum = @datum where Id = @Id";
                    command.Parameters.AddWithValue("@id", spiel.Id);
                    command.Parameters.AddWithValue("@spielnr", spiel.SpielNr);
                    command.Parameters.AddWithValue("@score", spiel.Score);
                    command.Parameters.AddWithValue("@userid", spiel.UserId);
                    command.Parameters.AddWithValue("@fuaid", spiel.FuAId);
                    command.Parameters.AddWithValue("@datum", spiel.Datum);

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
