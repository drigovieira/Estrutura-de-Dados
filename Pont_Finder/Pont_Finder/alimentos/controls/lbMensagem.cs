using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class lbMensagem : UserControl
    {
        private string mensagem;
        public lbMensagem(string message)
        {
            mensagem = message;
            InitializeComponent();
        }

        private void LbMensagem_Load(object sender, EventArgs e)
        {
            lbMSG.Text = mensagem;
        }
    }
}
