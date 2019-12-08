using Pont_Finder.alimentos.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class Delivery_Alimentos : Form
    {
        private int Empresa;
        private float Valor;
        private List<string> Sacola = new List<string>();
        public Delivery_Alimentos(int idEmpresa)
        {
            Empresa = idEmpresa;
            InitializeComponent();            
            lb_nome_restaurante.Text = CompanyList.selectAll()[idEmpresa].NomeFantasia;
            pictureBox3.ImageLocation = CompanyList.selectAll()[idEmpresa].Image;
            foreach (var i in Carrinho.selectAll())
            {
                Pedidos.Items.Add(i.Nome + " x " + i.Quantos);
            }
            lb_data_pedido.Text = DateTime.Today.Date.ToShortDateString();
            float total = 0;
            foreach (var i in Carrinho.selectAll())
            {
                total += i.Preco * i.Quantos;
            }
            subtotal.Text = total.ToString("C", CultureInfo.CurrentCulture);
            taxaEntrega.Text = CompanyList.selectAll()[idEmpresa].Taxa.ToString("C", CultureInfo.CurrentCulture);
            total = total + CompanyList.selectAll()[idEmpresa].Taxa;
            Valor = total;
            lb_rs_Total.Text = total.ToString("C", CultureInfo.CurrentCulture);
            lb_endereco_emp.Text = CompanyList.selectAll()[idEmpresa].Rua + " n° " + CompanyList.selectAll()[idEmpresa].Numero + "\n" + CompanyList.selectAll()[idEmpresa].Bairro;
            rb_Dinheiro.Checked = true;
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Delivery_Alimentos_Load(object sender, EventArgs e)
        {

        }

        private void Lb_endereco_emp_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rb_Dinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Dinheiro.Checked == true)
            {
                label20.Visible = true;
                checkBox1.Visible = true;
                Troco.Visible = true;                
            }
            else
            {
                label20.Visible = false;
                checkBox1.Visible = false;
                Troco.Visible = false;                
            }
        }

        private void Rb_cartao_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cartao.Checked == true)
            {
                label20.Visible = false;
                checkBox1.Visible = false;
                Troco.Visible = false;                
                checkBox1.Checked = false;
                Troco.Clear();
            }
            else
            {
                label20.Visible = true;
                checkBox1.Visible = true;
                Troco.Visible = true;                
            }
        }

        private void Solicitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Por favor, preencha os campos de endereço.","Atenção!");
            }
            else
            {
                if(rb_Dinheiro.Checked == false && rb_cartao.Checked == false)
                {
                    MessageBox.Show("Por favor, escolha um método de pagamento.","Atenção!");
                }
                else
                {
                    try
                    {                        
                        foreach(var item in Carrinho.selectAll())
                        {
                            Sacola.Add(item.Nome + " x " + item.Quantos);
                        }
                        Delivery pedidos = new Delivery();
                        pedidos.Nome = Session.Nome;
                        pedidos.Rua = textBox1.Text;
                        pedidos.Numero = int.Parse(maskedTextBox1.Text);
                        pedidos.Observacoes = textBox3.Text;
                        pedidos.IdUser = Session.Id;
                        pedidos.Referencia = textBox7.Text;
                        pedidos.Pedidos = Sacola;
                        pedidos.Valor = Valor;
                        pedidos.IdEmpresa = Empresa;
                        ListPedidos.Add(pedidos);
                        MessageBox.Show("Pedido registrado!");
                        Reserva_Alimentos reserva = new Reserva_Alimentos(Empresa, CompanyList.selectAll()[Empresa].SttsEntrega);
                        FormPrincipal.MudarForm("alimentos", reserva);
                        Carrinho.Drop();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro: " + erro, "Alerta");
                    }
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Reserva_Alimentos reserva = new Reserva_Alimentos(Empresa, CompanyList.selectAll()[Empresa].SttsEntrega);
            FormPrincipal.MudarForm("alimentos", reserva);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                Troco.Visible = true;
            }
            else
            {
                Troco.Visible = false;
            }
        }
    }
}
