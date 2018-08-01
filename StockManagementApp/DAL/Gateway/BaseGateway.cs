﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StockManagementApp.DAL.Gateway
{
    public class BaseGateway
    {
        public string connectionString = "Server = DESKTOP-78PMIPM; Database = StockManagementDB; Integrated Security = True";

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