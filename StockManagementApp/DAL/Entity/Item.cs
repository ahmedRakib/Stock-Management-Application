using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementApp.DAL.Entity
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int RecorderLevel { get; set; }

        public int CategoryId { get; set; }

        public int CompanyId { get; set; }
    }
}