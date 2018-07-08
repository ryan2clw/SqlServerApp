using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace SqlServerApp.Models
                      
{
    public class Employee
    {
        public string full_name { get; set; }
        public string gender { get; set; }
        public string department { get; set; }
        public string position { get; set; }
        public float salary { get; set; }
    }
}
