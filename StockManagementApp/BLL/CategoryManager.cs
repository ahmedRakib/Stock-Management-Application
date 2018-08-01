using StockManagementApp.DAL.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementApp.BLL
{
    public class CategoryManager
    {
        CategoryGateway categoryGateway = new CategoryGateway();

        public string Save(DAL.Entity.Category category)
        {
            string message = "";

            if (categoryGateway.DoesCategoryNameExists(category.Name))
            {
                message = "The Category Name Already Exists";
            }
            else 
            {
                int rowAffected = categoryGateway.Save(category);

                if (rowAffected > 0)
                {
                    message = "Category Saved Suuccessfully";
                }
                else
                {
                    message = "Catgeory Could Not Be Saved";
                }
            }

            return message;
        }

        public List<DAL.Entity.Category> GetAll()
        {
            var categories = categoryGateway.GetAll();

            return categories;
        }
    }
}