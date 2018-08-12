using StockManagementApp.DAL.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementApp.BLL
{
    public class StockOutManager
    {
        StockOutGateway stockOutGateway = new StockOutGateway();
        public string Save(DAL.Entity.StockOut stockOut)
        {
           int rowAffected = stockOutGateway.Save(stockOut);
           string message = "";
           if (rowAffected > 0)
           {
               message = "Stock Updated";
           }
            else
           {
               message = "Stock Updating Failed";
           }

            return  message;
        }
    }
}