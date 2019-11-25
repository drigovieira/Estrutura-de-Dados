using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem
{
    public partial class Hosp_PostCard : UserControl
    {
        private int id, qtd_pessoas, qtd_disponivel;
        private string nome, empresa, servicos, foto, status;
        private double valor;
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
            lb_rs.Text = "R$" + this.valor;
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

        }

        private void Hosp_PostCard_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
