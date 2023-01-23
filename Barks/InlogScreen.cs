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
    public partial class InlogScreen : UserControl
    {
        bool RealWW = false;
        //public bool Ingelogged = false;

        public InlogScreen()
        {
            InitializeComponent();
        }

        private void btn_Inloggen_Click(object sender, EventArgs e)
        {
            tb_Email.Text.ToLower();

            InlogAPIfuncties InlogCheck = new InlogAPIfuncties();

            InlogCheck.EmailAdres = tb_Email.Text;

            //Proberen in te loggen\\
            try
            {
                InlogCheck.GetAccount();
            }
            catch (Exception)              //Als het niet lukt\\
            {
                string message = "Emailadres is verkeerd of bestaat nog niet.";
                string caption = "Email fout";
                MessageBox.Show(message, caption);
                throw;
            }

            //Als er geen WW is in gevult\\
            if (tb_UserWW.Text == "")
            {
                string message = "Vul eerst een wachtWoord in!";
                string caption = "WachtWoord fout";
                MessageBox.Show(message, caption);
            }

            //Het Hashen van het in gevulde WW en Checken of het het goede wachtwoord is\\
            InlogCheck.Hash(tb_UserWW.Text);
            if (InlogCheck.HashWW == InlogCheck.ActiveAccount.Password)
            {
                RealWW = true;
            }

            //Checken of de gebruiker kan inloggen\\
            if (tb_Email.Text == InlogCheck.EmailAdres && RealWW == true)
            {
                //Laad het hoofd scherm in\\
                ((Form1)this.Parent).LoadHoofdScreen();
                this.Dispose();
            }
            else                     //Als het fout gaat ligt het aan het wachtwoord\\
            {
                string message = "Verkeerde wachtwoord!";
                string caption = "WachtWoord fout";
                MessageBox.Show(message, caption);

                tb_UserWW.Text = "";
            }

        }

        private void lb_NoAccount_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent).LoadAanmeldForm();
            ((Form1)this.Parent).Controls.Remove(this);
        }
    }
}
