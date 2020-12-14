using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_Bookr.Windows;
using P3_Bookr.Commons;
using System.IO;
using P3_Bookr.Models;
using P3_Bookr.FunctionComponent;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.DAL;

namespace P3_Bookr
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int i = 0;
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");

            for (i = 0; i < 2; i++)
            {
                c.Members.Add(new Member(c, $"testPerson{i}", $"testTest{i}", $"TestvejLejer 3{i}, 9000 Aalborg")
                {
                    IsActive = true,
                    Email = $"test{i}@gmail.com",
                    RentalNumber = $"00000{i}",
                    MemberNumber = $"00000000{i}",
                    MemberType = Member.MemberTypes.Renter,
                    Username = $"test{i}",
                    Password = $"test{i}"
                });
            }

            c.Departments.Add(new Department(c, "testAfdeling") { Adress = "afdelingvej 19, 9000 aalborg", Description = "Dette er en test afdeling!", IsActive = true });
            c.Departments.Add(new Department(c, "testAfdeling2") { Adress = "afdelingvej 20", Description = "Dette er en test afdeling2!", IsActive = true });

            c.Members[0].Departments = c.Departments;
            c.Members[1].Departments.Add(c.Departments[1]);


            i = 0;
            foreach (Department d in c.Departments)
            {
                for (int k = 0; k < 3; k++)
                {
                    d.Services.Add(new Service(i, $"Min service {i} , {k}", Commons.Enums.ServiceTypes.CommonRoom) {Description ="Dette er en test", Location ="Vingevej 19" });
                    d.Services[0].ServiceOfferings.Add(new ServiceOffering($"Offering{i}", 120, 30 + k * 2));
                    i++;
                }
            }

            c.Members[1].Reservations.Add(
                new Reservation(
                DateTime.Now,
                new TimePeriod(
                DateTime.Now.AddDays(2),
                DateTime.Now.AddDays(3), 
                c.Departments[0].Services[0]),
                c.Departments[0].Services[0].ServiceOfferings[0],
                new Payment(DateTime.Now, c.Departments[0].Services[0].ServiceOfferings[0].Price)));

            List<Customer> customers = new List<Customer>();
            customers.Add(c);

            IDataAccesLayer dal = new DataAccesLayer();
            //dal.customerDAL.SetCustomers(customers);
            //dal.departmentDAL.SetDepartments(c.Departments);
            //dal.memberDAL.SetMembers(c.Members);

            IModelComponent m = new ModelComponent(new DataAccesLayer());

            m.customer.Add(c);
            IFunctionComponentInterface functionComponent = new FunctionComponenten(m);

            UIController uIController = new UIController(functionComponent);
            
        }
    }
}