using StockManagementApp.DAL.Entity;
using StockManagementApp.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StockManagementApp.DAL.Gateway
{
    public class ItemGateway : BaseGateway
    {
        public int Save(Item item)
        {
            Query = "INSERT INTO Item (Name, RecorderLevel, CategoryId, CompanyId) VALUES ('" + item.Name + "', '"+item.RecorderLevel+"', '"+item.CategoryId+"', '"+item.CompanyId+"')";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        public bool DoesItemNameExists(string itemName)
        {
            Query = "SELECT * FROM Item WHERE Name = '" + itemName + "'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;

            Reader.Close();
            Connection.Close();

            return hasRows;
        }


        public List<Item> GetAll()
        {
            Query = "SELECT * FROM Item";

            Command = new SqlCommand(Query, Connection);

            var items = new List<Item>();

            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                var item = new Item();

                item.Id = Convert.ToInt32(Reader["Id"]);
                item.Name = Reader["Name"].ToString();
                item.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                item.CompanyId = Convert.ToInt32(Reader["CompanyId"]);
                item.RecorderLevel = Convert.ToInt32(Reader["RecorderLevel"]);

                items.Add(item);
            }

            Reader.Close();
            Connection.Close();

            return items;
        }

        public Item Get(string itemName)
        {
            var item = new Item();

            Query = @"Select * from Item Where Name = '" + itemName + "'";


            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                item.Id = Convert.ToInt32(Reader["Id"]);
                item.Name = Reader["Name"].ToString();
                item.CompanyId = Convert.ToInt32(Reader["CompanyId"]);
                item.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                item.RecorderLevel = Convert.ToInt32(Reader["RecorderLevel"]);
            }

            Reader.Close();
            Connection.Close();

            return item;
        }

        internal List<ItemInformationVM> GetItemInfoByCompanyOrCategory(int companyId, int categoryId)
        {
            List<ItemInformationVM> ItemInfoVMS = new List<ItemInformationVM>();

            Query = @"SELECT * FROM ItemByCompanyOrCategory 
                        Where CategoryId = '" + categoryId + "' Or CompanyId = '" + companyId + "'";

            Command = new SqlCommand(Query, Connection);
            Connection.Open();

            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ItemInformationVM ItemInfoVM = new ItemInformationVM();

                ItemInfoVM.Name = Reader["ItemName"].ToString();
                ItemInfoVM.CompanyName = Reader["CompanyName"].ToString();
                ItemInfoVM.RecorderLevel = Convert.ToInt32(Reader["RecorderLevel"]);
                ItemInfoVM.AvailableQuantity = Convert.ToInt32(Reader["Quantity"]);

                ItemInfoVMS.Add(ItemInfoVM);
            }

            Reader.Close();
            Connection.Close();

            return ItemInfoVMS;
        }

        internal List<ItemInformationVM> GetItemInfoByCompanyAndCategory(int companyId, int categoryId)
        {

            List<ItemInformationVM> ItemInfoVMS = new List<ItemInformationVM>();

            Query = @"SELECT * FROM ItemByCompanyOrCategory 
                        Where CategoryId = '"+categoryId+"' And CompanyId = '"+companyId+"'";

            Command = new SqlCommand(Query, Connection);
            Connection.Open();

            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ItemInformationVM ItemInfoVM = new ItemInformationVM();

                ItemInfoVM.Name = Reader["ItemName"].ToString();
                ItemInfoVM.CompanyName = Reader["CompanyName"].ToString();
                ItemInfoVM.RecorderLevel = Convert.ToInt32(Reader["RecorderLevel"]);
                ItemInfoVM.AvailableQuantity = Convert.ToInt32(Reader["Quantity"]);

                ItemInfoVMS.Add(ItemInfoVM);
            }

            Reader.Close();
            Connection.Close();

            return ItemInfoVMS;
        }
    }
}