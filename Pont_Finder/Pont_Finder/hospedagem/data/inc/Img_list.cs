﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem.data.inc
{
    public partial class Img_list : UserControl
    {
        private string imagem;
        Form pedro;
        public Img_list(string foto, Form pedro)
        {
            this.pedro = pedro;
            InitializeComponent();

            pb_img.ImageLocation = foto;
            pb_img.Load();

            this.imagem = foto;

        }

        private void pb_img_Click(object sender, EventArgs e)
        {
            
            Cadastro_Empresa.fotin = imagem;

            Cadastro_Empresa cd = new Cadastro_Empresa(null);
            cd.pn_galery_MouseClick(null, null);
             
            /*Cadastro_Empresa cd = new Cadastro_Empresa(null);
            cd.UpdateGallery(imagem);
            return imagem;*/
        }
    }
}
