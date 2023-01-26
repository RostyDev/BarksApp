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
    public partial class barkspagine : UserControl
    {
        BarksAPIfuncties BarksFuncties = new BarksAPIfuncties();
        List<Bark> AllBarks = new List<Bark>();

        public barkspagine()
        {
            InitializeComponent();
        }

        private void barkspagine_Load(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            flp_BarksPanel.Controls.Clear();
            AllBarks.Clear();

            BarksFuncties.GetAllBarks();

            foreach (var bark in BarksFuncties.AllBarks)
            {
                Bark Tijdelijk = new Bark();

                Tijdelijk.ActiveAccount = Hooftmenu.ActiveAccount;
                Tijdelijk.Dock = DockStyle.Top;
                Tijdelijk.ThisBark = bark;
                Tijdelijk.lb_Accountname.Text = bark.AccountNickname;
                Tijdelijk.lbl_datum.Text = bark.BarkDate.ToString();
                Tijdelijk.lb_titel.Text = bark.BarkTitel;
                Tijdelijk.rhtb_text.Text = bark.BarkText;

                AllBarks.Add(Tijdelijk);
            }

            AllBarks.Reverse();

            foreach (var bark in AllBarks)
            {
                if (bark.ThisBark.BarkActive == 1)
                {
                    flp_BarksPanel.Controls.Add(bark);
                }
            }
        }
    }
}
