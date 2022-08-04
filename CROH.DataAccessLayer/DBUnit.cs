using CROH.DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CROH.DataAccessLayer
{
    public class DBUnit
    {
        DbContext contex;
        string dbContextSelection = "MSSQL";
        public DBUnit()
        {
            switch (dbContextSelection)
            {
                case "MSSQL":
                    contex = new MSSQLContext();
                    break;
                case "PostgreSql":
                    contex = new PostgreSQLContext();
                    break;
                default:
                    break;
            }
        }



        public void CreateCustomer(Customer customer)
        {
            switch (dbContextSelection)
            {
                case "MSSQL":
                    ((MSSQLContext)contex).Customers.Add(customer);
                    contex.SaveChanges();
                    break;
                case "PostgreSql":
                    ((PostgreSQLContext)contex).Customers.Add(customer);
                    contex.SaveChanges();
                    break;
                default:
                    break;
            }
        }

        public void UpdateCustomer(int id)
        {
            Customer customerOwen = new Customer()
            {
                Name = "owen",
                SurName = "Owen",
                TelNumber = "045 897 20 64",
                CusType = CustomerType.Married
            };
            switch (dbContextSelection)
            {
                
                case "MSSQL":
                    var cus = ((MSSQLContext)contex).Customers.Where(c => c.Id == id).FirstOrDefault();
                    cus.Name = customerOwen.Name;
                    contex.SaveChanges();
                    break;
                case "PostgreSql":
                    var cusP = ((PostgreSQLContext)contex).Customers.Where(c => c.Id == id).FirstOrDefault();
                    cusP.Name = "oWEN";
                    contex.SaveChanges();
                    break;
                default:
                    break;
            }
        }


        public void DeleteCustomer(Customer customer)
        {
            switch (dbContextSelection)
            {
                case "MSSQL":
                    ((MSSQLContext)contex).Customers.Remove(customer);
                    contex.SaveChanges();
                    break;
                case "PostgreSql":
                    ((PostgreSQLContext)contex).Customers.Remove(customer);
                    contex.SaveChanges();
                    break;
                default:
                    break;
            }
        }
    }
}
