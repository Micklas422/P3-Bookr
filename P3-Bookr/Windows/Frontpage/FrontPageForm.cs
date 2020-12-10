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

namespace P3_Bookr.Windows.Frontpage
{
    public partial class FrontPageForm : UserControl
    {
        IHomepageUI _handler;
        public FrontPageForm(IHomepageUI handler)
        {
            _handler = handler;
            InitializeComponent();
        }

        private void lastUsedServiceTop1_Load(object sender, EventArgs e)
        {

        }
    }
}
