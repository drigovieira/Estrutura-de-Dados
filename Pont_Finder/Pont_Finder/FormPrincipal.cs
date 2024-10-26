﻿using Pont_Finder.servicos;
using Pont_Finder.hospedagem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Pont_Finder.alimentos.classes;

namespace Pont_Finder
{
    public partial class FormPrincipal : Form
    {
        static Color barra = Color.FromArgb(64, 64, 64);
        static Panel navbar;
        static Panel painel;

        public FormPrincipal()
        {
           
            InitializeComponent();
            
            panel1.BackColor = barra;
            navbar = panel1;
            painel = panelHome;

            if (!Session.Online)
            {
                pb_userIcone.Visible = false;
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            bt_Sair.Visible = false;
            username.Text = "";
            formHome fh = new formHome();
            fh.TopLevel = false;
            panelHome.Controls.Add(fh);
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCriarConta fCC = new formCriarConta();
            fCC.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formLogin fL = new formLogin();
            fL.ShowDialog();
            if (Session.Online)
            {
                bt_FazerLogin.Visible = false;
                bt_CriarConta.Visible = false;
                username.Text = Session.Nome.Split(' ')[0];
                bt_Sair.Visible = true;
                formHome fh = new formHome();
                MudarForm("", fh);
                if (Session.Online)
                {
                    pb_userIcone.Visible = true;
                    pb_userIcone.ImageLocation = Session.Image;
                    pb_userIcone.Load();
                }
            }
        }

        private void Button_salvar_Click(object sender, EventArgs e)
        {
            classes.Config.Save();
            MessageBox.Show("Dados Salvos");         
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        public static void Mudar(String x = "")
        {
            painel.Controls.Clear();
            switch (x)
            {
                case "Alimentos":
                    formAlimentos formA = new formAlimentos
                    {
                        TopLevel = false
                    };
                    painel.Controls.Add(formA);
                    formA.Show();
                    navbar.BackColor = Color.Red;
                    break;

                case "Serviços":
                   FormServicos form = new FormServicos
                   {
                        TopLevel = false
                    };
                    painel.Controls.Add(form);
                    form.Show();
                    navbar.BackColor = Color.FromArgb(30, 125, 204);
                    break;

                case "Hospedagem":
                    hospedagem.Hosp_Home Hosp = new Hosp_Home();
                    {
                        Hosp.TopLevel = false;
                    }
                    painel.Controls.Add(Hosp);
                    Hosp.Show();
                    navbar.BackColor = Color.MediumSeaGreen;
                    break;

                case "Eventos":
                    eventos.FormEventos fEvent = new eventos.FormEventos();
                    {
                        fEvent.TopLevel = false;
                    }
                    painel.Controls.Add(fEvent);
                    fEvent.Show();
                    navbar.BackColor = Color.FromArgb(129, 78, 210);
                    break;
                case "Reclame":
                    FormAvalie formAvalie = new FormAvalie();
                    {
                        formAvalie.TopLevel = false;
                    }
                    painel.Controls.Add(formAvalie);
                    formAvalie.Show();
                    navbar.BackColor = Color.DeepSkyBlue;
                    break;
                default:
                    formHome fh = new formHome
                    {
                        TopLevel = false
                    };
                    painel.Controls.Add(fh);
                    fh.Show();
                    navbar.BackColor = barra;
                    break;

            }
        }

        public static void MudarForm(string modulo, Form formA)
        {
            
            painel.Controls.Clear();
            painel.Refresh();
            formA.TopLevel = false;          
            painel.Controls.Add(formA);
            formA.Show();
          


            switch (modulo.ToLower().Replace("ç", "c"))
            {
                case "alimentos":
                    navbar.BackColor = Color.Red;
                    break;
                case "servicos":
                    navbar.BackColor = Color.FromArgb(30, 125, 204);
                    break;
                case "hospedagem":
                    navbar.BackColor = Color.MediumSeaGreen;
                    break;
                case "eventos":
                    navbar.BackColor = Color.FromArgb(129, 78, 210);
                    break;
                case "reclame":                
                    navbar.BackColor = Color.DeepSkyBlue;
                    break;
                default:
                    navbar.BackColor = barra;
                    break;
            }
        }

        public static void padrao()
        {
            navbar.BackColor = barra;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mudar();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Carrinho.Drop();
            Mudar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void Bt_Sair_Click(object sender, EventArgs e)
        {
            Session.Deslogar();
            bt_Sair.Visible = false;
            bt_FazerLogin.Visible = true;
            bt_CriarConta.Visible = true;
            username.Text = "";  
            formHome fh = new formHome();     
            MudarForm("", fh);
            pb_userIcone.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pb_userIcone_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
