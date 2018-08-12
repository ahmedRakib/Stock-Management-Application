using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementApp.DAL.ViewModel
{
    [Serializable]
    public class StockOutVM
    {
        //public int Id { get; set; }

        public string Item { get; set; }

        public int StockOutQuantity { get; set; } 

        public string Company { get; set; }

        public int CompanyId { get; set; }

        public int ItemId { get; set; }
    }
}