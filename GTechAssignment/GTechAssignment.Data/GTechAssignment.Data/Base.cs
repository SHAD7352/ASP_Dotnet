using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTechAssignment.Data
{
    public class Base
    {
        string connectionString = ConfigurationManager.ConnectionStrings["appConnection"].ConnectionString;
        public string ConnectionString { 
            get { 
                return connectionString;
            } 
        }
    }
}
