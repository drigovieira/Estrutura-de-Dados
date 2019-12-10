using Pont_Finder.alimentos.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class Visualizar : Form
    {
        private string nomeFantasia, Emprua, Empbairro, linkimage;
        private List<string> Empcategoria;
        private List<Funcionamento> funcionamentoEmp;
        private int numero, Empcep, Index;
        private long Empcontato;
        private bool sttsCardapio;

        Bitmap imgLike = new Bitmap("..\\..\\Resources\\servicos\\like\\Like_null.png");
        Bitmap imgDeslike = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_null.png");
        Bitmap imgLikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\like.png");
        Bitmap imgDeslikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_blue.png");

        public Visualizar(int index, string fantasia, string Rua, string Bairro, List<string> Categorias, int Num, int Cep, long Contato, string link, bool cardapio)
        {
            nomeFantasia = fantasia;
            Emprua = Rua;
            Empbairro = Bairro;
            Empcategoria = Categorias;
            numero = Num;
            Empcep = Cep;
            Empcontato = Contato;
            linkimage = link;
            Index = index;
            sttsCardapio = cardapio;
            InitializeComponent();
            CapturarFuncionamento();
            int count = 0;
            foreach (var item in Empcategoria)
            {
                if (Empcategoria.IndexOf(item) == 0)
                {
                    lbCategorias.Text = item;
                    count++;
                }
                else
                {
                    if (count == 3) { lbCategorias.Text += "\n"; count = 0; }
                    lbCategorias.Text += " / " + item;
                    count++;
                }
            }
            lbFuncionamento.Text = "";
            lbHoras.Text = "";
            foreach (var funcio in funcionamentoEmp)
            {
                lbFuncionamento.Text += funcio.Dia +"\n";
                lbHoras.Text += "Inicio: "+ funcio.HoraInicio.ToString("HH:mm") + "  Fim: "+ funcio.HoraFim.ToString("HH:mm")+"\n"; 
            }
            lb_like.Text = CompanyList.selectAll()[Index].Like.ToString();
            lb_deslike.Text = CompanyList.selectAll()[Index].Deslike.ToString();
            if (Session.Online)
            {
                foreach (var item in EvaluationList.selectAll())
                {
                    if (item.Cpf == Session.Cpf && item.IndexEmp == Index)
                    {
                        if (item.Tipo.Equals("like") && item.IndexEmp == Index)
                        {
                            pb_up.Image = imgLikeBlue;
                        }
                        else if (item.Tipo.Equals("deslike") && item.IndexEmp == Index)
                        {
                            pb_down.Image = imgDeslikeBlue;
                        }
                    }
                }
            }
        }
        public void CapturarFuncionamento()
        {
            foreach(var item in CompanyList.selectAll())
            {
                if(item.Id == Index)
                {
                    funcionamentoEmp = item.FuncionamentoEmp;
                    break;
                }
            }
        }
        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_visualizar_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {                
                if (sttsCardapio == true)
                {
                    alimentos.Reserva_Alimentos reserva = new alimentos.Reserva_Alimentos(Index,CompanyList.selectAll()[Index].SttsEntrega);
                    FormPrincipal.MudarForm("alimentos", reserva);
                }
                else
                {
                    MessageBox.Show("Essa empresa não resgistrou um cardápio. ", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("É necessário estar logado para visualizar essas informações. ", "Aviso");
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            formAlimentos homeAlimentos = new formAlimentos();
            FormPrincipal.MudarForm("alimentos", homeAlimentos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (lbRua.Text != "")
                {
                    Mapa.Mapa map = new Mapa.Mapa(lbRua.Text);
                    map.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Caixa localização não preenchida");
                }
            }
            else
            {
                MessageBox.Show("É necessário estar logado para utilizar este recurso ", "Aviso");
            }
        }

        private void Pb_up_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (pb_up.Image == imgLikeBlue)
                {
                    pb_up.Image = imgLike;
                    pb_down.Image = imgDeslike;
                    EvaluationList.DelAvaliacao(EvaluationList.select(Session.Cpf).Cpf, Index);
                    EvaluationList.ApuraAvaliacao(Index);
                }
                else
                {
                    pb_up.Image = imgLikeBlue;
                    pb_down.Image = imgDeslike;
                    EvaluationList.DelAvaliacao(EvaluationList.select(Session.Cpf).Cpf, Index);
                    EvaluationList.AddAvaliacao(1, Index, Session.Cpf, "like");
                    EvaluationList.ApuraAvaliacao(Index);
                }
                lb_like.Text = CompanyList.selectAll()[Index].Like.ToString();
                lb_deslike.Text = CompanyList.selectAll()[Index].Deslike.ToString();

            }
            else
            {
                MessageBox.Show("É necessário estar logado para avaliar");
            }
        }

        private void Pb_down_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (pb_down.Image == imgDeslikeBlue)
                {
                    pb_down.Image = imgDeslike;
                    pb_up.Image = imgLike;                    
                    EvaluationList.DelAvaliacao(EvaluationList.select(Session.Cpf).Cpf, Index);
                    EvaluationList.ApuraAvaliacao(Index);
                }
                else
                {
                    pb_down.Image = imgDeslikeBlue;
                    pb_up.Image = imgLike;
                    EvaluationList.DelAvaliacao(EvaluationList.select(Session.Cpf).Cpf, Index);
                    EvaluationList.AddAvaliacao(1, Index, Session.Cpf, "deslike");
                    EvaluationList.ApuraAvaliacao(Index);
                }
                lb_like.Text = CompanyList.selectAll()[Index].Like.ToString();
                lb_deslike.Text = CompanyList.selectAll()[Index].Deslike.ToString();
            }
            else
            {
                MessageBox.Show("É necessário estar logado para avaliar");
            }
        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            if (Session.Online)
            {
                foreach (var item in EvaluationList.selectAll())
                {
                    if (item.Cpf == Session.Cpf)
                    {
                        if (item.Tipo.Equals("like") && item.IndexEmp == Index)
                        {
                            pb_up.Image = imgLikeBlue;
                        }
                        else if (item.Tipo.Equals("deslike") && item.IndexEmp == Index)
                        {
                            pb_down.Image = imgDeslikeBlue;
                        }
                    }
                }
            }
        }

        private void Visualizar_Paint(object sender, PaintEventArgs e)
        {
            lbRestaurante.Text = nomeFantasia;
            lbRua.Text = "Rua: " + Emprua;
            lbBairro.Text = "Bairro: " + Empbairro;
            lbNum.Text = "N°: " + numero.ToString();
            lbCep.Text = "CEP: " + Empcep.ToString(@"00000\-000");
            lbContato.Text = Empcontato.ToString();
            if (lbContato.Text.Length.Equals(10))
            {
                lbContato.Text = Empcontato.ToString(@"(00)0000-0000");
            }
            else
            {
                lbContato.Text = Empcontato.ToString(@"(00)00000-0000");
            }
            ImagemPerfil.ImageLocation = linkimage;
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Visualizar_Load(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                foreach (var item in EvaluationList.selectAll())
                {
                    if (item.Cpf == Session.Cpf && item.IndexEmp ==Index)
                    {
                        if (item.Tipo.Equals("like") && item.IndexEmp == Index)
                        {
                            pb_up.Image = imgLikeBlue;
                        }
                        else if (item.Tipo.Equals("deslike") && item.IndexEmp == Index)
                        {
                            pb_down.Image = imgDeslikeBlue;
                        }
                    }
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
