using StockManagementApp.BLL;
using StockManagementApp.DAL.Entity;
using StockManagementApp.DAL.Enum;
using StockManagementApp.DAL.ViewModel;
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
        StockOutVM stockOutVM = new StockOutVM();
        StockIn stockIn = new StockIn();
        Item item = new Item();
        List<StockOutVM> listOfVM ;

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
                companyDropDownList.Items.Insert(0, new ListItem("--Select--", "0"));

                itemDropDownList.DataSource = items;
                itemDropDownList.DataValueField = "Id";
                itemDropDownList.DataTextField = "Name";
                itemDropDownList.DataBind();
                itemDropDownList.Items.Insert(0, new ListItem("--Select--", "0"));
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

            messageLabel.Text = String.Empty;
            var itemName = itemDropDownList.SelectedItem.Text;
            item = itemManager.Get(itemName);
            var companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
            stockIn = stockInManager.Get(item.Name, companyId);
            availableQuantityTextBox.Text = stockIn.Quantity.ToString();
            recorderLevelTextBox.Text = item.RecorderLevel.ToString();
        }

        public void AddItemToDropdown()
        {
            stockOutVM.Item = itemDropDownList.SelectedItem.Text;
            stockOutVM.ItemId = Convert.ToInt32(itemDropDownList.SelectedValue);
            stockOutVM.Company = companyDropDownList.SelectedItem.Text;
            stockOutVM.CompanyId = Convert.ToInt32(companyDropDownList.SelectedValue);
            stockOutVM.StockOutQuantity = Convert.ToInt32(stockOutTextBox.Text);

            ViewState["ITEM"] = stockOutVM;
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            AddItemToDropdown();

            var VM = (StockOutVM)ViewState["ITEM"];

            if (ViewState["ITEMS"] == null)
            {
                listOfVM = new List<StockOutVM>();
                listOfVM.Add(VM);
                ViewState["ITEMS"] = listOfVM;
            }

            else
            {
                listOfVM = (List<StockOutVM>)ViewState["ITEMS"];
                listOfVM.Add(VM);
                ViewState["ITEMS"] = listOfVM;
            }
            
            stockOutGridView.DataSource = listOfVM;
            stockOutGridView.DataBind();
        }

        protected void sellButton_Click(object sender, EventArgs e)
        {
           var message ="";
            List<StockOutVM> items = (List<StockOutVM>)ViewState["ITEMS"];
            foreach (var i in items)
            {
                var stockOut = new StockOut();
                stockOut.Quantity = i.StockOutQuantity;
                stockOut.CompanyId = i.CompanyId;
                stockOut.ItemId = i.ItemId;
                stockOut.StockOutType = (int) StockOutType.Sell;
                stockOut.Date = DateTime.Now.Date;


                var itemInStock = stockInManager.Get(i.Item, i.CompanyId);
                itemInStock.Quantity = itemInStock.Quantity - stockOut.Quantity;
                if(itemInStock.Quantity < 0)
                {
                    message = "Sorry!!! There is not enough number of item to sale.";
                }
                
                else
                {
                     message = stockInManager.UpdateItemQuantity(itemInStock);
                     message = stockOutManager.Save(stockOut);
                     availableQuantityTextBox.Text = itemInStock.Quantity.ToString();
                     stockOutTextBox.Text = String.Empty;
                }
            }

            messageLabel.Text = message;
        }

        protected void damageButton_Click(object sender, EventArgs e)
        {
            var message = "";
            List<StockOutVM> items = (List<StockOutVM>)ViewState["ITEMS"];
            foreach (var i in items)
            {
                var stockOut = new StockOut();
                stockOut.Quantity = i.StockOutQuantity;
                stockOut.CompanyId = i.CompanyId;
                stockOut.ItemId = i.ItemId;
                stockOut.StockOutType = (int)StockOutType.Damage;


                var itemInStock = stockInManager.Get(i.Item, i.CompanyId);
                itemInStock.Quantity = itemInStock.Quantity - stockOut.Quantity;
                if (itemInStock.Quantity < 0)
                {
                    message = "Sorry!!! There is not enough number of item to sale.";
                }

                else
                {
                    message = stockInManager.UpdateItemQuantity(itemInStock);
                    message = stockOutManager.Save(stockOut);
                }
            }

            messageLabel.Text = message;
        }

        protected void lostButton_Click(object sender, EventArgs e)
        {
            var message = "";
            List<StockOutVM> items = (List<StockOutVM>)ViewState["ITEMS"];
            foreach (var i in items)
            {
                var stockOut = new StockOut();
                stockOut.Quantity = i.StockOutQuantity;
                stockOut.CompanyId = i.CompanyId;
                stockOut.ItemId = i.ItemId;
                stockOut.StockOutType = (int)StockOutType.Lost;


                var itemInStock = stockInManager.Get(i.Item, i.CompanyId);
                itemInStock.Quantity = itemInStock.Quantity - stockOut.Quantity;
                if (itemInStock.Quantity < 0)
                {
                    message = "Sorry!!! There is not enough number of item to sale.";
                }

                else
                {
                    message = stockInManager.UpdateItemQuantity(itemInStock);
                    message = stockOutManager.Save(stockOut);
                }
            }

            messageLabel.Text = message;
        }
    }
}