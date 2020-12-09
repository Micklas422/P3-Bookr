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

namespace P3_Bookr.Windows.History
{
    public partial class HistoryPage : UserControl
    {
        IHistorikUI _handler;
        public HistoryPage(IHistorikUI handler)
        {
            InitializeComponent();
            _handler = handler;
        }

        private void HistoryPage_Load(object sender, EventArgs e)
        {

        }
    }
}
