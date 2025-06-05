using MySql.Data.MySqlClient;
using System;


public static class DbHelper{
    public static MySqlConnection GetConnection(){
        string connectionString = "Server=localhost;Database=StudentDatabase;User='root';Password='';";
        MySqlConnection connection = new MySqlConnection(connectionString);
        return connection;

    }
}