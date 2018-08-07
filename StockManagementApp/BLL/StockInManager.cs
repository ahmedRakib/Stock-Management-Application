﻿using StockManagementApp.DAL.Entity;
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
             
        public StockIn Get(string itemName, int? companyId)
        {
            return stockInGateway.Get(itemName, companyId);
        }

        public string Save(DAL.Entity.StockIn stockIn)
        {
            string message = ""; 

            int rowAffected = stockInGateway.Save(stockIn);

            if (rowAffected > 0)
            {
                message = "Saved Successfully";
            }
            else
            {
                message = "Could not be saved";
            }

            return message;
        }
    }
}