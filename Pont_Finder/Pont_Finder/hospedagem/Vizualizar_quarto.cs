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
        Form anterior;
        private int id, qtd_pessoas, qtd_disponivel;
        private string nome, empresa, servicos, foto, status, tipo, nome_emp, fotos_emp, endereco_emp, descricao_emp, email_emp, logo_emp, ambiente;
        private long cpf_usuario, telefone_emp;
        List<string> icones = new List<string>();
        List<string> ambientes = new List<string>();

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
        //Painel SERVICOS HOTEL
        private void pn_icons_hotel_Paint(object sender, PaintEventArgs e)
        {

        }

        //Painel SERVICOS QUARTO
        private void pn_icons_quarto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_reservar_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {    
            cpf_usuario = Session.Cpf;

            hospedagem.Reservar_quarto reserva = new Reservar_quarto(id, anterior, dt_ini.Value, dt_fim.Value, cpf_usuario);
            FormPrincipal.MudarForm("hospedagem", reserva);
            }
            else
            {
                MessageBox.Show("Você deve estar logado para realizar uma reserva.");
            }

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
            //this.ambiente = quarto.Ambiente;

            //EMPRESA
            this.nome_emp = emp.Nomeempresa;
            this.fotos_emp = emp.Foto;
            this.endereco_emp = emp.Endereco;
            this.descricao_emp = emp.Descricao;
            this.email_emp = emp.Email;
            this.telefone_emp = emp.Telefone;
            this.logo_emp = emp.Logo;
            this.ambiente = emp.Ambiente;
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




            //LISTA DE ICONES

            if (servicos.Contains("Café da tarde") == true)
            {
                string caminho = "..\\..\\hospedagem\\data\\icones\\cafe.png";
                icones.Add(caminho);
            }

            if (servicos.Contains("Ar Condicionado") == true)
            {
                string caminho = "..\\..\\hospedagem\\data\\icones\\Ar_condicionado(1).png";
                icones.Add(caminho);
            }

            if (servicos.Contains("Café da manhã") == true)
            {
                string caminho = "..\\..\\hospedagem\\data\\icones\\breakfast.png";
                icones.Add(caminho);
            }

            if (servicos.Contains("Almoço") == true)
            {
                
                string caminho = "..\\..\\hospedagem\\data\\icones\\almoço.png";
                icones.Add(caminho);
            }

            if (servicos.Contains("TV a cabo") == true)
            {
                string caminho = "..\\..\\hospedagem\\data\\icones\\tv.png";
                icones.Add(caminho);
            }

            if (servicos.Contains("Espaço PET") == true)
            {
                string caminho = "..\\..\\hospedagem\\data\\icones\\pet.png";
                icones.Add(caminho);
            }
            if (servicos.Contains("Wi-fi") == true)
            {
                string caminho = "..\\..\\hospedagem\\data\\icones\\wifi.png";
                icones.Add(caminho);
            }

            //Lista de Ambiente do HOTEL
            if (ambiente.Contains("Estacionamento") == true)
            {
                string direto = "..\\..\\hospedagem\\data\\icones\\parking.png";
                ambientes.Add(direto);
            }
            if (ambiente.Contains("Piscina") == true)
            {
                string direto = "..\\..\\hospedagem\\data\\icones\\piscina.png";
                ambientes.Add(direto);
            }
            if (ambiente.Contains("Sala de Jogos") == true)
            {
                string direto = "..\\..\\hospedagem\\data\\icones\\sala_de_Jogos.png";
                ambientes.Add(direto);
            }
            if (ambiente.Contains("Academia") == true)
            {
                string direto = "..\\..\\hospedagem\\data\\icones\\academia.png";
                ambientes.Add(direto);
            }

        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("hospedagem",new Hosp_Home());
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
            int xx = 5;
            int v = 5;

            //Serviços do hotel
            foreach (var ambi in ambientes)
            {
                data.inc.amb ambiente_ho = new data.inc.amb(ambi);

                ambiente_ho.Location = new Point((xx), 0);
                xx = xx + ambiente_ho.Width + 5;
                pn_icons_hotel.Width = pn_icons_hotel.Width + 50;
                pn_icons_hotel.Controls.Add(ambiente_ho);
            }
            //Serviços de Quarto
            foreach (var item in icones)
            {
                data.inc.icon icone_uc = new data.inc.icon(item);

                icone_uc.Location = new Point((v), 0);
                v = icone_uc.Width + v + 5;
                pn_icons_quarto.Width = pn_icons_quarto.Width + 180;
                pn_icons_quarto.Controls.Add(icone_uc);
            }
            


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
                
    
 