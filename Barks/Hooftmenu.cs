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
        public static AccountData ActiveAccount = new AccountData();

        BarksAPIfuncties BarkFuncties = new BarksAPIfuncties();

        public Hooftmenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hooftmenu_Load(object sender, EventArgs e)
        {
            UpdatePage();
        }

        public void UpdatePage()
        {
            lbl_accountname.Text = InlogScreen.InlogCheck.ActiveAccount.AccountNickname;
            rh_bio.Text = InlogScreen.InlogCheck.ActiveAccount.AccountsBio;
        }

        private void btn_verzend_Click(object sender, EventArgs e)
        {
            BarkFuncties.ActiveAccount = ActiveAccount;

            BarkFuncties.NewBark.Accountid = BarkFuncties.ActiveAccount.idAccounts;
            BarkFuncties.NewBark.BarkDate = DateTime.Now;
            BarkFuncties.NewBark.BarkTitel = tb_titel.Text;
            BarkFuncties.NewBark.BarkText = tb_text.Text;

            BarkFuncties.PostBark();

            tb_titel.Clear();
            tb_text.Clear();    
        }
    }
}
