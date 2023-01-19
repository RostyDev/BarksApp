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

        public InlogScreen()
        {
            InitializeComponent();
        }

        private void InlogScreen_Load(object sender, EventArgs e)
        {

        }

        private void btn_Inloggen_Click(object sender, EventArgs e)
        {
            InlogAPIfuncties InlogCheck = new InlogAPIfuncties();

            InlogCheck.EmailAdres = tb_Email.Text;

            try
            {
                InlogCheck.Login();
            }
            catch (Exception)
            {
                string message = "Emailadres is verkeerd of bestaat nog niet.";
                string caption = "Email fout";
                MessageBox.Show(message, caption);
                throw;
            }

            InlogCheck.Hash(tb_UserWW.Text);
            if (InlogCheck.HashWW == InlogCheck.AccountPassword)
            {
                RealWW = true;
            }

            if (tb_Email.Text == InlogCheck.EmailAdres && RealWW == true)
            {
                this.Visible = false;
            }
        }
    }
}
