using StockManagementApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagementApp.UI
{
    public partial class SearchAndViewItemUI : System.Web.UI.Page
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
                categoryDropDownList.Items.Insert(0, new ListItem("--Select--", "0"));

                companyDropDownList.DataSource = companies;
                companyDropDownList.DataTextField = "Name";
                companyDropDownList.DataValueField = "Id";
                companyDropDownList.DataBind();
                companyDropDownList.Items.Insert(0, new ListItem("--Select--","0"));
            }
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            var message = "";
            var companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
            var categoryId = Convert.ToInt32(categoryDropDownList.SelectedValue);

            if (companyId == 0 && categoryId == 0)
            {
                message = "Please Select both or any of them";
            }
            else 
            {
                if (companyId != 0 && categoryId != 0)
                {
                    var itemInfoVM = itemManager.GetItemInfoByCompanyAndCategory(companyId, categoryId);
                    itemInfoGridView.DataSource = itemInfoVM;
                    itemInfoGridView.DataBind();
                }
                else
                {
                    var itemInfoVM = itemManager.GetItemInfoByCompanyOrCategory(companyId, categoryId);
                    itemInfoGridView.DataSource = itemInfoVM;
                    itemInfoGridView.DataBind();
                }

                if (itemInfoGridView.Rows.Count == 0)
                {
                    message = "Not found any item";
                }
            }

            messageLabel.Text = message;
        }
    }
}