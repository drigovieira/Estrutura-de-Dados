using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class FormSolicitados : Form
    {
        public FormSolicitados()
        {
            InitializeComponent();
        }

        private void Visualizar_Solicitado_User_Load(object sender, EventArgs e)
        {
            Form ant = new FormSolicitados();
            int y = 5;
            int i = 0;

            //for (int j = 0; j < 10; j++)
            foreach (var item in classes.SolicitadoList.Solicitados)
            {
                if (item.Usercpf == Session.Cpf)
                {
                    User_control.ControlSolicitados a = new User_control.ControlSolicitados(item.Id, ant);
                    a.Location = new Point(5, y);
                    y = y + a.Height + 5;
                    painel.Controls.Add(a);
                    i++;
                }

            }


        }

        private void Painel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_back_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void Btn_back_MouseEnter(object sender, EventArgs e)
        {
            btn_back.Image = Model.Img_Voltar_Click;
        }

        private void Btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Model.Img_Voltar;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }
    }
}
