using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_Bookr.Windows;
using P3_Bookr.Commons;
using System.IO;
using P3_Bookr.Models;
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
            UIController uIController = new UIController();
            //IMemberDAL memberDAL = new MemberDAL();

            //List<Member> members = new List<Member>();
            //members.Add(new Member());
            //members.Add(new Member());
            //members.Add(new Member());
            //members.Add(new Member());
            //memberDAL.SaveMembers(members);
            //members.Clear();
            //members = memberDAL.LoadMembers(0);
        }
    }
}