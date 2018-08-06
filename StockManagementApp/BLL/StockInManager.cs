using StockManagementApp.DAL.Gateway;
using StockManagementApp.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementApp.BLL
{
    public class StockInManager
    {
        StockInGateway stockInGateway = new StockInGateway();
             
        public ItemStockInVM Get(string itemName)
        {
            return stockInGateway.Get(itemName);
        }
    }
}