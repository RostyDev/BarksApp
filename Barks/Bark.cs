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
    public partial class Bark : UserControl
    {
        public BarkData ThisBark = new BarkData();
        public AccountData ActiveAccount = new AccountData();

        public Bark()
        {
            InitializeComponent();
        }

        private void Bark_Load(object sender, EventArgs e)
        {
            if (ThisBark.Accountid == ActiveAccount.idAccounts)
            {
                this.btn_RemoveBark.Visible = true;
            }
        }

        private void btn_RemoveBark_Click(object sender, EventArgs e)
        {
            BarksAPIfuncties DeleteBarkFunctie = new BarksAPIfuncties();

            DeleteBarkFunctie.DeleteBark = ThisBark;

            if (DeleteBarkFunctie.DeleteBark != null)
            {
                DeleteBarkFunctie.RemoveBark();
                this.Parent.Controls.Remove(this);
            }
            
            DeleteBarkFunctie.DeleteBark = null;
        }
    }
}
