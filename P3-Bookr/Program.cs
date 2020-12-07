using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_Bookr.Windows;
using P3_Bookr.Commons;
using System.IO;
using P3_Bookr.Models;

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
            List<Member> members = new List<Member>();
            members.Add(new Member());
            members.Add(new Member());
            members.Add(new Member());
            JsonHandler jsonHandler = new JsonHandler();
            jsonHandler.WriteJsonObjectToFile(Directory.GetCurrentDirectory(), members);

        }
    }
}