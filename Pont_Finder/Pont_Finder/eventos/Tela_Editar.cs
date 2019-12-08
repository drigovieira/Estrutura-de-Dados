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
    public partial class Tela_Editar : Form
    {
        Classes.CoEvento evento;
        public Tela_Editar(int id)
        {
            evento = Classes.Eventos_List.thisPostId(id);
            InitializeComponent();
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("eventos", new eventos.ListEvent());
        }
    }
}
