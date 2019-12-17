using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
    public class DataAccessSpielAntwort : DataAccess<SpielAntwort>, IDataAccessSpielAntwort
    {
        public DataAccessSpielAntwort()
        {
            Parameters.Add("id", new MySqlParameter("@id", MySqlDbType.Int32));
            Parameters.Add("spielnr", new MySqlParameter("@spielnr", MySqlDbType.Int32));
            Parameters.Add("fuaid", new MySqlParameter("@fuaid", MySqlDbType.Int32));
            Parameters.Add("gepruefteantwort", new MySqlParameter("@gepruefteantwort", MySqlDbType.Int32));
        }

        public override int Count()
        {
            string strSql = "select count(*) from spielantwort";
            object o = DBExecuteScalar(strSql);
            int nCount = Convert.ToInt32(o);
            return nCount;
        }

        public override int Create(SpielAntwort t)
        {
            string strSql = "Insert into spielantwort (spielnr, fuaid, gepruefteantwort) values (@spielnr, @fuaid, @gepruefteantwort)";
            SetParameterValues(t);
            return DBExecuteNonQuery(strSql, Parameters.Values);
        }

        public override void Delete(int id)
        {
            string strSql = "Delete from spielantwort where id = @id";
            Parameters["id"].Value = id;
            DBExecuteNonQuery(strSql, Parameters.Values);
        }

        public override int MaxId()
        {
            string strSql = "select max(id) from spielantwort";
            object o = DBExecuteScalar(strSql);
            int nMaxid = Convert.ToInt32(o);
            return nMaxid;
        }

        public override List<SpielAntwort> ReadAll()
        {
            string strSql = "Select * from spielantwort order by id;";
            List<SpielAntwort> lst = DBExecuteQuery(strSql);
            return lst;
        }

        public override void Update(SpielAntwort t)
        {
            string strSql = "Update spielantwort set spielnr = @spielnr, fuaid = @fuaid, gepruefteantwort = @gepruefteantwort where Id = @Id";
            SetParameterValues(t);
            DBExecuteNonQuery(strSql, Parameters.Values);
        }

        protected override void CreateDataInstance(MySqlDataReader reader, SpielAntwort t)
        {
            t.Id = reader.GetInt32(0);
            t.Spielnr = CheckDBNullInt(reader, 1);
            t.Fuaid = CheckDBNullInt(reader, 2);
            t.GepruefteAntwort = CheckDBNullInt(reader, 3);
        }

        protected override void SetParameterValues(SpielAntwort t)
        {
            Parameters["id"].Value = t.Id;
            Parameters["spielnr"].Value = t.Spielnr;
            Parameters["fuaid"].Value = t.Fuaid;
            Parameters["gepruefteantwort"].Value = t.GepruefteAntwort;
        }
    }
}
