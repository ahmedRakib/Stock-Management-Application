using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementApp.DAL.Entity
{
    public class StockIn
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ItemId { get; set; }

        public int Quantity { get; set; }
    }
}