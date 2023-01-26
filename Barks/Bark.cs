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
        public int id;
        public int idAccount;
        public int IsActive;

        public Bark()
        {
            InitializeComponent();
        }

        private void Bark_Load(object sender, EventArgs e)
        {

        }

        private void btn_RemoveBark_Click(object sender, EventArgs e)
        {
            
        }
    }
}
