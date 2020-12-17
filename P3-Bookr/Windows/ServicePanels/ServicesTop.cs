using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_Bookr.Models;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Windows
{
    public partial class ServicesTop : UserControl
    {
        public ServicesTop(IService service)
        {
            InitializeComponent();

            this.LastUsedTopLabel.Text = Enum.GetName(typeof(ServiceTypesTitel), service.ServiceType);
        }
    }
}
