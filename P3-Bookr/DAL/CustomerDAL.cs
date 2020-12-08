using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;
using P3_Bookr.DAL.Interfaces;

namespace P3_Bookr.DAL.Interfaces
{
    class CustomerDAL : ICustomerDAL
    {
        string fileName = "Customers";
        JsonHandler jsonHandler = new JsonHandler();
        public List<Customer> GetCustomers()
        {
            List<Customer> customers;
            customers = jsonHandler.ReadJsonObjectFromFile<List<Customer>>(fileName);
            return customers;
        }

        public void SetCustomers(List<Customer> customers)
        {
            jsonHandler.WriteJsonObjectToFile(fileName, customers);
        }


    }
}
