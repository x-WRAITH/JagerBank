using System;
using System.Windows.Forms;
using config_library;

namespace BankApplication.Forms
{
    public partial class FormSettings : Form
    {      
        public FormSettings()
        {
            InitializeComponent();
            config asd = new config();

            //asd.setUser(Convert.ToString(45));
        }
    }
}
