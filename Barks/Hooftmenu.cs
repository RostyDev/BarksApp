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

        List<Bark> Barks = new List<Bark>();

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
            flp_EigenBarks.Controls.Clear();
            Barks.Clear();

            BarkFuncties.ActiveAccount = ActiveAccount;

            BarkFuncties.NewBark.Accountid = BarkFuncties.ActiveAccount.idAccounts;
            BarkFuncties.NewBark.BarkDate = DateTime.Now;
            BarkFuncties.NewBark.BarkTitel = tb_titel.Text;
            BarkFuncties.NewBark.BarkText = tb_text.Text;

            BarkFuncties.PostBark();

            tb_titel.Clear();
            tb_text.Clear(); 

            LoadPersonalBarks();
        }

        public void LoadPersonalBarks()
        {
            BarkFuncties.ActiveAccount = ActiveAccount;

            BarkFuncties.GetPersonalBarks();

            foreach (var bark in BarkFuncties.PersoonlijkeBarks)
            {
                Bark Tijdelijk = new Bark();

                Tijdelijk.lb_Accountname.Text = bark.AccountNickname;
                Tijdelijk.lb_titel.Text = bark.BarkTitel;
                Tijdelijk.lbl_datum.Text = bark.BarkDate.ToString();
                Tijdelijk.rhtb_text.Text = bark.BarkText;
                Tijdelijk.Name = "BarkControl " + bark.id;

                Barks.Add(Tijdelijk);
            }

            foreach (var BarkControl in Barks)
            {
                flp_EigenBarks.Controls.Add(BarkControl);
            }
        }

        private void btn_updateBio_Click(object sender, EventArgs e)
        {
            Accountpagina account = new Accountpagina();

            account.Nickname = lbl_accountname.Text;
            account.Bio = rh_bio.Text;

            account.bioupdate();

            MessageBox.Show("Je bio is vernieuwd!");
        }

        private void btn_BarksPage_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent).LoadBarksPage();
            ((Form1)this.Parent).Controls.Remove(this);
        }
    }
}
