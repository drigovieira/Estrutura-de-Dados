﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos
{
    public partial class Visualizar_evento : Form
    {
        Classes.CoEvento post;




        Form anterior;
        public Visualizar_evento(int postId, Form anterior)
        {

            
          
            InitializeComponent();
            this.anterior = anterior;
            post = Classes.Eventos_List.thisPostId(postId);

            //Evento:
            lb_nome_evento.Text = post.Nome;
            pb_principal.ImageLocation = post.Imagem1;
            lb_rs_boleto.Text = post.Valor;
            lb_descricao.Text = post.Descricao;
            lb_categoria.Text = post.Categoria;
            lb_data.Text = post.Data;
            lb_horario.Text = post.Horario;
            check();

           


        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("eventos", new eventos.FormEventos());
        }

        private void Visualizar_evento_Load(object sender, EventArgs e)
        {
            

        }

        private void Lb_rs_boleto_Click(object sender, EventArgs e)
        {

        }

        private void Bt_comprar_Click(object sender, EventArgs e)
        {
            if (Session.Online == true)
            {
                eventos.Tela_compra compra = new eventos.Tela_compra(post.Id, new Visualizar_evento(post.Id, anterior));
                FormPrincipal.MudarForm("eventos", compra);
            }
            else
            {
                MessageBox.Show("É preciso estar logado para realizar a compra de ingressos!");
            }
        }

        public void check()
        {
            if (post.IngressoDispinivel == 0)
            {
                bt_comprar.Visible = false;
                esgotado.Visible = true;
            }
            else
            {
                bt_comprar.Visible = true;
                esgotado.Visible = false;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
