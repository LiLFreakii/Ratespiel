using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
   public class DataAccessKategorie : DataAccess<Kategorie>, IDataAccessKategorie
    {
        public DataAccessKategorie()
        {
            Parameters.Add("id", new MySqlParameter("@id", MySqlDbType.Int32));
            Parameters.Add("Kategorie", new MySqlParameter("@Kategorie", MySqlDbType.String));
        }
        public override int Count()
        {
            string strSql = "select count(*) from kategorie";
            object o = DBExecuteScalar(strSql);
            int nCount = Convert.ToInt32(o);
            return nCount;
        }

        public override int Create(Kategorie t)
        {
            string strSql = "Insert into kategorie (kategorie) " +
                                         "values (@kategorie)";

            SetParameterValues(t);
            return DBExecuteNonQuery(strSql, Parameters.Values);
        }

        public override void Delete(int id)
        {
            string strSql = "Delete from kategorie where id = @id";
            Parameters["id"].Value = id;
            DBExecuteNonQuery(strSql, Parameters.Values);
        }

        public override int MaxId()
        {
            string strSql = "select max(id) from kategorie";
            object o = DBExecuteScalar(strSql);
            int nMaxid = Convert.ToInt32(o);
            return nMaxid;
        }

        public override List<Kategorie> ReadAll()
        {
            string strSql = "Select * from kategorie order by id;";
            List<Kategorie> lst = DBExecuteQuery(strSql);
            return lst;
        }

        public override void Update(Kategorie t)
        {
            string strSql = "Update kategorie set kategorie = @kategorie where Id = @Id";
            SetParameterValues(t);
            DBExecuteNonQuery(strSql, Parameters.Values);
        }

        protected override void CreateDataInstance(MySqlDataReader reader, Kategorie t)
        {
            t.id = reader.GetInt32(0);
            t.kategorie = CheckDBNullString(reader, 1);
        }

        protected override void SetParameterValues(Kategorie t)
        {
            Parameters["id"].Value = t.id;
            Parameters["kategorie"].Value = t.kategorie;
        }
    }
}
