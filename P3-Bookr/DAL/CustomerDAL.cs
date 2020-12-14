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
        public List<Customer> Customers => throw new NotImplementedException();

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void SetCustomers(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
