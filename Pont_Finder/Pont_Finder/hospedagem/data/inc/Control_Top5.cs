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
    public partial class Control_Top5 : UserControl
    {
        Quarto quarto;
        Empresa empresa;
        public Control_Top5(int id)
        {
            quarto = roomList.SelectId(id);
            Empresa empresa = hostList.selectCnpj(quarto.Cnpj_Empresa);
            InitializeComponent();
        }

        private void Control_Top5_Load(object sender, EventArgs e)
        {
            label1.Text = quarto.NomeQuarto;
            lb_servico.Text = "Localizado em: " + hostList.selectCnpj(quarto.Cnpj_Empresa).Nomefantasia; 
            pb_icone.ImageLocation = quarto.Foto;
        }
    }

}
