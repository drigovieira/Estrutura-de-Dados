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
        public Visualizar(int index, string fantasia, string Rua, string Bairro, List<string> Categorias, int Num, int Cep, long Contato, string link)
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
                    if (count == 4) lbCategorias.Text += "\n";
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
                alimentos.Reserva_Alimentos reserva = new alimentos.Reserva_Alimentos();
                FormPrincipal.MudarForm("alimentos", reserva);
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

        private void Visualizar_Paint(object sender, PaintEventArgs e)
        {
            lbRestaurante.Text = nomeFantasia;
            lbRua.Text = "Rua: " + Emprua;
            lbBairro.Text = "Bairro: " + Empbairro;
            lbNum.Text = "N°: " + numero.ToString();
            lbCep.Text = "CEP: " + Empcep.ToString(@"00000\-000");
            lbContato.Text = Empcontato.ToString(@"(00) 00000-0000");            
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

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
