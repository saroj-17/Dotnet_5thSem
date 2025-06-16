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
                PhoneNo = reader["PhoneNo"].ToString(),
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


    //create employee
    [HttpPost]

    public IActionResult Create(Employee employee)
    {
        string connString = _configuration.GetConnectionString("DefaultConnection");
        var conn = new MySqlConnection(connString);
        conn.Open();
        string query = "INSERT INTO Employees (EmpNo, Name, Email, PhoneNo, Company, Department, JoiningDate, Salary) " +
                       "VALUES (@EmpNo, @Name, @Email, @PhoneNo, @Company, @Department, @JoiningDate, @Salary)";

        var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@EmpNo", employee.EmpNo);
        cmd.Parameters.AddWithValue("@Name", employee.Name);
        cmd.Parameters.AddWithValue("@Email", employee.Email);
        cmd.Parameters.AddWithValue("@PhoneNo", employee.PhoneNo);
        cmd.Parameters.AddWithValue("@Company", employee.Company);
        cmd.Parameters.AddWithValue("@Department", employee.Department);
        cmd.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);
        cmd.Parameters.AddWithValue("@Salary", employee.Salary);

        cmd.ExecuteNonQuery();
        conn.Close();

        return RedirectToAction("Index");
    }

    //show details of employee
    public IActionResult Details(string id)
    {
        var emp = GetEmployeeById(id);
        return View(emp);
    }

    private Employee? GetEmployeeById(string id)
    {
        var connString = _configuration.GetConnectionString("DefaultConnection");
        var conn = new MySqlConnection(connString);
        conn.Open();

        string query = "SELECT * FROM Employees WHERE EmpNo = @EmpNo";
        var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@EmpNo", id);
        var reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            return new Employee
            {
                EmpNo = reader["EmpNo"].ToString(),
                Name = reader["Name"].ToString(),
                Email = reader["Email"].ToString(),
                PhoneNo = reader["PhoneNo"].ToString(),
                Company = reader["Company"].ToString(),
                Department = reader["Department"].ToString(),
                JoiningDate = Convert.ToDateTime(reader["JoiningDate"]),
                Salary = Convert.ToDecimal(reader["Salary"])
            };
        }
        return null;
    }



    //edir form 
    public IActionResult Edit(string id)
    {
        var emp = GetEmployeeById(id);
        if (emp == null)
        {
            return NotFound();
        }
        return View(emp);
    }

    //update employee
    [HttpPost]
    public IActionResult Edit(Employee employee)
    {
        string connString = _configuration.GetConnectionString("DefaultConnection");
        var conn = new MySqlConnection(connString);
        conn.Open();

        string query = "UPDATE Employees SET Name = @Name, Email = @Email, PhoneNo = @PhoneNo, Company = @Company, " +
                       "Department = @Department, JoiningDate = @JoiningDate, Salary = @Salary WHERE EmpNo = @EmpNo";

        var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@EmpNo", employee.EmpNo);
        cmd.Parameters.AddWithValue("@Name", employee.Name);
        cmd.Parameters.AddWithValue("@Email", employee.Email);
        cmd.Parameters.AddWithValue("@PhoneNo", employee.PhoneNo);
        cmd.Parameters.AddWithValue("@Company", employee.Company);
        cmd.Parameters.AddWithValue("@Department", employee.Department);
        cmd.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);
        cmd.Parameters.AddWithValue("@Salary", employee.Salary);

        cmd.ExecuteNonQuery();
        conn.Close();

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(string id)
    {
        var emp = GetEmployeeById(id);
        if (emp == null)
        {
            return NotFound();
        }
        return View(emp);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(string id)
    {
        string connString = _configuration.GetConnectionString("DefaultConnection");
        var conn = new MySqlConnection(connString);
        conn.Open();

        string query = "DELETE FROM Employees WHERE EmpNo = @EmpNo";
        var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@EmpNo", id);

        cmd.ExecuteNonQuery();
        conn.Close();

        return RedirectToAction("Index");
    }





}

