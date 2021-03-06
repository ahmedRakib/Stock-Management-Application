﻿using StockManagementApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StockManagementApp.DAL.Gateway
{
    public class CompanyGateway :  BaseGateway
    {
        public int Save(Entity.Company Company)
        {
            Query = "INSERT INTO COMPANY (Name) VALUES('"+Company.Name+"')";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            var rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        public bool DoesCompanyExist(string comapnyName)
        {
            Query = "SELECT * FROM COMPANY WHERE Name = '"+comapnyName+"'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();
            bool hasRow = Reader.HasRows;

            Reader.Close();
            Connection.Close();

            return hasRow;
        }

        public List<Company> GetAll()
        {
            var companies = new List<Company>();
            
            Query = "SELECT * FROM Company";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                var company = new Company();

                company.Id = Convert.ToInt32(Reader["Id"]);
                company.Name = Reader["Name"].ToString();

                companies.Add(company);
            }

            Reader.Close();
            Connection.Close();

            return companies;
        }

        public Company Get(int id)
        {
            Company company = new Company();

            Query = "select * from Company where Id = '" + id + "'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                company.Id = Convert.ToInt32(Reader["Id"]);
                company.Name = Reader["Name"].ToString();
            }

            Reader.Close();
            Connection.Close();

            return company;
        }

        internal int Edit(Company company)
        {

            Query = "sp_EditCompany @name = '" + company.Name + "', @id = '" + company.Id + "'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        internal int Delete(int companyId)
        {
            Company company = new Company();

            Query = "delete  from Company where Id = '" + companyId + "'";


            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

    }
}