using StockManagementApp.BLL;
using StockManagementApp.DAL.Entity;
using StockManagementApp.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagementApp.UI
{
    public partial class StockInUI : System.Web.UI.Page
    {
        CompanyManager companyManager = new CompanyManager();
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

                itemDropDownList.DataSource = items;
                itemDropDownList.DataValueField = "Id";
                itemDropDownList.DataTextField = "Name";
                itemDropDownList.DataBind();
            }

            GetItem();
        }


        protected void getItemDropDown_Change(object sender, EventArgs e)
        {
            GetItem();
        }

        private void GetItem()
        {
            ItemStockInVM VM = new ItemStockInVM();

            var itemName = itemDropDownList.SelectedItem.Text;
            VM = stockInManager.Get(itemName);
            quantityTextBox.Text = VM.Quantity.ToString();
            recorderLevelTextBox.Text = VM.RecorderLevel.ToString();
        }


        protected void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}