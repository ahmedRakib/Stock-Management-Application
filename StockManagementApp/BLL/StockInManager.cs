using StockManagementApp.DAL.Entity;
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

            bool itemExist = stockInGateway.DoesItemExist(stockIn.ItemId);

            if (itemExist)
            {
                int rowAffected = stockInGateway.Update(stockIn);
                if (rowAffected > 0)
                {
                    message = "Saved Successfully";
                }
                else
                {
                    message = "Could not be saved";
                }
            }
            else 
            {
                int rowAffected = stockInGateway.Save(stockIn);

                if (rowAffected > 0)
                {
                    message = "Saved Successfully";
                }
                else
                {
                    message = "Could not be saved";
                }
            }
           
            return message;
        }

        public string UpdateItemQuantity(StockIn itemInStock)
        {
            int rowAffected= stockInGateway.Update(itemInStock);

            if (rowAffected > 0)
            {
                return "Updated Successfully";
            }
            else
            {
                return "Updating Failed";
            }
        }
    }
}