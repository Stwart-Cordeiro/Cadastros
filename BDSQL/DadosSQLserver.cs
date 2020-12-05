using System;
using System.Data;
using System.Data.SqlClient;
using BDSQL.Properties;

namespace BDSQL
{
    public class DadosSQLserver
    {
        private SqlConnection objconn()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        private SqlParameterCollection _sql = new SqlCommand().Parameters;

        public void limpaparametros()
        {
            _sql.Clear();
        }

        public void adicionarParametros(string nomeparametro, object valorparametro)
        {
            _sql.Add(new SqlParameter(nomeparametro, valorparametro));
        }

        public object executar(CommandType objcmtype, string sp_procedures)
        {
            try
            {
                SqlConnection sqlconn = objconn();
                sqlconn.Open();
                SqlCommand sqlcomand = sqlconn.CreateCommand();
                sqlcomand.CommandType = objcmtype;
                sqlcomand.CommandText = sp_procedures;
                sqlcomand.CommandTimeout = 7000;

                foreach (SqlParameter sqlparamet in _sql)
                {
                    sqlcomand.Parameters.Add(new SqlParameter(sqlparamet.ParameterName, sqlparamet.Value));
                }
                return sqlcomand.ExecuteScalar();
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public DataTable executconsulta(CommandType objcmtype, string sp_procedures)
        {
            try
            {
                SqlConnection sqlconn = objconn();
                sqlconn.Open();
                SqlCommand sqlcomand = sqlconn.CreateCommand();
                sqlcomand.CommandType = objcmtype;
                sqlcomand.CommandText = sp_procedures;
                sqlcomand.CommandTimeout = 7000;

                foreach (SqlParameter sqlparamet in _sql)
                {
                    sqlcomand.Parameters.Add(new SqlParameter(sqlparamet.ParameterName, sqlparamet.Value));
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomand);
                DataTable data = new DataTable();
                sqlDataAdapter.Fill(data);
                return data;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
