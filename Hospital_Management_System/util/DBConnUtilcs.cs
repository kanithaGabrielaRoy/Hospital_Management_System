using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.util
{
    public static class DbConnUtil
    {
        // Method to return SqlConnection object using DBPropertyUtil
        public static SqlConnection GetConnectionObject()
        {
            string connStr = DBPropertyUtil.GetConnectionString();
            return new SqlConnection(connStr);
        }
    }
} 
