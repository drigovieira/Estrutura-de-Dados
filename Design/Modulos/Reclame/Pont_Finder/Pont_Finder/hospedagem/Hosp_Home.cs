﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem
{
    public partial class Hosp_Home : Form
    {
        private List<Quarto> ListadeQuartos;
        private int pagTotal;
        private int pagAtual;
        private int pagQuant = 8;

        private int y = 5;
        public Hosp_Home()
        {
            //Quantidades de Cards
            pagQuant = 8;

            InitializeComponent();

            bt_Cad_Empresa.Visible = true;
            Btn_Edit_Empresa.Visible = false;
            bt_gerenciar_quartos.Visible = false;

            if (Session.Online)
            {
                Empresa emp = hostList.selectCpf(Session.Cpf);
                if (emp == null)
                {
                    bt_Cad_Empresa.Visible = true;
                    Btn_Edit_Empresa.Visible = false;
                    bt_gerenciar_quartos.Visible = false;
                }
                else
                {

                    bt_Cad_Empresa.Visible = false;
                    Btn_Edit_Empresa.Visible = true;
                    bt_gerenciar_quartos.Visible = true;
                }
            }

            

            ListadeQuartos = roomList.quartosAtivos();
            ListadeQuartos.Reverse();

            pagTotal = ListadeQuartos.Count;
            if ((pagTotal % pagQuant) != 0)
            {
                pagTotal = (pagTotal / pagQuant);
                pagTotal++;
            }
            else
            {
                pagTotal = pagTotal / pagQuant;
            }
            pagAtual = 1;

            lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;


        }


        private void Hosp_Home_Load(object sender, EventArgs e)
        {
            int i = 0;

            foreach (var item in ListadeQuartos)
            {
                if (i >= pagQuant)
                    break;
                Hosp_PostCard a = new Hosp_PostCard(item.ID);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
                panel_center.Height = panel_center.Height + 180;
                panel_center.Controls.Add(a);
                i++;
            }

        }

        

        private void Bt_Cad_Empresa_Click(object sender, EventArgs e)
        {   
            
            if (Session.Online)
            {
                hospedagem.Cadastro_Empresa cadEmpre = new Cadastro_Empresa();
                FormPrincipal.MudarForm("hospedagem", cadEmpre);
            }
            else
            {
                MessageBox.Show("Faça login com sua conta para poder cadastrar sua empresa!");
            }
                
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Edit_Empresa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EDITAR EMPRESA");
        }

        private void bt_gerenciar_quartos_Click(object sender, EventArgs e)
        {
            hospedagem.Listas_quartos listaQuartos = new Listas_quartos();
            FormPrincipal.MudarForm("hospedagem", listaQuartos);
        }

        private void panel_center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_prox_Click(object sender, EventArgs e)
        {

            if (pagAtual < pagTotal)
            {
                y = 5;
                panel_center.Height = 180;
                panel_center.Controls.Clear();

                int pg = (pagAtual * pagQuant);

                for (int i = 0; i < pagQuant; i++)
                {
                    if (pg + i < ListadeQuartos.Count)
                    {
                        Hosp_PostCard a = new Hosp_PostCard(ListadeQuartos[pg + i].ID);
                        a.Location = new Point(0, (y));
                        y = y + a.Height + 5;
                        panel_center.Height = panel_center.Height + 180;
                        panel_center.Controls.Add(a);
                    }

                }

                pagAtual++;
                lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
            }

        }

        private void bt_ant_Click(object sender, EventArgs e)
        {
            if (pagAtual > 1)
            {
                y = 5;
                panel_center.Height = 180;
                panel_center.Controls.Clear();

                int pg = ((pagAtual - 2) * pagQuant);

                for (int i = 0; i < pagQuant; i++)
                {
                    if (pg + i < ListadeQuartos.Count)
                    {
                        Hosp_PostCard a = new Hosp_PostCard(ListadeQuartos[pg + i].ID);
                        a.Location = new Point(0, (y));
                        y = y + a.Height + 5;
                        panel_center.Height = panel_center.Height + 180;
                        panel_center.Controls.Add(a);
                    }
                }
                pagAtual--;

                lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
            }

        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {

            ListadeQuartos.Clear();
            foreach (var item in roomList.Quartos)
            {
                if (item.NomeQuarto.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                {
                    ListadeQuartos.Add(item);
                }
            }

            y = 5;
            panel_center.Height = 180;
            panel_center.Controls.Clear();
            int i = 0;

            ListadeQuartos.Reverse();

            pagTotal = ListadeQuartos.Count;
            if ((pagTotal % pagQuant) != 0)
            {
                pagTotal = (pagTotal / pagQuant);
                pagTotal++;
            }
            else
            {
                pagTotal = pagTotal / pagQuant;
            }
            pagAtual = 1;

            lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;


            foreach (var item in ListadeQuartos)
            {
                if (i >= pagQuant)
                    break;
                Hosp_PostCard a = new Hosp_PostCard(item.ID);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
                panel_center.Height = panel_center.Height + 180;
                panel_center.Controls.Add(a);
                i++;
            }
        }

        private void Tb_pesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListadeQuartos.Clear();
            foreach (var item in roomList.Quartos)
            {
                if (item.NomeQuarto.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                {
                    ListadeQuartos.Add(item);
                }
            }

            y = 5;
            panel_center.Height = 180;
            panel_center.Controls.Clear();
            int i = 0;

            ListadeQuartos.Reverse();

            pagTotal = ListadeQuartos.Count;
            if ((pagTotal % pagQuant) != 0)
            {
                pagTotal = (pagTotal / pagQuant);
                pagTotal++;
            }
            else
            {
                pagTotal = pagTotal / pagQuant;
            }
            pagAtual = 1;

            lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;


            foreach (var item in ListadeQuartos)
            {
                if (i >= pagQuant)
                    break;
                Hosp_PostCard a = new Hosp_PostCard(item.ID);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
                panel_center.Height = panel_center.Height + 180;
                panel_center.Controls.Add(a);
                i++;
            }
        }

        private void Tb_pesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
