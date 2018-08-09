using StockManagementApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagementApp.UI
{
    public partial class StockOutUI : System.Web.UI.Page
    {

        CompanyManager companyManager = new CompanyManager();
        StockOutManager stockOutManager = new StockOutManager();
        StockInManager stockInManager = new StockInManager();
        ItemManager itemManager = new ItemManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var companies = companyManager.GetAll();
                var items = itemManager.GetAll();

                companyDropDownList.DataSource = companies;
                companyDropDownList.DataValueField = "Id";
                companyDropDownList.DataTextField = "Name";
                companyDropDownList.DataBind();
                //companyDropDownList.Items.Insert(0, "Select");

                itemDropDownList.DataSource = items;
                itemDropDownList.DataValueField = "Id";
                itemDropDownList.DataTextField = "Name";
                itemDropDownList.DataBind();
                itemDropDownList.Items.Insert(0, "Select");
            }

            GetItem();
        }

        protected void getItemDropDown_Change(object sender, EventArgs e)
        {
            GetItem();
        }

        protected void companyDropDown_Change(object sender, EventArgs e)
        {
            GetItem();
        }

        private void GetItem()
        {

            //messageLabel.Text = String.Empty;
            var itemName = itemDropDownList.SelectedItem.Text;
            var item = itemManager.Get(itemName);
            var companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
            var stocIn = stockInManager.Get(item.Name, companyId);
            availableQuantityTextBox.Text = stocIn.Quantity.ToString();
            recorderLevelTextBox.Text = item.RecorderLevel.ToString();
        }
    }
}