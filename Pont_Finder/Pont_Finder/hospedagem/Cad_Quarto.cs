using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem
{
    public partial class Cad_Quarto : Form
    {
        Form anterior;
        OpenFileDialog openimg = new OpenFileDialog();
        Quarto quarto = new Quarto();

        private bool img = false;
        public Cad_Quarto(Form anterior)
        {
            this.anterior = anterior;
            InitializeComponent();
            tb_solteiro.Enabled = false;
            tb_casal.Enabled = false;

            
        }

        private void Cad_Quarto_Load(object sender, EventArgs e)
        {

        }

        //BOTAO ADICIONAR IMAGEM
        private void button1_Click(object sender, EventArgs e)
        {
            openimg.Filter = "Image Files(*.jpeg;*.bmp;*.jpg)|*.jpeg;*.bmp;*.jpg";

            if (openimg.ShowDialog() == DialogResult.OK)
            {
                pb_img_1.ImageLocation = openimg.FileName;
                pb_img_1.Load();
                img = true;
            }

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            int cont = 0;//contador para salvar se não existir o nome na lista
            if (pb_img_1.Image == null || tb_nome.Text == "" || tb_qtdquarto.Text == "" ||
                input_valor.Text == "" || (checkBox1.Checked == false && checkBox2.Checked == false
                && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false
                && checkBox6.Checked == false && checkBox7.Checked == false)||(radioButton1.Checked==false&&
                radioButton2.Checked==false && radioButton3.Checked==false))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else

            {

                List<string> servicos = new List<string>();

                int id = roomList.Tam;

                string nome = tb_nome.Text;
                string status = "Disponivel";
                string lista_servicos = "";
                string tipo ="";
                int qtd_pessoas = 0;
                int qtd_solteiro = 0;
                int qtd_casal = 0;
                int qtd_disponivel = int.Parse(tb_qtdquarto.Text);
                double valor = double.Parse(input_valor.Text);
                bool ativo = true;
                long empresa = 0;

                Empresa emp = hostList.selectCpf(Session.Cpf);

                if (Session.Online)
                {
                    if (emp == null)
                    {
                    }
                    else
                    {
                        empresa = emp.CNPJ;
                    }
                }

                //PEGA QTD DE PESSOAS
                if(radioButton1.Checked)
                {                    
                    qtd_pessoas = 1;
                    tipo = "Solteiro";
                    qtd_solteiro = 1;
                    }
                if (radioButton3.Checked)
                {
                    qtd_pessoas = 2;
                    tipo = "Casal";
                    qtd_casal = 1;
                }
                if (radioButton2.Checked)
                {
                    tipo = "Outro";
                    if (tb_casal.Text == "")
                    {
                        qtd_solteiro = Convert.ToInt32(tb_solteiro.Text);
                        qtd_pessoas = qtd_solteiro;
                    }
                    if (tb_solteiro.Text == "")
                    {
                        qtd_casal = Convert.ToInt32(tb_casal.Text);
                        qtd_pessoas = qtd_casal * 2;
                    }
                    if (tb_casal.Text != "" && tb_solteiro.Text != "")
                    {
                        qtd_solteiro = Convert.ToInt32(tb_solteiro.Text);
                        qtd_casal = Convert.ToInt32(tb_casal.Text);
                        qtd_pessoas = qtd_solteiro + (qtd_casal * 2);
                    }

                    
                }


                // PEGA OS VALORES DOS SERVIÇOS
                if (checkBox1.Checked)
                {
                    string a = "Café da manhã";
                    servicos.Add(a);
                }
                if (checkBox2.Checked)
                {
                    string a = "Ar Condicionado";
                    servicos.Add(a);
                }
                if (checkBox3.Checked)
                {
                    string a = "Almoço";
                    servicos.Add(a);
                }
                if (checkBox6.Checked)
                {
                    string a = "Café da tarde";
                    servicos.Add(a);
                }
                if (checkBox5.Checked)
                {
                    string a = "TV a cabo";
                    servicos.Add(a);
                }
                if (checkBox4.Checked)
                {
                    string a = "Wi-fi";
                    servicos.Add(a);
                }
                if (checkBox7.Checked)
                {
                    string a = "Espaço PET";
                    servicos.Add(a);
                }
                

                foreach (var elemento in servicos)
                {
                    lista_servicos = lista_servicos + " * " + elemento;
                }


                //ADICIONA IMAGEM
                string diretorio = null;
                if (img)
                {
                    if (!Directory.Exists("..//..//hospedagem//data//images//empresas//" + empresa + "//quartos//" + id + "//"))
                        Directory.CreateDirectory("..//..//hospedagem//data//images//empresas//" + empresa + "//quartos//" + id + "//");

                    pb_img_1.Load();
                    pb_img_1.Image = Image.FromFile(openimg.FileName);

                    Image bmp = new Bitmap(pb_img_1.Image);

                    Image bmp2 = new Bitmap(bmp, pb_img_1.Size);

                    pb_img_1.Image = bmp2;

                    diretorio = "..//..//hospedagem//data//images//empresas//" + empresa + "//quartos//" + id + "//" + nome + ".jpg";
                    pb_img_1.Image.Save(diretorio, ImageFormat.Jpeg);
                }

                quarto.ID = id;
                quarto.Cnpj_Empresa = empresa;
                quarto.NomeQuarto = nome;
                quarto.Tipo = tipo;
                quarto.Qtd_Casal = qtd_casal;
                quarto.Qtd_Solteiro = qtd_solteiro;
                quarto.Qtd_Pessoas = qtd_pessoas;
                quarto.Qtd_Disponivel = qtd_disponivel;
                quarto.Servicos = lista_servicos;
                quarto.Valor_Diario = valor;
                quarto.Foto = diretorio;
                quarto.Status = status;
                quarto.Ativo = ativo;

                roomList.addQuarto(quarto);

                MessageBox.Show("O quarto: " + nome + " foi cadastrado com Sucesso!");

                this.Close();

                hospedagem.Hosp_Home hp = new Hosp_Home();
                FormPrincipal.MudarForm("hospedagem", hp);

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("hospedagem", anterior);
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_1;
        }

        private void btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.Image = Properties.Resources.back_2;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RadioButton3_Click(object sender, EventArgs e)
        {
            tb_solteiro.Text = "";
            tb_casal.Text = "";
            tb_solteiro.Enabled = false;
            tb_casal.Enabled = false;
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            tb_solteiro.Text = "";
            tb_casal.Text = "";
            tb_solteiro.Enabled = false;
            tb_casal.Enabled = false;
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            tb_solteiro.Enabled = true;
            tb_casal.Enabled = true;
        }

        private void Tb_nome_TextChanged(object sender, EventArgs e)
        {
            tb_nome.MaxLength = 50;
        }

        private void Tb_casal_TextChanged(object sender, EventArgs e)
        {
            tb_casal.MaxLength = 10;
        }

        private void Tb_solteiro_TextChanged(object sender, EventArgs e)
        {
            tb_solteiro.MaxLength = 10;
        }

        private void Tb_qtdquarto_TextChanged(object sender, EventArgs e)
        {
            tb_qtdquarto.MaxLength = 10;
        }

        private void Input_valor_TextChanged(object sender, EventArgs e)
        {
            input_valor.MaxLength = 10;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
