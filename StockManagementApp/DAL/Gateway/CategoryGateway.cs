using StockManagementApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace StockManagementApp.DAL.Gateway
{
    public class CategoryGateway : BaseGateway
    {
        public int Save(Category category)
        {
            Query = "INSERT INTO Category (Name) VALUES ('"+category.Name+"')";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        public bool DoesCategoryNameExists(string categoryName)
        {
            Query = "SELECT * FROM Category WHERE Name = '" + categoryName + "'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;

            Reader.Close();
            Connection.Close();

            return hasRows;
        }

        public List<Category> GetAll()
        {
            Query = "SELECT * FROM Category";

            Command = new SqlCommand(Query, Connection);

            var categories = new List<Category>();

            Connection.Open();

            Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                Category category = new Category();

                category.Id = Convert.ToInt32(Reader["Id"]);
                category.Name = Reader["Name"].ToString();

                categories.Add(category);
            }

            Reader.Close();
            Connection.Close();

            return categories;
        }
    }
}