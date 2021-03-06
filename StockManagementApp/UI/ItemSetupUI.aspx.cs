﻿using StockManagementApp.BLL;
using StockManagementApp.DAL.Entity;
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
                categoryDropDownList.Items.Insert(0, new ListItem("--Select--", "0"));

                companyDropDownList.DataSource = companies;
                companyDropDownList.DataTextField = "Name";
                companyDropDownList.DataValueField = "Id";
                companyDropDownList.DataBind();
                companyDropDownList.Items.Insert(0, new ListItem("--Select--", "0"));

            }

            GetAllItems();
        }

        public void GetAllItems()
        {
            var items = itemManager.GetAll();

            itemGridView.DataSource = items;
            itemGridView.DataBind();
           
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            
            var item = new Item();
            item.Name = itemNameTextBox.Text;
            item.RecorderLevel = Convert.ToInt32(recorderLevelTextBox.Text);
            item.CategoryId = Convert.ToInt32(categoryDropDownList.SelectedValue);
            item.CompanyId = Convert.ToInt32(companyDropDownList.SelectedValue);

            if (item.CompanyId == 0 || item.CategoryId == 0)
            {
                messageLabel.InnerText = "Please Select Item Company Name and Category";
            }
            else
            {
                messageLabel.InnerText = itemManager.Save(item);

                GetAllItems();
            }

        }
    }
}