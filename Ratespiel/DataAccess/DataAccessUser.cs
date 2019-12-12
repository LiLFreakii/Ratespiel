using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
    class DataAccessUser : DataAccess<User>, IDataAccessUser
    {
        public DataAccessUser()
        {
            Parameters.Add("id", new MySqlParameter("@id", MySqlDbType.Int32));
            Parameters.Add("username", new MySqlParameter("@username", MySqlDbType.String));
            Parameters.Add("passwort", new MySqlParameter("@passwort", MySqlDbType.String));
            Parameters.Add("mail", new MySqlParameter("@mail", MySqlDbType.String));
            Parameters.Add("vorname", new MySqlParameter("@vorname", MySqlDbType.String));
            Parameters.Add("nachname", new MySqlParameter("@nachname", MySqlDbType.String));
        }

        public override int Count()
        {
            string strSql = "select count(*) from User";
            object o = DBExecuteScalar(strSql);
            int nCount = Convert.ToInt32(o);
            return nCount;
        }

        public override int Create(User t)
        {
            string strSql = "Insert into User (username, passwort, mail, vorname, nachname) " +
                                          "values (@username, @passwort, @mail, @vorname, @nachname)";

            SetParameterValues(t);
            return DBExecuteNonQuery(strSql, Parameters.Values);
        }

        public override void Delete(int id)
        {
            string strSql = "Delete from User where id = @id";
            Parameters["id"].Value = id;
            DBExecuteNonQuery(strSql, Parameters.Values);
        }

        public override int MaxId()
        {
            string strSql = "select max(id) from user";
            object o = DBExecuteScalar(strSql);
            int nMaxid = Convert.ToInt32(o);
            return nMaxid;
        }

        public override List<User> ReadAll()
        {
            string strSql = "Select * from Spiel order by id;";
            List<User> lst = DBExecuteQuery(strSql);
            return lst;
        }

        public override void Update(User t)
        {
            string strSql = "Update User set username = @username, passwort = @passwort, mail = @mail, vorname = @vorname, nachname = @nachname where Id = @Id";
            SetParameterValues(t);
            DBExecuteNonQuery(strSql, Parameters.Values);
        }

        protected override void CreateDataInstance(MySqlDataReader reader, User t)
        {
            t.Id = reader.GetInt32(0);
            t.Username = CheckDBNullString(reader, 1);
            t.Passwort = CheckDBNullString(reader, 2);
            t.Mail = CheckDBNullString(reader, 3);
            t.Vorname = CheckDBNullString(reader, 4);
            t.Nachname = CheckDBNullString(reader, 5);
        }

        protected override void SetParameterValues(User t)
        {
            Parameters["id"].Value = t.Id;
            Parameters["username"].Value = t.Username;
            Parameters["passwort"].Value = t.Passwort;
            Parameters["mail"].Value = t.Mail;
            Parameters["vorname"].Value = t.Vorname;
            Parameters["nachname"].Value = t.Nachname;
        }
    }
}
