using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos.User_Card
{
    public partial class Card_list_Emp : UserControl
    {
        Classes.CoEvento evento;

        public Card_list_Emp(int id)
        {
            evento = Classes.Eventos_List.thisPostId(id);
            InitializeComponent();
        }

        private void bt_visualizar_Click(object sender, EventArgs e)
        {

        }

        private void Card_list_Emp_Load(object sender, EventArgs e)
        {
            lb_nome.Text = evento.nome;
            lb_categoria.Text = evento.Categoria;
            lb_data.Text = evento.Data;
            lb_ingressos.Text = "" + evento.IngressosTotal;
            lb_valor.Text = "" + evento.Valor;
            pb_imagem.ImageLocation = evento.Imagem1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            eventos.Tela_Editar editar = new eventos.Tela_Editar(evento.id);
            FormPrincipal.MudarForm("Eventos", editar);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente remover o evento?", "Remover Evento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                evento.Ativo = false;

                MessageBox.Show("Evento removido!");
                FormPrincipal.MudarForm("eventos", new ListEvent());
            }
            else
            {

            }
        }
    }
}
