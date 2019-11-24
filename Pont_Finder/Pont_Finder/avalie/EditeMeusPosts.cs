﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie
{
    public partial class EditeMeusPosts : Form
    {
        PostConstructor post;
        private bool img = false;
        private long postId;


        public EditeMeusPosts(long postId)
        {
            
            InitializeComponent();
            post = PostList.thisPostId(postId);
            this.postId = postId;
        }

        private void tb_resposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_postar_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {

        }

        private void bt_remover_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditeMeusPosts_Load(object sender, EventArgs e)
        {
            label4.Text = Session.Nome;
            cb_pro.Text = post.Tipoproblema;
            tb_loc.Text = post.Localizacao;
            tb_des.Text = post.Desc;
            pb_icone.ImageLocation = post.Img;
            lb_hora.Text = post.Tempohora;
            NomePos.Text = post.Nome;

            if (post.Resolved)
                r.Checked = true;
            else
                nr.Checked = true;
            



        }

        private void bt_postar_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click_1(object sender, EventArgs e)
        {
            post.Tipoproblema = cb_pro.SelectedItem.ToString();
            post.Localizacao = tb_loc.Text;
            post.Desc = tb_des.Text;

        
            if (img)
            {
                if (!Directory.Exists("..//..//avalie//data//imagens//posts"))
                    Directory.CreateDirectory("..//..//avalie//data//imagens//posts");

                pb_icone.Load();
                pb_icone.Image = Image.FromFile(openFileDialog1.FileName);

                Image bmp = new Bitmap(pb_icone.Image);

                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                pb_icone.Image = bmp2;

              
                string link = "..//..//avalie//data//imagens//posts//" + postId + ".jpg";
                pb_icone.Image.Save(link, ImageFormat.Jpeg);
            }

            if(r.Checked)
                post.Resolved = true;
            
            if(nr.Checked)
                post.Resolved = false;
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("Reclame", new FormAvalie());
        }

        private void pb_icone_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openFileDialog1.FileName;
                img = true;
            }
        }

        private void bt_remover_Click_1(object sender, EventArgs e)
        {
            post.Ativo = false;
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}