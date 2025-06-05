using System; 
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


public class StudentOperations
{
    public void Create(string name, int age, string email)
    {
        using var conn = DbHelper.GetConnection();
        conn.Open();
        string query = "INSERT INTO Students (Name, Age, Email) VALUES (@Name, @Age, @Email)";
        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Age", age);
        cmd.Parameters.AddWithValue("@Email", email);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Student created successfully.");
        conn.Close();
    }

    public void Read()
    {
        using var conn = DbHelper.GetConnection();
        conn.Open();
        string query = "SELECT * FROM Students";
        using var cmd = new MySqlCommand(query, conn);
        // cmd.Parameters.AddWithValue("@Id", id);
        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}, Email: {reader["Email"]}");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
        conn.Close();
    }

    public void Update(int id, string name, int age, string email)
    {
        using var conn = DbHelper.GetConnection();
        conn.Open();
        string query = "UPDATE Students SET Name = @Name, Age = @Age, Email = @Email WHERE Id = @Id";
        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Age", age);
        cmd.Parameters.AddWithValue("@Email", email);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Student updated successfully.");
        conn.Close();
    }

    public void Delete(int id)
    {
        using var conn = DbHelper.GetConnection();
        conn.Open();
        string query = "DELETE FROM Students WHERE Id = @Id";
        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Student deleted successfully.");
        conn.Close();
    }
}