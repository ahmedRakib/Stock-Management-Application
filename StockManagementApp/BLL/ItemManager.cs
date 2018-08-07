using StockManagementApp.DAL.Entity;
using StockManagementApp.DAL.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementApp.BLL
{
    public class ItemManager
    {
        ItemGateway itemGateway =  new ItemGateway();

        public string Save(Item item)
        {
            string message = "";

            if (itemGateway.DoesItemNameExists(item.Name))
            {
                message = "The Item Name Already Exists";
            }
            else
            {
                int rowAffected = itemGateway.Save(item);

                if (rowAffected > 0)
                {
                    message = "Item Saved Suuccessfully";
                }
                else
                {
                    message = "Item Could Not Be Saved";
                }
            }

            return message;
        }

        public List<Item> GetAll()
        {
            return itemGateway.GetAll();
        }

        public Item Get(string itemName)
        {
           return itemGateway.Get(itemName);
        }
    }
}