using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hospital_Management_System.util
{
    public static class DBPropertyUtil
    {
        private static readonly IConfiguration _configuration;

        // Static constructor to load appsettings.json when class is accessed
        static DBPropertyUtil()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())          // Set the root path
                .AddJsonFile("appsettings.json", optional: false);     // Load the JSON config file

            _configuration = builder.Build(); // Build the configuration
        }

        // Method to return the connection string by key name
        public static string GetConnectionString()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }
    }
}
