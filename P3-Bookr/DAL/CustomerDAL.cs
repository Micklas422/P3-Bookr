﻿using System;
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
        JsonHandler jsonHandler = new JsonHandler();
        public List<Customer> Loadcustomers()
        {
            List<Customer> customers;
            customers = jsonHandler.ReadJsonObjectFromFile<List<Customer>>("");
            return customers;
        }

        public void SaveCustomers(List<Customer> customers)
        {
            jsonHandler.WriteJsonObjectToFile("", customers);
        }


    }
}
