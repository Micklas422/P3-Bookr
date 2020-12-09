using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_Bookr.Windows.WindowsInterfaces;

namespace P3_Bookr.Windows.Settings
{
    public partial class SettingsPage : UserControl
    {
        ISettingsUI _handler;
        public SettingsPage(ISettingsUI handler)
        {
            _handler = handler;
            InitializeComponent();
        }
    }
}
