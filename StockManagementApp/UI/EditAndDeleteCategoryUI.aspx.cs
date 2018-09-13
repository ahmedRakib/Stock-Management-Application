using StockManagementApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagementApp.UI
{
    public partial class EditAndDeleteCategoryUI : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager();
        int categoryId;
        protected void Page_Load(object sender, EventArgs e)
        {
            categoryId = Convert.ToInt32(Request.QueryString["id"]);

            if (!IsPostBack)
            {
                var category = categoryManager.Get(categoryId);

                if (category == null)
                {
                    messageLabel.InnerText = "Could Not Found";
                }
                else
                {
                    nameTextBox.Text = category.Name;
                }
            }
        }

        protected void editButton_Click(object sender, EventArgs e)
        {
           if (categoryId == 0)
           {
               messageLabel.InnerText = "Not Found";
           }
           else
           {
               var category = categoryManager.Get(categoryId);
               category.Name = nameTextBox.Text;
               messageLabel.InnerText = categoryManager.Edit(category);
           }
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            if (categoryId == 0)
            {
                messageLabel.InnerText = "Not Found";
            }
            else
            {
                //var category = categoryManager.Get(categoryId);
                //category.Name = nameTextBox.Text;
                
                messageLabel.InnerText = categoryManager.Delete(categoryId);
            }
        }
    }
}