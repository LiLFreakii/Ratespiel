using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
    public class DataAccessHighscore : DataAccess<Highscore>, IDataAccessHighscore
    {
        public DataAccessHighscore()
        {
            Parameters.Add("id", new MySqlParameter("@id", MySqlDbType.Int32));
            Parameters.Add("spielnr", new MySqlParameter("@spielnr", MySqlDbType.Int32));
            Parameters.Add("score", new MySqlParameter("@score", MySqlDbType.Int32));
            Parameters.Add("userid", new MySqlParameter("@userid", MySqlDbType.Int32));
            Parameters.Add("datum", new MySqlParameter("@datum", MySqlDbType.DateTime));
        }
        public override int Count()
        {
            throw new NotImplementedException();
        }

        public override int Create(Highscore t)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Highscore> getHighscore(int id)
        {
            string strSql = "Select * from Spiel where userid = @userid";
            Parameters["userid"].Value = id;
            List<Highscore> lst = DBExecuteQuery(strSql, Parameters.Values);
            return lst;
        }

        public override int MaxId()
        {
            throw new NotImplementedException();
        }

        public override List<Highscore> ReadAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(Highscore t)
        {
            throw new NotImplementedException();
        }

        protected override void CreateDataInstance(MySqlDataReader reader, Highscore t)
        {
            t.Id = reader.GetInt32(0);
            t.Spielnr = CheckDBNullInt(reader, 1);
            t.UserId = CheckDBNullInt(reader, 2);
            t.Score = CheckDBNullInt(reader, 3);
            t.Datum = CheckDBNullDateTime(reader, 4);
        }

        protected override void SetParameterValues(Highscore t)
        {
            Parameters["id"].Value = t.Id;
            Parameters["spielnr"].Value = t.Spielnr;
            Parameters["userid"].Value = t.UserId;
            Parameters["score"].Value = t.Score;
            Parameters["datum"].Value = t.Datum;
        }
    }
}
