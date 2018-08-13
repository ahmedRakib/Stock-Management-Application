using StockManagementApp.DAL.Gateway;
using StockManagementApp.DAL.ViewModel;
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

        //internal void SearchSellItemsBetweenDates(System.Web.UI.HtmlControls.HtmlInputText formDate, System.Web.UI.HtmlControls.HtmlInputText toDate)
        //{
        //    stockOutGateway
        //}

        internal List<ItemInformationVM> SearchSellItemsBetweenDates(string formDate, string toDate)
        {
            var itemInfoVMS = stockOutGateway.SearchSellItemsBetweenDates(formDate, toDate);

            foreach (var i in itemInfoVMS)
            {
                if (i.StockOutType == 1)
                {
                    i.StockOutTypeName = "Sold";
                }
                else if (i.StockOutType == 2)
                {
                    i.StockOutTypeName = "Damaged";
                }
                else if (i.StockOutType == 3)
                {
                    i.StockOutTypeName = "Lost";
                }
            }

            return itemInfoVMS;
        }
    }
}