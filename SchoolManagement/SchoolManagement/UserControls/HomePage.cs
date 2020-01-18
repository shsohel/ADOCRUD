using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.UserControls
{
    public partial class HomePageUC : UserControl
    {

        private static HomePageUC _instancehpa;
        public static HomePageUC Instancehpg
        {
            get
            {
                if (_instancehpa == null)
                    _instancehpa = new HomePageUC();
                return _instancehpa;
            }
        }


        public HomePageUC()
        {
            InitializeComponent();
        }
    }
}
