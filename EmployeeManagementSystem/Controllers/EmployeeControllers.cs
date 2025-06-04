using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly string connectionString = "server=localhost;user=root;password='';database=EMS";

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = @"INSERT INTO Employee (EmpNo, Name, Email, PhoneNumber, Company, Department, JoiningDate, Salary) 
                             VALUES (@EmpNo, @Name, @Email, @PhoneNumber, @Company, @Department, @JoiningDate, @Salary)";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
            cmd.Parameters.AddWithValue("@Name", emp.Name);
            cmd.Parameters.AddWithValue("@Email", emp.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
            cmd.Parameters.AddWithValue("@Company", emp.Company);
            cmd.Parameters.AddWithValue("@Department", emp.Department);
            cmd.Parameters.AddWithValue("@JoiningDate", emp.JoiningDate);
            cmd.Parameters.AddWithValue("@Salary", emp.Salary);

            cmd.ExecuteNonQuery();

            ViewBag.Message = "Employee saved successfully.";
            return View();
        }
    }
}
