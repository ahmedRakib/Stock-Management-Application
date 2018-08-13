using StockManagementApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementApp.DAL.ViewModel
{
    public class ItemInformationVM : Item
    {
        public string CompanyName { get; set; }

        public int AvailableQuantity { get; set; }

        public int StockOutQuantity { get; set; }

        public int StockOutType { get; set; }

        public string StockOutTypeName { get; set; }
    }
}