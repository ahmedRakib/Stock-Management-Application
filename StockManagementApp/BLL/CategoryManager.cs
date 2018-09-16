using StockManagementApp.DAL.Entity;
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
        ItemGateway itemGateway = new ItemGateway();
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

        public Category  Get(int id)
        {
            return categoryGateway.Get(id);
        }

        internal string Edit(Category category)
        {
            string message = "";

            if (categoryGateway.DoesCategoryNameExists(category.Name))
            {
                message = "The Category Name Already Exists";
            }
            else
            {
                int rowAffected = categoryGateway.Edit(category);

                if (rowAffected > 0)
                {
                    message = "Category Updated Successfully";
                }
                else
                {
                    message = "Catgeory Could Not Be Updated";
                }
            }

            return message;
        }

        internal string Delete(int categoryId)
        {
            string message = "";

            if (itemGateway.DoesCategoryHasDependency(categoryId))
            {
                message = "Can not be deleted as an item exist of that category";
            }
            else
            {
                int rowAffected = categoryGateway.Delete(categoryId);

                if (rowAffected > 0)
                {
                    message = "Company Deleted Successfully";
                }
                else
                {
                    message = "Company Could Not Be Deleted";
                }
            }

            return message;
        }
    }
}