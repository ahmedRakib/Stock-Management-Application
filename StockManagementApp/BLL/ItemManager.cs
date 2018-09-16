using StockManagementApp.DAL.Entity;
using StockManagementApp.DAL.Gateway;
using StockManagementApp.DAL.ViewModel;
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

            if (itemGateway.DoesItemNameOrRecorderLevelExists(item.Name, item.RecorderLevel))
            {
                message = "The Item Name or The Recorder Level already exits";
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

        public Item GetByName(string itemName)
        {
           return itemGateway.GetByName(itemName);
        }

        public Item GetById(int id)
        {
            return itemGateway.GetById(id);
        }

        internal List<ItemInformationVM> GetItemInfoByCompanyOrCategory(int companyId, int categoryId)
        {
            return itemGateway.GetItemInfoByCompanyOrCategory(companyId, categoryId);
        }

        internal List<ItemInformationVM> GetItemInfoByCompanyAndCategory(int companyId, int categoryId)
        {
            return itemGateway.GetItemInfoByCompanyAndCategory(companyId, categoryId);
        }

        internal string Edit(Item item)
        {
            string message = "";

            if (itemGateway.DoesItemNameOrRecorderLevelExists(item.Name, item.RecorderLevel))
            {
                message = "Item Name Or Recorder Level already Exists";
            }
            else
            {
                int rowAffected = itemGateway.Edit(item);

                if (rowAffected > 0)
                {
                    message = "Item Updated Successfully";
                }
                else
                {
                    message = "Item Could Not Be Updated";
                }
            }

            return message;
        }

        //internal string Delete(int itemId)
        //{
        //    string message = "";

        //    if (itemGateway.DoesCompanyHasDependency(companyId))
        //    {
        //        message = "Can not be deleted as an item exist of that company";
        //    }
        //    else
        //    {
        //        int rowAffected = companyGateway.Delete(companyId);

        //        if (rowAffected > 0)
        //        {
        //            message = "Company Deleted Successfully";
        //        }
        //        else
        //        {
        //            message = "Company Could Not Be Deleted";
        //        }
        //    }

        //    return message;
        //}
    }
}