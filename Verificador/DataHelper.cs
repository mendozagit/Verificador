using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificador
{
    public class DataHelper
    {
        public static string GetConnectionString(string key = "cn")
        {
            var connection =
                System.Configuration.ConfigurationManager.ConnectionStrings[key].ConnectionString;

            return connection;
        }
    }
}