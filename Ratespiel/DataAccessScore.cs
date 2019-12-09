﻿using System;
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
                    command.CommandText = "Delete from Score where id = @id";
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
                    command.CommandText = "Select ID from Score order by Id desc Limit 0, 1";
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

        public List<Score> ReadALL()
        {
            List<Score> lstScore = new List<Score>();
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select * from Score;";
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
