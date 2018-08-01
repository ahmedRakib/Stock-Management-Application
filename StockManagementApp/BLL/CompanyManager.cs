using StockManagementApp.DAL.Entity;
using StockManagementApp.DAL.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementApp.BLL
{
    public class CompanyManager
    {
        CompanyGateway companyGateway = new CompanyGateway();

        public string Save(DAL.Entity.Company Company)
        {
            string message = "";

            if (companyGateway.DoesCompanyExist(Company.Name))
            {
                message = "There is already a company with this name";
            }

            else 
            {
                int rowAffected = companyGateway.Save(Company);

                if (rowAffected > 0)
                {
                    message = "Company Name Saved Succesfully";
                }

                else
                {
                    message = "Company Name Could not be saved";
                }
            }

            return message;
        }

        public List<Company> GetAll()
        {
           var companies = companyGateway.GetAll();

           return companies;
        }
    }
}