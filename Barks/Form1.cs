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
        Hooftmenu HoofdmenuScreen = new Hooftmenu();
        AanmeldFormulier AanmeldForm = new AanmeldFormulier();
        barkspagine BarksPagina = new barkspagine();

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

        public void LoadHoofdScreen()
        {
            this.Controls.Add(HoofdmenuScreen);
            HoofdmenuScreen.Dock = DockStyle.Fill;

            HoofdmenuScreen.UpdatePage();
            HoofdmenuScreen.LoadPersonalBarks();

            btn_Uitlog.Visible = true;
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

            if (this.Controls.Contains(HoofdmenuScreen))
            {
                this.Controls.Remove(HoofdmenuScreen);
            }
            else if (this.Controls.Contains(BarksPagina))
            {
                this.Controls.Remove(BarksPagina);
            }
        }

        public void LoadBarksPage()
        {
            this.Controls.Add(BarksPagina);
            BarksPagina.Reload();
            BarksPagina.Dock = DockStyle.Fill;
        }

        private void btn_Uitlog_Click(object sender, EventArgs e)
        {
            LoadInlogForm();
            btn_Uitlog.Visible = false;
        }

        private void lb_Logo_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(Inloggen) || !this.Controls.Contains(AanmeldForm))
            {
                UnloadMainPages();
                HoofdmenuScreen.ClearPersonalbarks();
                LoadHoofdScreen();
            }
        }

        private void UnloadMainPages()
        {
            if (this.Controls.Contains(BarksPagina))
            {
                this.Controls.Remove(BarksPagina);
            }
        }
    }
}
