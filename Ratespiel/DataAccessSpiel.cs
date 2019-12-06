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
            string str = "Server:localhost;Port=3306;Database=Ratespiel;Uid=root;Pwd=pa$$w0rd;Charset=UTF8;";

            return str;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int MaxID()
        {
            throw new NotImplementedException();
        }

        public List<Spiel> ReadAll()
        {
            List<Spiel> lstSpiel = new List<Spiel>();
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Spiel;";
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

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
