using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SqlServerApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SqlServerApp.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        // GET: api/Employee/
        [HttpGet]
        public string Get()
        {
            var dt = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection("Data Source=mydbinstance.ck7gykhkgxji.us-east-1.rds.amazonaws.com;Initial Catalog=SPTutorial;User ID=ryandines;Password=Rfd362436!"))
            {
                string sql = "dbo.usp_employee_get_all";
                using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlConn.Open();
                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                    {
                        sqlAdapter.Fill(dt);
                    }
                }
            }
            return JsonConvert.SerializeObject(dt);
        }

        // GET api/Employee/5
        [HttpGet("{id}")]
        public string Get(int id)
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
            return JsonConvert.SerializeObject(dt);
        }

        // POST api/Employee/
        [HttpPost]
        public void Post([FromBody]Employee employee)
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
            return;
        }

        // PUT api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Employee employee)
        {
            var dt = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection("Data Source=mydbinstance.ck7gykhkgxji.us-east-1.rds.amazonaws.com;Initial Catalog=SPTutorial;User ID=ryandines;Password=Rfd362436!"))
            {
                string sql = "dbo.usp_employee_update";
                using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@employee_id", id);
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
        }

        // DELETE api/Employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var dt = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection("Data Source=mydbinstance.ck7gykhkgxji.us-east-1.rds.amazonaws.com;Initial Catalog=SPTutorial;User ID=ryandines;Password=Rfd362436!"))
            {
                string sql = "dbo.usp_employee_delete";
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
            return;
        }
    }
}
