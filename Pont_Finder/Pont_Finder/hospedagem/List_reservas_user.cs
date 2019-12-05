using System;
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
    public partial class List_reservas_user : Form
    {
        Form anterior;
        public List_reservas_user(Form anterior)
        {
            this.anterior = anterior;
            InitializeComponent();
        }

        private void List_reservas_user_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("hospedagem", anterior);
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_1;
        }

        private void btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.Image = Properties.Resources.back_2;
        }
    }
}
