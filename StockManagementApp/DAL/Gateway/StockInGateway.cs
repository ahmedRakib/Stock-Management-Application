using StockManagementApp.DAL.Entity;
using StockManagementApp.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StockManagementApp.DAL.Gateway
{
    public class StockInGateway : BaseGateway
    {
        public StockIn Get(string itemName, int? companyId)
        {
            var stockIn = new StockIn();

            Query = @"Select * from StockIn as s
                             Join Item as i
                             On i.Id = s.ItemId
		                     join Company as c
		                     on i.CompanyId = c.Id
                             Where i.Name = '" + itemName + "' and s.CompanyId = '" + companyId + "'";


            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                stockIn.Id = Convert.ToInt32(Reader["Id"]);
                stockIn.Quantity = Convert.ToInt32(Reader["Quantity"]);
                stockIn.CompanyId = Convert.ToInt32(Reader["CompanyId"]);
                stockIn.ItemId = Convert.ToInt32(Reader["ItemId"]);
            }
           
            Reader.Close();
            Connection.Close();

            return stockIn;
        }

        public int Save(Entity.StockIn stockIn)
        {
            Query = "INSERT INTO StockIn (CompanyId, ItemId, Quantity) VALUES ('" + stockIn.CompanyId + "', '" + stockIn.ItemId + "', '" + stockIn.Quantity + "')";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        public int Update(StockIn itemInStock)
        {

            Query = @"UPDATE StockIn 
                SET CompanyId = '" + itemInStock.CompanyId + "', ItemId = '" + itemInStock.ItemId + "', Quantity = '" + itemInStock.Quantity + "' WHERE ItemId = '"+itemInStock.ItemId+"'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        internal bool DoesItemExist(int itemId)
        {

            Query = "SELECT * FROM StockIn WHERE ItemId = '" + itemId + "'";

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
