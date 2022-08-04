using CROH.DataAccessLayer;
using CROH.DataAccessLayer.Model;
using System;

namespace CROH.App
{
    class Program
    {
        static void Main(string[] args)
        {
            DBUnit dB = new DBUnit();

            Customer customer = new Customer 
            { 
                Name = "john",
                SurName = "Owen",
                TelNumber = "045 897 20 64",
                CusType = CustomerType.Married
            };
            dB.CreateCustomer(customer);

            Customer newCustomer = new Customer
            {
                Name = "owen",
                SurName = "Owen",
                TelNumber = "045 897 20 64",
                CusType = CustomerType.Married
            };

            dB.UpdateCustomer(1);
            Console.WriteLine("Hello World!");
        }
    }
}
