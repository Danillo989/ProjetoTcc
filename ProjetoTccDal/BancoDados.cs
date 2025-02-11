using System;
using System.Configuration;
using Microsoft.Data.SqlClient;




namespace ProjetoTccDal
{
    public class BancoDados
    {
        private readonly string _connectionString;

        public BancoDados()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
        }


        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}