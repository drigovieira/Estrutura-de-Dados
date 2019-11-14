using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos
{
    public partial class FormEventos : Form
    {
        

        public FormEventos()
        {
            InitializeComponent();
        }

        private void Btn_com_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Session.Online)
                FormPrincipal.MudarForm("Eventos", new CadEmpresa());
            else
                MessageBox.Show("É necessário estar logado");          
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Session.Online)
                FormPrincipal.MudarForm("Eventos", new Post_Eventos());
            else
                MessageBox.Show("É necessário estar logado");
        }
    }
}
