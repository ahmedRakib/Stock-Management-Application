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
        public ViewModel.ItemStockInVM Get(string itemName)
        {
            var VM = new ItemStockInVM();
            Query = @"Select s.Id, s.Quantity, i.RecorderLevel from StockIn as s
                                Join Item as i
                                On i.Id = s.ItemId
                                Where i.Name = 'TV'";


            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                VM.Quantity = Convert.ToInt32(Reader["Quantity"]);
                VM.RecorderLevel = Convert.ToInt32(Reader["RecorderLevel"]);
            }
           
            Reader.Close();
            Connection.Close();

            return VM;
        }
    }
}