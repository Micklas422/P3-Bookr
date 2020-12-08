﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    interface ICustomerDAL
    {
        List<Customer> GetCustomers();
        void SetCustomers(List<Customer> customers);
    }
}