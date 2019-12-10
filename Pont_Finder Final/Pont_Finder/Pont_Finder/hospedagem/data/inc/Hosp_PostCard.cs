using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Pont_Finder.hospedagem
{
    public partial class Hosp_PostCard : UserControl
    {
        private int id, qtd_pessoas, qtd_disponivel;
        private string nome, empresa, servicos, foto, status;
        private double valor;
        List<string> icones = new List<string>();

        private void pn_icons_hotel_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool ativo;
        
        public Hosp_PostCard(int id)
        {
            Quarto quarto = new Quarto();
            quarto = roomList.SelectId(id);


            Empresa emp = hostList.selectCnpj(quarto.Cnpj_Empresa);

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


            InitializeComponent();

            if (quarto.Foto != null)
                pb_hotel.ImageLocation = quarto.Foto;
            else
                pb_hotel.ImageLocation = "..//..//hospedagem//data//images//empresas//offImage.png";


            lb_nome.Text = this.nome;
            lb_empresa.Text = "Localizado em: " + this.empresa;
            lb_rs.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.valor);


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



            

        }

        private void bt_visualizar_Click(object sender, EventArgs e)
        {
            hospedagem.Vizualizar_quarto vizQuarto = new hospedagem.Vizualizar_quarto(id,new Hosp_Home());
            FormPrincipal.MudarForm("hospedagem",vizQuarto);
        }

        private void lb_rs_Click(object sender, EventArgs e)
        {
        }

        private void Hosp_PostCard_Load(object sender, EventArgs e)
        {
            int xx = 5;

            foreach (var item in icones)
            {
                data.inc.icon icone_uc = new data.inc.icon(item);

                icone_uc.Location = new Point((xx), 0);
                xx = xx + icone_uc.Width + 5;
                pn_icons_hotel.Width = pn_icons_hotel.Width + 5;
                pn_icons_hotel.Controls.Add(icone_uc);
            }
        }

        private void Hosp_PostCard_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
