using MySql.Data.MySqlClient;

public static class DbHelper
{
    public static MySqlConnection GetConnection()
    {
        string connectionString = "server=localhost;user=root;password='';database=SampleDB";
        return new MySqlConnection(connectionString);
    }
}
