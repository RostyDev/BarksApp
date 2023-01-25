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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Barks
{
    public partial class AanmeldFormulier : UserControl
    {
        string TruePassword;

        public AccountData NieuwAccount = new AccountData();
        public InlogAPIfuncties AanmeldFunctie = new InlogAPIfuncties();

        public AanmeldFormulier()
        {
            InitializeComponent();
        }

        private void lb_YesAccount_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent).LoadInlogForm();

            if (((Form1)this.Parent).Controls.Contains(this))
            {
                ((Form1)this.Parent).Controls.Remove(this);
            }
        }

        private void btn_Aanmelden_Click(object sender, EventArgs e)
        {
            int Case = 0;

            AanmeldFunctie.CheckEmails();

            if (tb_Email.Text == "" || cb_Age.Text == "")
            {
                Case = 1;
            }
            else if (tb_Nickname.Text == "" || tb_RealName.Text == "")
            {
                Case = 1;
            }
            else if (tb_Password.Text == "" || tb_Password2.Text == "")
            {
                Case = 1;
            }
            else if (tb_Adres1.Text == "" || tb_Adres2.Text == "" || tb_Postcode.Text == "")
            {
                Case = 1;
            }
            else if (tb_Password.Text != tb_Password2.Text)
            {
                Case = 2;
            }
            else if (AanmeldFunctie.Emails.Contains(tb_Email.Text))
            {
                Case = 3;
            }
            else
            {
                AanmeldFunctie.Hash(tb_Password.Text);
                Case = 4;
            }


            switch (Case)
            {
                case 1:
                    string Message0 = "Check of je alle velden hebt ingevult!";
                    MessageBox.Show(Message0);
                    break;
                case 2:
                    string Message1 = "Check of beide wachtwoorden overeen komen!";
                    MessageBox.Show(Message1);
                    break;
                case 3:
                    tb_Email.Text = "";
                    string Message2 = "Dat emailAdres word al gebruikt!";
                    MessageBox.Show(Message2);
                    break;
                case 4:

                    NieuwAccount.Emailadress = tb_Email.Text.ToLower();
                    NieuwAccount.AccountNickname = tb_Nickname.Text;
                    NieuwAccount.AccountRealname = tb_RealName.Text;
                    NieuwAccount.AccountAge = int.Parse(cb_Age.Text);
                    NieuwAccount.Adres = tb_Adres1.Text + tb_Adres2.Text;
                    NieuwAccount.Postcode = tb_Postcode.Text;
                    NieuwAccount.Password = AanmeldFunctie.HashWW;

                    AanmeldFunctie.NieuwAccount = NieuwAccount;
                    AanmeldFunctie.AddAccount();

                    tb_Email.Text = string.Empty;
                    tb_Nickname.Text = string.Empty;
                    tb_RealName.Text = string.Empty;
                    tb_Password.Text = string.Empty;
                    tb_Password2.Text = string.Empty;
                    tb_Adres1.Text = string.Empty;
                    tb_Adres2.Text = string.Empty;
                    cb_Age.Text = string.Empty;

                    AanmeldFunctie.ActiveAccount = AanmeldFunctie.NieuwAccount;

                    ((Form1)this.Parent).LoadHoofdScreen();

                    if (((Form1)this.Parent).Controls.Contains(this))
                    {
                        ((Form1)this.Parent).Controls.Remove(this);
                    }
                    break;
            }
        }

        private void cb_Age_TextUpdate(object sender, EventArgs e)
        {
            int[] Tijdelijk = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            if (!cb_Age.Text.Contains(Tijdelijk.ToString()))
            {
                cb_Age.Text = "";
                string Message = "Kies 1 van de opties. Zit uw leeftijd er niet bij? Dan kunt u niet op dit platform.";
                MessageBox.Show(Message);
            }
        }
    }
}
