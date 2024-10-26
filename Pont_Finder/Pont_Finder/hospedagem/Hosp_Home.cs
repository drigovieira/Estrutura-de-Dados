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

            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = dateTimePicker2.Value.AddDays(1);

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
            panel_tops.Controls.Clear();

            int j = 0;
            int k = 5;
            foreach (var item in classes.reserveList.Tops())
            {
                if (j >= 5)
                    break;
                data.inc.Control_Top5 a = new data.inc.Control_Top5(item.ID);
                a.Location = new Point(6, (k));
                k = k + a.Height + 5;
                panel_tops.Controls.Add(a);
                j++;
            }


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

            Propaganda_modulos prop = new Propaganda_modulos();
            prop.Location = new Point(5, 25);
            painel_propaganda.Controls.Add(prop);

            Propaganda_externa propexter = new Propaganda_externa();
            propexter.Location = new Point(5, 25);
            pn_propa_externa.Controls.Add(propexter);

        }

        

        private void Bt_Cad_Empresa_Click(object sender, EventArgs e)
        {   
            
            if (Session.Online)
            {
                hospedagem.Cadastro_Empresa cadEmpre = new Cadastro_Empresa(new Hosp_Home());
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
            Empresa emp = hostList.selectCpf(Session.Cpf);
            if (emp != null)
            {
                long cpf = Session.Cpf;
                hospedagem.Editar_Empresa edita_empresa = new Editar_Empresa(new Hosp_Home(), cpf);
                FormPrincipal.MudarForm("hospedagem", edita_empresa);
        
            }
        }

        private void bt_gerenciar_quartos_Click(object sender, EventArgs e)
        {
            hospedagem.Listas_quartos listaQuartos = new Listas_quartos(new Hosp_Home());
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



        private void DateTimePicker1_ValueChanged(Object sender, EventArgs e)
        {

            ListadeQuartos.Clear();

            foreach (var item in roomList.Quartos)
            {

                int contador = 0;

                foreach (var reservas in classes.reserveList.selectAll())
                {
                    if (dateTimePicker1.Value <= reservas.Data_final)
                    {
                        contador++;
                    }
                }

                if (item.Qtd_Disponivel > contador)
                {
                    if (item.NomeQuarto.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                    {
                        ListadeQuartos.Add(item);
                    }
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




        private void DateTimePicker2_ValueChanged(Object sender, EventArgs e)
        {

            ListadeQuartos.Clear();

            foreach (var item in roomList.Quartos)
            {

                int contador = 0;

                foreach (var reservas in classes.reserveList.selectAll())
                {
                    if (dateTimePicker1.Value <= reservas.Data_final)
                    {
                        contador++;
                    }
                }

                if (item.Qtd_Disponivel > contador)
                {
                    if (item.NomeQuarto.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                    {
                        ListadeQuartos.Add(item);
                    }
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





        private void bt_pesquisar_Click(object sender, EventArgs e)
        {

            ListadeQuartos.Clear();

            foreach (var item in roomList.Quartos)
            {

                int contador = 0;

                foreach (var reservas in classes.reserveList.selectAll())
                {
                    if (dateTimePicker1.Value <= reservas.Data_final)
                    {
                        contador++;
                    }
                }

                if (item.Qtd_Disponivel > contador)
                {
                    if (item.NomeQuarto.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                    {
                        ListadeQuartos.Add(item);
                    }
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
            tb_pesquisar.MaxLength = 50;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                hospedagem.List_reservas_user user_reservas = new List_reservas_user(new Hosp_Home());
                FormPrincipal.MudarForm("hospedagem", user_reservas);
            }
            else
            {
                MessageBox.Show("Você precisa fazer login para acessar a lista de reservas!");
            }
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            rb_casal.Checked = false;
            rb_solteiro.Checked = false;
            rb_outros.Checked = false;

            tb_pesquisar.Text = "";

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now.AddDays(1);

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
    }
}
