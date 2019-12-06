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
            throw new NotImplementedException();
        }

        public int Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Delete from FragenAntworten where id = " + id;
                    try
                    {
                        connection.Open();

                        MySqlDataReader reader = command.ExecuteReader();
                        
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
            throw new NotImplementedException();
        }

        public List<FragenAntworten> ReadALL()
        {
            List<FragenAntworten> lstfragenAntworten = new List<FragenAntworten>();
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM FragenAntworten;";
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

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
