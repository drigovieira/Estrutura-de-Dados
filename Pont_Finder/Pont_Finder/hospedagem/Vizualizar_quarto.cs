using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem
{
    public partial class Vizualizar_quarto : Form
    {

        private int id, qtd_pessoas, qtd_disponivel, telefone_emp;
        private string nome, empresa, servicos, foto, status, tipo, nome_emp, fotos_emp, endereco_emp, descricao_emp, email_emp, logo_emp;
        private long cpf_usuario;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lb_emp_endereco.Text != "")
            {
                Mapa.Mapa map = new Mapa.Mapa(lb_emp_endereco.Text);
                map.ShowDialog();
            }
            else
            {
                MessageBox.Show("Caixa localização não preenchida");
            }
        }

        private void lb_rs_cartao_Click(object sender, EventArgs e)
        {

        }

        private void bt_reservar_Click(object sender, EventArgs e)
        {
            if (Session.Online)
                cpf_usuario = Session.Cpf;

            hospedagem.Reservar_quarto reserva = new Reservar_quarto(id, anterior, dt_ini.Value, dt_fim.Value, cpf_usuario);
            FormPrincipal.MudarForm("hospedagem", reserva);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fotin != null)
            {
                pb_principal.ImageLocation = fotin;
                pb_principal.Load();
            }
        }

        private double valor;

        private bool ativo;

        public static string fotin = null;

        List<string> galeria_fotos = new List<string>();

        Quarto quarto = new Quarto();

        Form anterior;
        public Vizualizar_quarto(int id, Form anterior)
        {
            quarto = roomList.SelectId(id);

            Empresa emp = hostList.selectCnpj(quarto.Cnpj_Empresa);

            //QUARTO
            this.id = quarto.ID;
            this.nome = quarto.NomeQuarto;
            this.qtd_pessoas = quarto.Qtd_Pessoas;
            this.qtd_disponivel = quarto.Qtd_Disponivel;
            this.empresa = emp.Nomefantasia;
            this.servicos = quarto.Servicos;
            this.foto = quarto.Foto;
            this.valor = quarto.Valor_Diario;
            this.status = quarto.Status;
            this.ativo = quarto.Ativo;

            //EMPRESA
            this.nome_emp = emp.Nomeempresa;
            this.fotos_emp = emp.Foto;
            this.endereco_emp = emp.Endereco;
            this.descricao_emp = emp.Descricao;
            this.email_emp = emp.Email;
            this.telefone_emp = emp.Telefone;
            this.logo_emp = emp.Logo;

            this.anterior = anterior;

            InitializeComponent();

            galeria_fotos.Add(foto);

            List<string> fotos_empresa = Directory.GetFiles(fotos_emp, "*.*", SearchOption.TopDirectoryOnly)
            .Where(s => s.EndsWith(".png")
                || s.EndsWith(".jpg")
                || s.EndsWith(".jpeg")).ToList();


            

            foreach (var foto in fotos_empresa)
            {
                galeria_fotos.Add(foto);
            }

        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("hospedagem", anterior);
        }

        private void btn_back_MouseMove(object sender, MouseEventArgs e)
        {
             btn_back.Image = Properties.Resources.back_2;
            //btn_back.ImageLocation = "..//..//Resources//back-2.png";
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_1;
            //btn_back.ImageLocation = "..//..//Resources//back-1.png";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Vizualizar_quarto_Load(object sender, EventArgs e)
        {

            lb_nome_quarto.Text = nome;

            //Valor 15%
            double valor15 = valor * 0.15;
            double valorboleto = valor - valor15;

            lb_rs_boleto.Text = "R$"+valorboleto;
            lb_rs_cartao.Text = "R$" + valor;

            lb_num_quartos.Text = ""+qtd_disponivel;
            lb_num_pessoas.Text = "" + qtd_pessoas;


            //FOTOS
            pb_principal.ImageLocation = foto;

            int x = 5;
            int abcd = 0;

            foreach (var img in galeria_fotos)
            {
                data.inc.Img_list gallery = new data.inc.Img_list(img);

                gallery.Location = new Point((x), 12);
                x = x + gallery.Width + 5;
                pn_galery.Controls.Add(gallery);

                if (abcd == 0)
                {
                    pb_principal.ImageLocation = img;
                    pb_principal.Load();
                    abcd++;
                }
            }


            pb_logo_emp.ImageLocation = logo_emp;
            pb_logo_emp.Load();

            lb_emp_fantasia.Text = "Nome: "+nome_emp;
            lb_emp_email.Text = "Email: " + email_emp;
            lb_emp_telefone.Text = "Telefone: " + telefone_emp;
            lb_emp_endereco.Text = "Endereço: " + endereco_emp;
            lb_emp_descricao.Text = descricao_emp;
        }
    }
}
