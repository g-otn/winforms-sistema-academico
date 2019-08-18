using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SistemaAcademico.util
{
    class ConectaDB
    {
        private const string serverName =   "localhost";
        private const string port =         "5432"; 
        private const string userName =     "postgres";
        private const string password =     "";
        private const string dataBaseName = "SistemaAcademico";

        public static NpgsqlConnection getConexao()
        {
            try
            {
                string stgConexao = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                    serverName, port, userName, password, dataBaseName);

                NpgsqlConnection npsqlConnection = new NpgsqlConnection(stgConexao);

                npsqlConnection.Open();

                return npsqlConnection;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
