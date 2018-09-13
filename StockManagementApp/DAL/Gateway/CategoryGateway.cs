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
            Query = "sp_SaveCategory @name = '"+category.Name+"'";

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
            Query = "sp_GetAllCategory";

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

        public Category Get(int id)
        {
            Category category = new Category();

            Query = "select * from Category where Id = '"+id+"'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                category.Id = Convert.ToInt32(Reader["Id"]);
                category.Name = Reader["Name"].ToString();
            }

            Reader.Close();
            Connection.Close();

            return category;
        }

        internal int Edit(Category category)
        {

            Query = "sp_EditCategory @name = '" + category.Name + "', @id = '"+category.Id+"'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        internal int Delete(int categoryId)
        {
            Category category = new Category();

            Query = "delete  from Category where Id = '" + categoryId + "'";


            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }
    }
}