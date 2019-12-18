using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
    public class DataAccessBestenliste : DataAccess<Bestenliste>, IDataAccessBestenliste
    {
        public DataAccessBestenliste()
        {
            Parameters.Add("id", new MySqlParameter("@id", MySqlDbType.Int32));
            Parameters.Add("spielnr", new MySqlParameter("@spielnr", MySqlDbType.Int32));
            Parameters.Add("username", new MySqlParameter("@username", MySqlDbType.String));
            Parameters.Add("score", new MySqlParameter("@score", MySqlDbType.Int32));
            Parameters.Add("datum", new MySqlParameter("@datum", MySqlDbType.DateTime));
        }

        public override int Count()
        {
            throw new NotImplementedException();
        }

        public override int Create(Bestenliste t)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bestenliste> getTopTen()
        {
            string strSql = "Select A.id, A.Spielnr, B.username, A.score, A.Datum from Spiel A join User B on A.userid = B.id order by Score DESC LIMIT 10";
            List<Bestenliste> lst = DBExecuteQuery(strSql);
            return lst;
        }

        public override int MaxId()
        {
            throw new NotImplementedException();
        }

        public override List<Bestenliste> ReadAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(Bestenliste t)
        {
            throw new NotImplementedException();
        }

        protected override void CreateDataInstance(MySqlDataReader reader, Bestenliste t)
        {
            t.Id = reader.GetInt32(0);
            t.Spielnr = CheckDBNullInt(reader, 1);
            t.Username = CheckDBNullString(reader, 2);
            t.Score = CheckDBNullInt(reader, 3);
            t.Datum = CheckDBNullDateTime(reader, 4);
        }

        protected override void SetParameterValues(Bestenliste t)
        {
            Parameters["id"].Value = t.Id;
            Parameters["spielnr"].Value = t.Spielnr;
            Parameters["username"].Value = t.Username;
            Parameters["score"].Value = t.Score;
            Parameters["datum"].Value = t.Datum;
        }
    }
}
