using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SqlServerApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace SqlServerApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sample of SQL-Server data access";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Quite possibly the most amazing developer on this planet";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ActionResult Save(int id)
        {
            Employee employee = new Employee();
            if (id > 0)
            {
                var dt = new DataTable();
                using (SqlConnection sqlConn = new SqlConnection("Data Source=mydbinstance.ck7gykhkgxji.us-east-1.rds.amazonaws.com;Initial Catalog=SPTutorial;User ID=ryandines;Password=Rfd362436!"))
                {
                    string sql = "dbo.usp_employee_get_by_id";
                    using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@Employee_id", id);
                        sqlConn.Open();
                        using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                        {
                            sqlAdapter.Fill(dt);
                        }
                    }
                }
                dt.AcceptChanges();
                employee = GetItem<Employee>(dt.Rows[0]);
            }
            return View(employee);
        }

        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var dt = new DataTable();
                using (SqlConnection sqlConn = new SqlConnection("Data Source=mydbinstance.ck7gykhkgxji.us-east-1.rds.amazonaws.com;Initial Catalog=SPTutorial;User ID=ryandines;Password=Rfd362436!"))
                {
                    string sql = "dbo.usp_employee_insert";
                    using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@full_name", employee.full_name);
                        sqlCmd.Parameters.AddWithValue("@gender", employee.gender);
                        sqlCmd.Parameters.AddWithValue("@department", employee.department);
                        sqlCmd.Parameters.AddWithValue("@position", employee.position);
                        sqlCmd.Parameters.AddWithValue("@salary", employee.salary);
                        sqlConn.Open();
                        using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                        {
                            sqlAdapter.Fill(dt);
                        }
                    }
                }
                dt.AcceptChanges();
            }
            return RedirectToAction("Index");
        }
        // HELPER METHOD FOR DATA TABLES
        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
