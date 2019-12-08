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
        bool img = false;
        public Tela_Editar(int id)
        {
            evento = Classes.Eventos_List.thisPostId(id);
            InitializeComponent();

            tb_nome.Text = evento.Nome;
            pb_img_1.ImageLocation = evento.Imagem1;
            tb_descricao.Text = evento.descricao;
            tb_ingresso_total.Text = "" + evento.ingressosTotal;
            tb_ingresso_disponivel.Text = "" + evento.ingressosDisponivel;
            Bdata.Text = evento.data;
            mtb_hora.Text = evento.horario;
            Blocal.Text = evento.local;
            Bpatrocionadores.Text = evento.patrocinadores;
            CBfaixaetaria.Text = evento.idade;
            Bvalor.Text = evento.valor;

            string categoria = evento.categoria;

            if (categoria == "Música")
            {
                rb_musica.Checked = true;
            }
            else if (categoria == "Cultural")
            {
                rb_cultural.Checked = true;

            }
            else if (categoria == "Esporte")
            {
                rb_esporte.Checked = true;

            }
            else if (categoria == "Tecnologia")
            {
                rb_tecnologia.Checked = true;

            }
            else if (categoria == "Gastronomia")
            {
                rb_gastronomia.Checked = true;
            }
            else if (categoria == "Workshop")
            {
                rb_workshop.Checked = true;
            }

        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("eventos", new eventos.ListEvent());
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Bt_alterar_Click(object sender, EventArgs e)
        {
            evento.IngressosTotal = int.Parse(tb_ingresso_total.Text);
            evento.IngressoDispinivel = int.Parse(tb_ingresso_disponivel.Text);
            evento.Nome = tb_nome.Text;
            evento.Imagem1 = pb_img_1.ImageLocation;
            evento.Descricao = tb_descricao.Text;
            evento.Data = Bdata.Text;
            evento.Horario = mtb_hora.Text;
            evento.Local = Blocal.Text;
            evento.Patrocinadores = Bpatrocionadores.Text;
            evento.Idade = CBfaixaetaria.Text;
            evento.Valor = Bvalor.Text;
            evento.Ativo = true;

            string categoria = "";
            if (rb_musica.Checked)
            {
                categoria = "Música";
            }
            else if (rb_cultural.Checked)
            {
                categoria = "Cultural";
            }
            else if (rb_esporte.Checked)
            {
                categoria = "Esporte";
            }
            else if (rb_tecnologia.Checked)
            {
                categoria = "Tecnologia";
            }
            else if (rb_gastronomia.Checked)
            {
                categoria = "Gastronomia";
            }
            else if (rb_workshop.Checked)
            {
                categoria = "Workshop";
            }

            MessageBox.Show("Dados alterados com sucesso!");
        }
    }
}
