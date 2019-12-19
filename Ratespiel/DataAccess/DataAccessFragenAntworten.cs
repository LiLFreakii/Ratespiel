using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
    public class DataAccessFragenAntworten : DataAccess<FragenAntworten>, IDataAccessFragenAntworten
    {
        public DataAccessFragenAntworten()
        {
            Parameters.Add("id", new MySqlParameter("@id", MySqlDbType.Int32));
            Parameters.Add("frage", new MySqlParameter("@frage", MySqlDbType.String));
            Parameters.Add("antwort1", new MySqlParameter("@antwort1", MySqlDbType.String));
            Parameters.Add("antwort2", new MySqlParameter("@antwort2", MySqlDbType.String));
            Parameters.Add("antwort3", new MySqlParameter("@antwort3", MySqlDbType.String));
            Parameters.Add("antwort4", new MySqlParameter("@antwort4", MySqlDbType.String));
            Parameters.Add("richigeAntwort", new MySqlParameter("@richigeAntwort", MySqlDbType.Int32));
            Parameters.Add("schwierigkeit", new MySqlParameter("@schwierigkeit", MySqlDbType.Int32));
            Parameters.Add("kategorieid", new MySqlParameter("@kategorieid", MySqlDbType.Int32));
        }

        public override int Count()
        {
            string strSql = "select count(*) from fragenantworten";
            object o = DBExecuteScalar(strSql);
            int nCount = Convert.ToInt32(o);
            return nCount;
        }

        public override int Create(FragenAntworten t)
        {
            string strSql = "Insert into FragenAntowrten (frage, antwort1, antwort2, antwort3, antwort4, richtigeantwort, schwierigkeit, kategorieid) " +
                            "values (@frage, @antwort1, @antwort2, @antwort3, @antwort4, @richtigeantwort, @schwierigkeit, @kategorieid)";

            SetParameterValues(t);
            return DBExecuteNonQuery(strSql, Parameters.Values);
        }

        public override void Delete(int id)
        {
            string strSql = "Delete from fragenantworten where id = @id";
            Parameters["id"].Value = id;
            DBExecuteNonQuery(strSql, Parameters.Values);
        }

        public override int MaxId()
        {
            string strSql = "select max(id) from fragenantworten";
            object o = DBExecuteScalar(strSql);
            int nMaxid = Convert.ToInt32(o);
            return nMaxid;
        }

        public override List<FragenAntworten> ReadAll()
        {
            string strSql = "Select * from fragenantworten order by id;";
            List<FragenAntworten> lst = DBExecuteQuery(strSql);
            return lst;
        }

        public List<FragenAntworten> getQuestion(int nId)
        {
            string strSql = "Select * from fragenantworten where kategorieId = @id";
            Parameters["id"].Value = nId;
            List<FragenAntworten> lst = DBExecuteQuery(strSql);
            return lst;
        }

        public override void Update(FragenAntworten t)
        {
            string strSql = "Update fragenantworten set frage = @frage, antwort1 = @antwort1, antwort2 = @antwort2, antwort3 = @antwort3, antwort4 = @antwort4, " +
                            "richtigeAntwort = @richtigeAntwort, schwierigkeit = @schwierigkeit, kategorieid = @kategorieid where Id = @Id";
            SetParameterValues(t);
            DBExecuteNonQuery(strSql, Parameters.Values);
        }

        protected override void CreateDataInstance(MySqlDataReader reader, FragenAntworten t)
        {
            t.Id = reader.GetInt32(0);
            t.Frage = CheckDBNullString(reader, 1);
            t.Antwort1 = CheckDBNullString(reader, 2);
            t.Antwort2 = CheckDBNullString(reader, 3);
            t.Antwort3 = CheckDBNullString(reader, 4);
            t.Antwort4 = CheckDBNullString(reader, 5);
            t.RichtigeAntwort = CheckDBNullInt(reader, 6);
            t.Schwierigkeit = CheckDBNullInt(reader, 7);
            t.KategorieId = CheckDBNullInt(reader, 8);
        }

        protected override void SetParameterValues(FragenAntworten t)
        {
            Parameters["id"].Value = t.Id;
            Parameters["frage"].Value = t.Frage;
            Parameters["antwort1"].Value = t.Antwort1;
            Parameters["antwort2"].Value = t.Antwort2;
            Parameters["antwort3"].Value = t.Antwort3;
            Parameters["antwort4"].Value = t.Antwort4;
            Parameters["richtigeAntwort"].Value = t.RichtigeAntwort;
            Parameters["schwierigkeit"].Value = t.Schwierigkeit;
            Parameters["kategorieid"].Value = t.Schwierigkeit;
        }
    }
}
