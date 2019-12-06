using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class Delivery_Alimentos : Form
    {
        public Delivery_Alimentos()
        {
            InitializeComponent();
            Pagamento_Dinheiro form = new Pagamento_Dinheiro();
            form.Location = new Point(0,0);
            panel_center.Controls.Add(form);
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
    }
}
