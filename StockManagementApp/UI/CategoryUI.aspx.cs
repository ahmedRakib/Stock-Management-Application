using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementApp.DAL.Entity;
using StockManagementApp.BLL;

namespace StockManagementApp.UI
{
    public partial class CategoryUI : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllCatagories();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            var category = new Category();
            category.Name = nameTextBox.Text;

            string message = categoryManager.Save(category);

            messageLabel.InnerText = message;

            GetAllCatagories();
        }

        public void GetAllCatagories()
        {
            var catgeories = categoryManager.GetAll();

            categoryGridView.DataSource = catgeories;
            categoryGridView.DataBind();
        }
    }
}