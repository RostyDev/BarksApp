using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        InlogScreen Inloggen = new InlogScreen();
        Hooftmenu HooftmenuScreen = new Hooftmenu();
        AanmeldFormulier AanmeldForm = new AanmeldFormulier();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInlogForm();
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_FullScreen_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
        }

        public void LoadHoofdScreen()
        {
            this.Controls.Add(HooftmenuScreen);
            HooftmenuScreen.Dock = DockStyle.Fill;
        }

        public void LoadAanmeldForm()
        {
            this.Controls.Add(AanmeldForm);
            AanmeldForm.Dock = DockStyle.Fill;
        }

        public void LoadInlogForm()
        {
            this.Controls.Add(Inloggen);
            Inloggen.Dock = DockStyle.Fill;
        }
    }
}
