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
        public Delivery_Alimentos(int idEmpresa)
        {
            InitializeComponent();
            Pagamento_Dinheiro form = new Pagamento_Dinheiro();
            form.Location = new Point(0,0);
            panel_center.Controls.Add(form);
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
            lb_rs_Total.Text = total.ToString("C", CultureInfo.CurrentCulture);
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
