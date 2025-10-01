using System.Configuration;
using System.Data.SqlClient;

public static class DatabaseHelper
{
    private static readonly string connectionString =
        ConfigurationManager.ConnectionStrings["UserDatabase"].ConnectionString;

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
