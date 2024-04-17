using System.Data;
using System.Data.SqlClient;

namespace ConsolaAPi.Model
{
    internal class ConexionManager
    {
        public string sqlConnectionString;

        public ConexionManager(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }

        // Métodos para abrir y cerrar conexiones para SQL Server
        public SqlConnection AbrirConexionSQLServer()
        {
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión SQL Server: " + ex.Message);
                return null;
            }
        }

        public void CerrarConexionSQLServer(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Conexión SQL Server cerrada correctamente.");
            }
        }
    }
}
