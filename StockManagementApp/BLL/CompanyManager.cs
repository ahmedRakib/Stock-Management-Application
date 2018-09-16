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
        ItemGateway itemGateway = new ItemGateway();

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

        public Company Get(int id)
        {
            return companyGateway.Get(id);
        }

        internal string Edit(Company company)
        {
            string message = "";

            if (companyGateway.DoesCompanyExist(company.Name))
            {
                message = "Company Name Exists";
            }
            else
            {
                int rowAffected = companyGateway.Edit(company);

                if (rowAffected > 0)
                {
                    message = "Company Updated Successfully";
                }
                else
                {
                    message = "Company Could Not Be Updated";
                }
            }

            return message;
        }

        internal string Delete(int companyId)
        {
            string message = "";

            if (itemGateway.DoesCompanyHasDependency(companyId))
            {
                message = "Can not be deleted as an item exist of that company";
            }
            else
            {
                int rowAffected = companyGateway.Delete(companyId);

                if (rowAffected > 0)
                {
                    message = "Company Deleted Successfully";
                }
                else
                {
                    message = "Company Could Not Be Deleted";
                }
            }

            return message;
        }
    }
}