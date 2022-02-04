using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication.Forms
{
    public partial class FormDashboard : Form
    {
        public FormMainMenu fmm = new FormMainMenu();
        public FormDashboard(User user)
        {
            
            InitializeComponent();
            label_Balance.Text = user.balance + " PLN";
            label_Name.Text = user.firstname;
        }
    }
}
