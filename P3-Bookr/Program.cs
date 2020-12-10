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
            //Application.Run(new MainMenu);

            Customer c = new Customer(0, true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");
            c.Members.Add(new Member(0, "testPerson", "testTest", true, "0093", "103", "TestvejLejer 30", "member@gmail.com", false, Member.MemberTypes.Renter, "test", "test123"));
            c.Members.Add(new Member(1, "testPerson2", "testTest2", true, "0094", "104", "TestvejLejer 31", "member2@gmail.com", false, Member.MemberTypes.Renter, "test2", "test123"));
            c.Members.Add(new Member(2, "testPerson3", "testTest3", true, "0095", "105", "TestvejLejer 32", "member3@gmail.com", false, Member.MemberTypes.Renter, "test3", "test123"));
            c.Departments.Add(new Department(0, true, "testAfdeling", "afdelingvej 19", "Dette er en test afdeling!"));
            c.Departments.Add(new Department(1, true, "testAfdeling2", "afdelingvej 20", "Dette er en test afdeling2!"));

            int i = 0;
            foreach (Department d in c.Departments)
            {
                for (int k = 0; k < 3; k++)
                {
                    d.Services.Add(new Service(i, $"service{i},{k}", Commons.Enums.ServiceTypes.CommonRoom));
                    d.Services[0].ServiceOfferings.Add(new ServiceOffering(i, $"Offering{i}", 120, 30 + k * 2));
                    i++;
                }
            }

            c.Members[1].Reservations.Add(
                new Reservation(0,
                DateTime.Now,
                new TimePeriod(0,
                DateTime.Now.AddDays(2),
                DateTime.Now.AddDays(3),
                new Payment(0, c.Departments[0].Services[0].ServiceOfferings[0].Price), 
                c.Departments[0].Services[0]),
                c.Departments[0].Services[0].ServiceOfferings[0]));

            IModelComponent m = new ModelComponent(new DataAccesLayer());
            m.customer.Add(c);
            //IFunctionComponentInterface functionComponent = new FunctionComponenten(new ModelComponent(new DataAccesLayer()));
            IFunctionComponentInterface functionComponent = new FunctionComponenten(m);


            UIController uIController = new UIController(functionComponent);
            
        }
    }
}