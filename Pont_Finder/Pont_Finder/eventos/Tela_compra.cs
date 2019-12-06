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
    public partial class Tela_compra : Form
    {

        Classes.CoEvento edit;
        private int idremove;
        Form anterior;
        int idpost;



        public Tela_compra(int idpost, Form anterior)
        {
            this.idpost = idpost;
            this.anterior = anterior;

            InitializeComponent();
            edit = Classes.Eventos_List.thisPostId(idpost);
            this.idremove = idpost;

            edit = Classes.Eventos_List.PosterId(idpost);
            lb_tipo_evento.Text = edit.Categoria;
            lb_data.Text = edit.Data;
            lb_local.Text = edit.Local;
            pb_imagem.ImageLocation = edit.Imagem1;
            lb_valor.Text = edit.Valor;
            lb_nome_evento.Text = edit.Nome;

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cpfbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tela_compra_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void qntbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void senhabox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_limpar_Click(object sender, EventArgs e)
        {
           
        }

        private void Rb_boleto_CheckedChanged(object sender, EventArgs e)
        {
            {
                Classes.ComprEvento cm = new Classes.ComprEvento();
                if (rb_boleto.Checked)
                {
                    eventos.User_Card.Card_boleto boleto = new User_Card.Card_boleto();
                    boleto.Location = new Point(0, 0);
                    panel_center.Controls.Add(boleto);
                }
                else
                {
                    panel_center.Controls.Clear();
                }
            }
        }

        private void Rb_cartao_CheckedChanged(object sender, EventArgs e)
        {
            {
                Classes.ComprEvento cm = new Classes.ComprEvento();
                if (rb_cartao.Checked)
                {
                    eventos.User_Card.Card_cartao cartao = new User_Card.Card_cartao();
                    cartao.Location = new Point(0, 0);
                    panel_center.Controls.Add(cartao);

                    
                }
                else
                {
                    panel_center.Controls.Clear();
                }
            }
        }

        private void Bt_finalizar_Click(object sender, EventArgs e)
        {
            Classes.ComprEvento cm = new Classes.ComprEvento();
           
          


            //string qnt = qntbox.Text;
            //string senha = senhabox.Text;

            //edit.IngressoDispinivel = edit.IngressoDispinivel - int.Parse(qnt);

            //cm.Id = Classes.EventoCompra_List.thisPoster.Count();
            //cm.Cpf = Session.Cpf;
            //cm.Qnt = long.Parse(qnt);
            //cm.Metodopagamento = metodo;
            //cm.Data = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            //cm.Valortotal = double.Parse(edit.Valor) * cm.Qnt + double.Parse(",00") ;

            //if (senha == Session.Senha)
            //{
            //Classes.EventoCompra_List.PostAdd(cm);

            //Preservar:
            MessageBox.Show("Compra Realizada Com Sucesso");
            Boleto.GerarBoleto bol = new Boleto.GerarBoleto(Session.Cpf, cm.Valortotal);
            FormPrincipal.MudarForm("eventos", bol);

            //}
            //else
            //{
            //MessageBox.Show("Senha Incorreta");
            //}
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("eventos", new Visualizar_evento(idpost, anterior));
        }
    }
}
