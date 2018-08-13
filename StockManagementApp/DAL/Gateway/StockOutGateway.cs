using StockManagementApp.DAL.ViewModel;
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
            Query = "INSERT INTO StockOut (CompanyId, ItemId, Quantity, StockOutType, StockOutDate) VALUES ('" + stockOut.CompanyId + "', '" + stockOut.ItemId + "', '" + stockOut.Quantity + "', '" + stockOut.StockOutType+ "', '"+stockOut.Date+"')";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        internal List<ItemInformationVM> SearchSellItemsBetweenDates(string formDate, string toDate)
        {

            List<ItemInformationVM> ItemInfoVMS = new List<ItemInformationVM>();

            Query = @"SELECT * FROM DateWiseStockOut Where StockOutDate between '" + formDate + "' and '" + toDate + "'";


            Command = new SqlCommand(Query, Connection);
            Connection.Open();

            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ItemInformationVM ItemInfoVM = new ItemInformationVM();

                ItemInfoVM.Name = Reader["Name"].ToString();
                ItemInfoVM.StockOutQuantity = Convert.ToInt32(Reader["Quantity"]);
                ItemInfoVM.StockOutType = Convert.ToInt32(Reader["StockOutType"]);

                ItemInfoVMS.Add(ItemInfoVM);
            }

            Reader.Close();
            Connection.Close();

            return ItemInfoVMS;
        }
    }
}