using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarksAPI2;

namespace Barks
{
    public partial class Hooftmenu : UserControl
    {

        public Hooftmenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hooftmenu_Load(object sender, EventArgs e)
        {
            Accountpagina account = new Accountpagina();

            account.Profile();
            lbl_accountname.Text = account.Accountsnickname[0];
            rh_bio.Text= account.AccountsBio[0];
        }
    }
}
