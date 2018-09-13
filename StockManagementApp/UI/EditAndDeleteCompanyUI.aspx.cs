using StockManagementApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagementApp.UI
{
    public partial class EditAndDeleteCompanyUI : System.Web.UI.Page
    {
        CompanyManager companyManager = new CompanyManager();
        int companyId;
        protected void Page_Load(object sender, EventArgs e)
        {
           companyId = Convert.ToInt32(Request.QueryString["id"]);

            if (!IsPostBack)
            {
                var company = companyManager.Get(companyId);

                if (company == null)
                {
                    messageLabel.InnerText = "Could Not Found";
                }
                else
                {
                    nameTextBox.Text =company.Name;
                }
            }

        }

        protected void editButton_Click(object sender, EventArgs e)
        {
            if (companyId == 0)
            {
                messageLabel.InnerText = "Not Found";
            }
            else
            {
                var company = companyManager.Get(companyId);
                company.Name = nameTextBox.Text;
                messageLabel.InnerText = companyManager.Edit(company);
            }
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            if (companyId == 0)
            {
                messageLabel.InnerText = "Not Found";
            }
            else
            {
                messageLabel.InnerText = companyManager.Delete(companyId);
            }
        }
    }
}