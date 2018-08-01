using StockManagementApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagementApp.UI
{
    public partial class ItemSetupUI : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager();
        CompanyManager companyManager = new CompanyManager();
        ItemManager itemManager = new ItemManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var categories = categoryManager.GetAll();
                var companies = companyManager.GetAll();

                categoryDropDownList.DataSource = categories;
                categoryDropDownList.DataTextField = "Name";
                categoryDropDownList.DataValueField = "Id";
                categoryDropDownList.DataBind();

                companyDropDownList.DataSource = companies;
                companyDropDownList.DataTextField = "Name";
                companyDropDownList.DataValueField = "Id";
                companyDropDownList.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}