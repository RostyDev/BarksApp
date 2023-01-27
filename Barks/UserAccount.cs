using BarksAPI2;
using BarksAPI2._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barks
{
    public partial class UserAccount : UserControl
    {
        public static AccountData ClickedUser = new AccountData();

        BarksAPIfuncties BarkFuncties = new BarksAPIfuncties();
        InlogAPIfuncties FollowScript = new InlogAPIfuncties();
        List<Bark> Barks = new List<Bark>();

        public UserAccount()
        {
            InitializeComponent();
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            Update();
        }

        public void UpdatePage()
        {
            lbl_accountname.Text = ClickedUser.AccountNickname;
            rh_bio.Text = ClickedUser.AccountsBio;
        }

        private void btn_Barks_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent).LoadBarksPage();
        }

        public void LoadUserBarks()
        {
            Barks.Clear();
            flp_EigenBarks.Controls.Clear();

            BarkFuncties.ActiveAccount = ClickedUser;

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

            Barks.Reverse();

            foreach (var BarkControl in Barks)
            {
                flp_EigenBarks.Controls.Add(BarkControl);
            }
        }

        private void btn_FollowUser_Click(object sender, EventArgs e)
        {
            FollowScript.ActiveAccount = Hooftmenu.ActiveAccount;
            FollowScript.ClickedAccount = ClickedUser;

            FollowScript.Follow();

            btn_FollowUser.Text = "Following";
        }
    }
}
