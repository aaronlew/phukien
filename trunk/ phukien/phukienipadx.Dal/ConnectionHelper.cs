using System.Configuration;
using System.Data.SqlClient;

namespace phukienipadx.Dal
{
    public class ConnectionHelper
    {
        public static string ConnectionString =
            ConfigurationManager.ConnectionStrings["ApplicationConnection"].ConnectionString;

        public static bool CheckDatabases()
        {
            bool result = false;

            try
            {
                using (var entity = new Entities(ConnectionString))
                {
                    result = entity.DatabaseExists();
                }
            }
            catch (SqlException)
            {
                //throw;
            }
            return result;
        }
    }
}