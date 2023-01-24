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
using BarksAPI2._0;

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
            lbl_accountname.Text = InlogScreen.InlogCheck.ActiveAccount.AccountNickname;
            rh_bio.Text = InlogScreen.InlogCheck.ActiveAccount.AccountsBio;
        }

        private void btn_verzend_Click(object sender, EventArgs e)
        {
            Accountpagina account = new Accountpagina();

            account.titel = tb_titel.Text;
            account.text = tb_text.Text;
            account.sendBark();

            tb_titel.Clear();
            tb_text.Clear();    
        }
    }
}
