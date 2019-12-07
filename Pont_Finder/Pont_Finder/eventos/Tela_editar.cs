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
    public partial class Tela_editar : Form
    {
        Classes.CoEvento evento;
        bool img = false;
        public Tela_editar(int id)
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




        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("eventos", new eventos.ListEvent());
        }



        private void Bt_imagem_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_img_1.ImageLocation = openIcone.FileName;
                img = true;
            }
        }

        private void Bt_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Tela_editar_Load(object sender, EventArgs e)
        {

        }
    }
    
}
