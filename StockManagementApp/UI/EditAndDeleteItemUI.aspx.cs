using StockManagementApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagementApp.UI
{
    public partial class EditAndDeleteItemUI : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager();
        CompanyManager companyManager = new CompanyManager();
        ItemManager itemManager = new ItemManager();
        int itemId;
        protected void Page_Load(object sender, EventArgs e)
        {
            itemId = Convert.ToInt32(Request.QueryString["id"]);

            if (!IsPostBack)
            {
                var item = itemManager.GetById(itemId);

                if (item == null)
                {
                    messageLabel.InnerText = "Could Not Found";
                }
                else
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
                    companyDropDownList.Items.Insert(0, new ListItem("--Select--", "0"));
                    itemNameTextBox.Text = item.Name;
                    recorderLevelTextBox.Text = item.RecorderLevel.ToString();
                }
            }

        }

        protected void editButton_Click(object sender, EventArgs e)
        {
            if (itemId == 0)
            {
                messageLabel.InnerText = "Not Found";
            }
            else
            {
                var item = itemManager.GetById(itemId);
                item.Name = itemNameTextBox.Text;
                item.RecorderLevel = Convert.ToInt32(recorderLevelTextBox.Text);
                item.CompanyId = Convert.ToInt32(companyDropDownList.SelectedValue);
                item.CategoryId = Convert.ToInt32(categoryDropDownList.SelectedValue);

                if (item.CompanyId == 0 || item.CategoryId == 0)
                {
                    messageLabel.InnerText = "Please Select Item Company Name and Category";
                }
                else
                {
                    messageLabel.InnerText = itemManager.Edit(item);
                }
            }
        }

        //protected void deleteButton_Click(object sender, EventArgs e)
        //{
        //    if (itemId == 0)
        //    {
        //        messageLabel.InnerText = "Not Found";
        //    }
        //    else
        //    {
        //        messageLabel.InnerText = itemManager.Delete(itemId);
        //    }
        //}
    }
}