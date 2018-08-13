using StockManagementApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagementApp.UI
{
    public partial class ViewSalesBetweenDatesUI : System.Web.UI.Page
    {
        StockOutManager stockOutManager = new StockOutManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            var formDate = fromDateTextBox.Value.ToString();
            var toDate = toDateTextBox.Value.ToString();

            var itemInfoVMS = stockOutManager.SearchSellItemsBetweenDates(formDate, toDate);

            stockOutInfoGridView.DataSource = itemInfoVMS;
            stockOutInfoGridView.DataBind();
        }
    }
}