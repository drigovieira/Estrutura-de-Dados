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
    public partial class Card_list_quarto : UserControl
    {
        private int id, qtd_pessoas, qtd_disponivel;
        private string nome, empresa, servicos, foto, status, tipo;
        private double valor;
        private bool ativo;


        private void bt_editar_Click(object sender, EventArgs e)
        {
            hospedagem.Editar_Quarto editQuarto = new hospedagem.Editar_Quarto(id, new Listas_quartos(new Hosp_Home()));
            FormPrincipal.MudarForm("hospedagem", editQuarto);
        }

        Quarto quarto = new Quarto();
        public Card_list_quarto(int id)
        {
            quarto = roomList.SelectId(id);

            Empresa emp = hostList.selectCnpj(quarto.Cnpj_Empresa);

            this.id = quarto.ID;
            this.nome = quarto.NomeQuarto;
            this.qtd_pessoas = quarto.Qtd_Pessoas;
            this.qtd_disponivel = quarto.Qtd_Disponivel;
            this.empresa = emp.Nomefantasia;
            this.servicos = quarto.Servicos;
            this.foto = quarto.Foto;
            this.tipo = quarto.Tipo;
            this.valor = quarto.Valor_Diario;
            this.status = quarto.Status;
            this.ativo = quarto.Ativo;

            InitializeComponent();

            if (quarto.Foto != null)
                pb_hotel.ImageLocation = quarto.Foto;
            else
                pb_hotel.ImageLocation = "..//..//hospedagem//data//images//empresas//offImage.png";

            lb_nome.Text = this.nome;
            lb_value_pessoas.Text = ""+this.qtd_pessoas;
            lb_value_quartos.Text = "" + this.qtd_disponivel;
            lb_rs.Text = "R$" + this.valor;
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente remover o quarto?", "Remover Quarto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                quarto.Ativo = false;

                MessageBox.Show("Quarto removido!");
                FormPrincipal.MudarForm("hospedagem", new Listas_quartos(new Hosp_Home()));
            }
            else 
            { 

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_qtd_quartos_Click(object sender, EventArgs e)
        {

        }

        private void Card_list_quarto_Load(object sender, EventArgs e)
        {

        }
    }
}
