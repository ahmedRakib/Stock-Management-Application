using StockManagementApp.BLL;
using StockManagementApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagementApp.UI
{
    public partial class CompanyUI : System.Web.UI.Page
    {
        CompanyManager companyManager = new CompanyManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllCompanies();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            var Company = new Company();

            Company.Name = nameTextBox.Text;

            string message = companyManager.Save(Company);

            messageLabel.InnerText = message;

            GetAllCompanies();
        }

        public void GetAllCompanies()
        {
            var companies = companyManager.GetAll();

            companyGridView.DataSource = companies;
            companyGridView.DataBind();
        }
    }
}