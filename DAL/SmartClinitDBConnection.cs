using System.Data.SqlClient;

namespace SmartClinic.DAL
{
    /// <summary>
    /// Get a connection object. 
    /// </summary>
    public class SmartClinicDBConnection
    {
        /// <summary>
        /// It returns a SQL connection to the cs6232-g1 DB.
        /// </summary>
        /// <returns>A SQL connection</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=cs6232-g1;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
