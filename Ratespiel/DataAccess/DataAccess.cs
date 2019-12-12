using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Diagnostics;
using System.Configuration;

namespace Ratespiel
{
    public abstract class DataAccess<T> : IDataAccess<T> where T : new()
    {
        public string ConnectionString { get; protected set; } 
            = Properties.Settings.Default.ConnectionStringMaria;

        public Dictionary<string, MySqlParameter> Parameters { get; protected set; } 
            = new Dictionary<string, MySqlParameter>();

        public abstract List<T> ReadAll();
        public abstract void Delete(int id);
        public abstract int Create(T t);
        public abstract void Update(T t);
        public abstract int Count();
        public abstract int MaxId();

        /// <summary>
        /// Helper function to send non query command to DB
        /// specify sql and parameters
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="parameters"></param>
        protected int DBExecuteNonQuery(string strSql, ICollection<MySqlParameter> parameters)
        {
            int nId = 0;
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            using (MySqlCommand command = new MySqlCommand(strSql, connection))
            {
                try
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters.ToArray<MySqlParameter>());
                    connection.Open();
                    Debug.WriteLine(this + ": " + command.CommandText);

                    // Kommando zum DB-Server senden
                    int n = command.ExecuteNonQuery();
                    nId = (int)command.LastInsertedId;
                    connection.Close();

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(this + ": " + ex);
                }
            }
            return nId;
        }

        /// <summary>
        /// Helper function to send scalar command to DB
        /// specify sql and parameters
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected object DBExecuteScalar(string strSql, ICollection<MySqlParameter> parameters = null)
        {
            object obj = null;
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            using (MySqlCommand command = new MySqlCommand(strSql, connection))
            {
                try
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters.ToArray<MySqlParameter>());
                    connection.Open();
                    Debug.WriteLine(this + ": " + command.CommandText);

                    // Kommando zum DB-Server senden und einen Wert empfangen
                    obj = command.ExecuteScalar();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(this + ": " + ex);
                }
            }
            return obj;
        }

        /// <summary>
        /// Helper function to send query to DB and retrieve data
        /// Specify sql and parameters and implement CreateDataInstance
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected List<T> DBExecuteQuery(string strSql, ICollection<MySqlParameter> parameters = null)
        {
            List<T> lst = new List<T>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand command = new MySqlCommand(strSql, connection))
                {
                    try
                    {
                        if (parameters != null)
                            command.Parameters.AddRange(parameters.ToArray<MySqlParameter>());
                        connection.Open();

                        // Kommando zum DB-Server senden und Daten empfangen
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // zeilenweise auslesen
                                while (reader.Read())
                                {
                                    T t = new T();
                                    CreateDataInstance(reader, t);
                                    lst.Add(t);
                                }
                            }
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(this + ": " + ex);
                    }
                }
            }

            return lst;
        }

        protected abstract void CreateDataInstance(MySqlDataReader reader, T t); //geändert

        protected abstract void SetParameterValues(T t);


        protected int CheckDBNullInt(MySqlDataReader reader, int nCol)
        {
            if (reader.IsDBNull(nCol))
            {
                return 0; // Int32.MinValue
            }
            else
            {
                return reader.GetInt32(nCol);
            }
        }

        protected DateTime CheckDBNullDateTime(MySqlDataReader reader, int nCol)
        {
            if (reader.IsDBNull(nCol))
            {
                return DateTime.MinValue;
            }
            else
            {
                return reader.GetDateTime(nCol);
            }
        }

        protected string CheckDBNullString(MySqlDataReader reader, int nCol)
        {
            if (reader.IsDBNull(nCol))
            {
                return "";
            }
            else
            {
                return reader.GetString(nCol);
            }
        }
    }
}
