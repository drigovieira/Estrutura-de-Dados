﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class PerfilEmpresa : Form
    {


        public PerfilEmpresa()
        {

            InitializeComponent();
        }

        private void NomeFantasia_Click(object sender, EventArgs e)
        {

        }

        private void DescricaoEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Setor_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }
    }
}
