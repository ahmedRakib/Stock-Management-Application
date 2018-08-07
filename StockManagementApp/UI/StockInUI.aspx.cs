﻿using StockManagementApp.BLL;
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

        private void GetItem()
        {
           
            messageLabel.Text = String.Empty;
            var itemName = itemDropDownList.SelectedItem.Text;
            var item  = itemManager.Get(itemName);
            var companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
            var stocIn = stockInManager.Get(item.Name, companyId);
            quantityTextBox.Text = stocIn.Quantity.ToString();
            recorderLevelTextBox.Text = item.RecorderLevel.ToString();
        }


        protected void saveButton_Click(object sender, EventArgs e)
        {
            var stockIn = new StockIn();
            stockIn.CompanyId = Convert.ToInt32(companyDropDownList.SelectedValue);
            stockIn.ItemId = Convert.ToInt32(itemDropDownList.SelectedValue);
            stockIn.Quantity = Convert.ToInt32(quantityTextBox.Text) +Convert.ToInt32(stockInTextBox.Text);

            messageLabel.Text = stockInManager.Save(stockIn);

            stockInTextBox.Text = String.Empty;
        }
    }
}