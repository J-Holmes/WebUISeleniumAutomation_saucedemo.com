using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WebUISeleniumAutomation_saucedemo.com
{
    class ConfigHelper
    {
        private static IConfiguration _config;

        static ConfigHelper()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public static string WebsiteUrl => _config["WebsiteUrl"];
        public static string Username => _config["Username"];
        public static string Password => _config["Password"];

    }
}
