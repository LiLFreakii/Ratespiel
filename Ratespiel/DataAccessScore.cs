using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
    class DataAccessScore : IDataAccessScore
    {
        public string getConnectionString()
        {
            string str = "Server:localhost;Port=3307;Database=Ratespiel;Uid=root;Pwd=pa$$w0rd;Charset=UTF8;";

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

        public List<Score> ReadALL()
        {
            List<Score> lstScore = new List<Score>();
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Score;";
                    try
                    {
                        connection.Open();

                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Score score = new Score();
                                score.Id = reader.GetInt32("Id");
                                score.SpielId = reader.IsDBNull(1) ? 0 : reader.GetInt32("SpielId");
                                score.Points = reader.IsDBNull(2) ? 0 : reader.GetInt32("Points");
                                score.Datum = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime("Antwort2");
                                lstScore.Add(score);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Fehler! " + ex);
                    }
                }
            }
            return lstScore;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
