using Microsoft.AspNetCore.Mvc;
using EmployeeManagementSystem.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

public class EmployeeController : Controller
{
    private readonly IConfiguration _configuration;

    public EmployeeController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    //operations 
    //List all the employees
    public IActionResult Index()
    {
        var employees = new List<Employee>();
        string connString = _configuration.GetConnectionString("DefaultConnection");

        var conn = new MySqlConnection(connString);

        conn.Open();

        string query = "SELECT * FROM Employees";
        var cmd = new MySqlCommand(query, conn);
        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            employees.Add(new Employee
            {
                EmpNo = reader["EmpNo"].ToString(),
                Name = reader["Name"].ToString(),
                Email = reader["Email"].ToString(),
                Phone = reader["Phone"].ToString(),
                Company = reader["Company"].ToString(),
                Department = reader["Department"].ToString(),
                JoiningDate = Convert.ToDateTime(reader["JoiningDate"]),
                Salary = Convert.ToDecimal(reader["Salary"])
            });
        }
        return View(employees);
    }

    //show create form
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
}