﻿using System;
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
    public partial class AanmeldFormulier : UserControl
    {
        public AanmeldFormulier()
        {
            InitializeComponent();
        }

        private void lb_YesAccount_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent).LoadInlogForm();
            ((Form1)this.Parent).Controls.Remove(this);
        }

        private void btn_Aanmelden_Click(object sender, EventArgs e)
        {

        }
    }
}