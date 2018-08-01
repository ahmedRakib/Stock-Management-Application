using StockManagementApp.DAL.Entity;
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

    }
}