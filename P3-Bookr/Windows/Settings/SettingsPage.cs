using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_Bookr.Models;
using P3_Bookr.Windows.WindowsInterfaces;

namespace P3_Bookr.Windows.Settings
{
    public partial class SettingsPage : UserControl
    {
        ISettingsUI _handler;
        public SettingsPage(ISettingsUI handler, IMember member)
        {
            _handler = handler;
            InitializeComponent();
            this.personalInfo1.EmailEdit.Text = member.Email;
            this.personalInfo1.MemberNumberEdit.Text = member.MemberNumber;
            this.personalInfo1.NameEdit.Text = member.FirstName + " " + member.LastName;
            string hidePassword = "";
            foreach (char c in member.Password)
            {
                hidePassword += "*";
            }
            this.personalInfo1.PasswordEdit.Text = hidePassword;
        }
    }
}
