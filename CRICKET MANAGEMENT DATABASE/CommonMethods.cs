using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRICKET_MANAGEMENT_DATABASE
{
    public static class CommonMethods
    {
        public static string GetConnectionString() 
        {
            return ConfigurationManager.AppSettings["SqlConnection"];
        }
    }
}
