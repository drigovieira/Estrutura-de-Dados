﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie
{
    public partial class ViewPost : Form
    {
        


        public ViewPost()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("Reclame", new FormAvalie());
        }
    }
}
