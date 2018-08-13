using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementApp.DAL.Entity
{
    public class StockOut : StockIn
    {
        public int StockOutType { get; set; }

        public DateTime Date { get; set; }
    }
}