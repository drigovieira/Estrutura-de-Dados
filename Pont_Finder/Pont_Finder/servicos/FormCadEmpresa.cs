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

namespace Pont_Finder.servicos
{
    public partial class FormCadEmpresa : Form
    {
        private bool img = false;

        string[] tiposServicos = {
            "Eletricista",
            "Informática",
            "Limpeza",
            "Montador de Móveis",
            "Hidráulico",
            "Pintor",
            "Outro"
        };

        public FormCadEmpresa()
        {
            InitializeComponent();
            pb_icone.SizeMode = PictureBoxSizeMode.StretchImage;

           
            foreach (var item in tiposServicos)
            {
                cb_servico.Items.Add(item);
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            if (tb_nome.Text.Trim().Length < 6)
                MessageBox.Show("Verifique o Nome da Empresa");
            else if (tb_fantasia.Text.Trim().Length < 2)
                MessageBox.Show("Verifique o Nome Fantasia da Empresa");
            else if ((cb_servico.SelectedItem + "").Equals(""))
                MessageBox.Show("Selecione um Tipo de Serviço");
            else if (!Validation.Cnpj(mb_cnpj.Text))
                MessageBox.Show("Cnpj Inválido");
            else if (!Validation.Email(tb_email.Text))
                MessageBox.Show("Email Inválido");
            else if (tb_telefone.Text.Length < 10)
                MessageBox.Show("Verifique o Telefone");
            else if (tb_cep.Text.Length < 8)
                MessageBox.Show("Verifique o Cep");
            else if (tb_endereco.Text.Length < 6)
                MessageBox.Show("Verifique o Endereço");
            else
            {
                new FormTermosDeUso().ShowDialog();
                if (Session.Termos)
                {
                    string nome = tb_nome.Text;
                    string fatasia = tb_fantasia.Text;
                    long cnpj = long.Parse(mb_cnpj.Text);
                    string endereco = tb_endereco.Text + ", " + tb_cep.Text;
                    string telefone = tb_telefone.Text;
                    string email = tb_email.Text;
                    string servico = cb_servico.SelectedItem + "";

                    string link = "..//..//servicos//data//images//empresas//offImage.jpg";
                    if (img)
                    {
                        if (!Directory.Exists("..//..//servicos//data//images//empresas"))
                            Directory.CreateDirectory("..//..//servicos//data//images//empresas");

                        pb_icone.Load();
                        pb_icone.Image = Image.FromFile(openIcone.FileName);

                        Image bmp = new Bitmap(pb_icone.Image);

                        Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                        pb_icone.Image = bmp2;

                        link = "..//..//servicos//data//images//empresas//" + cnpj + ".jpg";
                        pb_icone.Image.Save(link, ImageFormat.Jpeg);
                    }

                    classes.Empresa tmp = new classes.Empresa();
                    tmp.Nome = nome.Trim();
                    tmp.NomeFantasia = fatasia.Trim();
                    tmp.Email = email.Trim().ToLower();
                    tmp.Cnpj = cnpj;
                    tmp.Endereco = endereco.Trim();
                    tmp.Telefone = telefone;
                    tmp.Cpf = Session.Cpf;
                    tmp.Image = link;
                    tmp.Status = true;
                    tmp.Categoria = servico;

                    tmp.Slogan = "";
                    tmp.Sobre = "";
                    tmp.Descricao = "";
                    tmp.PoliticaPrivacidade = "";
                    tmp.Site = "";
                    classes.ListaEmpresa.Add(tmp);
      
                    FormPrincipal.MudarForm("servicos", new FormServicos());
                }

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }

        private void AddFotoEmpresa_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                pb_icone.Load();
                img = true;
            }
        }

        private void Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCadEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Tb_nome_TextChanged(object sender, EventArgs e)
        {
            tb_nome.MaxLength = 50;
        }

        private void Tb_fantasia_TextChanged(object sender, EventArgs e)
        {
            tb_fantasia.MaxLength = 50;
        }

        private void Tb_endereco_TextChanged(object sender, EventArgs e)
        {
            tb_endereco.MaxLength = 100;
        }

        private void Tb_email_TextChanged(object sender, EventArgs e)
        {
            tb_email.MaxLength = 50;
        }

        private void Bt_icone_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                pb_icone.Load();
                img = true;
            }
        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }
    }
}
