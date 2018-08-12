using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StockManagementApp.DAL.Gateway
{
    public class StockOutGateway : BaseGateway
    {
        public int Save(Entity.StockOut stockOut)
        {
            Query = "INSERT INTO StockOut (CompanyId, ItemId, Quantity, StockOutType) VALUES ('" + stockOut.CompanyId + "', '" + stockOut.ItemId + "', '" + stockOut.Quantity + "', '" + stockOut.StockOutType+ "')";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }
    }
}