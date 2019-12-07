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
    public partial class FormSolicitadosEmpresa : Form
    {
        public FormSolicitadosEmpresa()
        {
            InitializeComponent();
        }

        private void FormSolicitadosEmpresa_Load(object sender, EventArgs e)
        {
            Form ant = new FormSolicitadosEmpresa();
            int y = 5;
            int i = 0;
            foreach (var item in classes.SolicitadoList.Solicitados)
            {
                if (classes.PostList.thisForId(item.Postid).Cpf == Session.Cpf)
                {
                    User_control.ControlSolicitados a = new User_control.ControlSolicitados(item.Id, ant);
                    a.Location = new Point(5, y);
                    y = y + a.Height + 5;
                    painel.Controls.Add(a);
                    i++;
                }
            }
        }

        private void Btn_back_MouseClick(object sender, MouseEventArgs e)
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
            FormPrincipal.MudarForm("servicos", new PerfilEmpresa(Session.Cpf, new FormServicos()));
        }
    }
}
