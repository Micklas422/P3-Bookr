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
        List<Customer> _customers;
        string _fileName = "Customers";
        JsonHandler _jsonHandler = new JsonHandler();

        public List<Customer> Customers {  get => _customers; private set => _customers = value; }

        public CustomerDAL()
        {
            Customers = LoadCustomers();
        }

        private List<Customer> LoadCustomers()
        {
            List<Customer> cus;
            cus = _jsonHandler.ReadJsonObjectFromFile<List<Customer>>(_fileName);
            return cus;
        }

        public Customer GetCustomer(int id)
        {
            return Customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public void UpdateCustomer(Customer customer)
        {
            Customers.Where(c => c.Id == customer.Id).Select(c => c = customer);
        }

        public void SetCustomers(List<Customer> customers)
        {
            _jsonHandler.WriteJsonObjectToFile(_fileName, customers);
        }
    }
}
