using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem.data.inc
{
    public partial class user_list_reserva : UserControl
    {
        private int id, id_quarto, qtd_pessoas, qtd_disponivel;
        private string nome, empresa, servicos, foto, status;

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente cancelar a reserva?", "Cancelar reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                reserva.Status = false;

                MessageBox.Show("Sua reserva foi cancelada!");
                FormPrincipal.MudarForm("hospedagem", new List_reservas_user(new Hosp_Home()));
            }
            else
            {

            }
        }

        private DateTime data_entrada, data_saida;
        private double valor;
        private bool ativo;

        Quarto quarto = new Quarto();
        classes.Reserva reserva = new classes.Reserva();
        public user_list_reserva(int id, int id_reserva)
        {

            reserva = classes.reserveList.SelectId(id_reserva);

            quarto = roomList.SelectId(reserva.IdQuarto);

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

            this.data_entrada = reserva.Data_inicial;
            this.data_saida = reserva.Data_final;

            InitializeComponent();

            if (quarto.Foto != null)
                pb_hotel.ImageLocation = quarto.Foto;
            else
                pb_hotel.ImageLocation = "..//..//hospedagem//data//images//empresas//offImage.png";

            lb_nome_quarto.Text = this.nome;
            lb_endereco_emp.Text = emp.Endereco;
            lb_data_entrada.Text = data_entrada.ToShortDateString();
            lb_data_saida.Text = data_saida.ToShortDateString();

            lb_tipo_quarto.Text = quarto.Tipo;

            lb_rs.Text = "R$"+reserva.Valor;

            lb_forma_pagamento.Text = "Forma de pagamento: " + reserva.MetodoPagamento;

            label8.Text = "";

        }

        private void user_list_reserva_Load(object sender, EventArgs e)
        {

        }
    }
}
