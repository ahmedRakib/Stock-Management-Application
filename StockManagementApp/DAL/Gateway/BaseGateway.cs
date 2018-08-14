using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace StockManagementApp.DAL.Gateway
{
    public class BaseGateway


    {
        private static string connectionString = WebConfigurationManager.ConnectionStrings["StockManagementSystemDB"].ConnectionString;

        public string Query { get; set; }

        public SqlConnection Connection { get; set; }

        public SqlCommand Command { get; set; }

        public SqlDataReader Reader { get; set; }

        public BaseGateway()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}