using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
    class DataAccessSpiel : DataAccess<Spiel>, IDataAccessSpiel
    {
        public DataAccessSpiel()
        {
            Parameters.Add("id", new MySqlParameter("@id", MySqlDbType.Int32));
            Parameters.Add("spielnr", new MySqlParameter("@spielnr", MySqlDbType.Int32));
            Parameters.Add("score", new MySqlParameter("@score", MySqlDbType.Int32));
            Parameters.Add("userid", new MySqlParameter("@userid", MySqlDbType.Int32));
            Parameters.Add("fuaid", new MySqlParameter("@fuaid", MySqlDbType.Int32));
            Parameters.Add("datum", new MySqlParameter("@datum", MySqlDbType.Date));
        }

        public override int Count()
        {
            string strSql = "select count(*) from spiel";
            object o = DBExecuteScalar(strSql);
            int nCount = Convert.ToInt32(o);
            return nCount;
        }

        public override int Create(Spiel t)
        {
            string strSql = "Insert into spiel (spielnr, score, userid, fuaid, datum) " +
                                          "values (@spielnr, @score, @userid, @fuaid, @datum)";

            SetParameterValues(t);
            return DBExecuteNonQuery(strSql, Parameters.Values);
        }

        public override void Delete(int id)
        {
            string strSql = "Delete from Spiel where id = @id";
            Parameters["id"].Value = id;
            DBExecuteNonQuery(strSql, Parameters.Values);
        }

        public override int MaxId()
        {
            string strSql = "select max(id) from spiel";
            object o = DBExecuteScalar(strSql);
            int nMaxid = Convert.ToInt32(o);
            return nMaxid;
        }

        public override List<Spiel> ReadAll()
        {
            string strSql = "Select * from Spiel order by id;";
            List<Spiel> lst = DBExecuteQuery(strSql);
            return lst;
        }

        public override void Update(Spiel t)
        {
            string strSql = "Update User set spielnr = @spielnr, score = @score, userid = @userid, fuaid = @fuaid, datum = @datum where Id = @Id";
            SetParameterValues(t);
            DBExecuteNonQuery(strSql, Parameters.Values);
        }

        public List<Spiel> getHighscore(Spiel t)
        {
            string strSql = "Select * from Spiel where userid = @userid";
            SetParameterValues(t);
            List<Spiel> lst = DBExecuteQuery(strSql, Parameters.Values);
            return lst;
        }

        public List<Spiel> getTopTen(Spiel t)
        {
            string strSql = "Select * from Spiel WHERE rownum <= 10 order by Score desc";
            SetParameterValues(t);
            List<Spiel> lst = DBExecuteQuery(strSql, Parameters.Values);
            return lst;
        }

        public int getSpielnr()
        {
            string strSql = "select max(spielnr) from spiel";
            object o = DBExecuteScalar(strSql);
            int nSpielnr = Convert.ToInt32(o) + 1;
            return nSpielnr;
        }

        protected override void CreateDataInstance(MySqlDataReader reader, Spiel t)
        {
            t.Id = reader.GetInt32(0);
            t.SpielNr = CheckDBNullInt(reader, 1);
            t.Score = CheckDBNullInt(reader, 2);
            t.UserId = CheckDBNullInt(reader, 3);
            t.FuAId = CheckDBNullInt(reader, 4);
            t.Datum = CheckDBNullDateTime(reader, 5);
        }

        protected override void SetParameterValues(Spiel t)
        {
            Parameters["id"].Value = t.Id;
            Parameters["spielnr"].Value = t.SpielNr;
            Parameters["score"].Value = t.Score;
            Parameters["userid"].Value = t.UserId;
            Parameters["fuaid"].Value = t.FuAId;
            Parameters["datum"].Value = t.Datum;
        }
    }
}
