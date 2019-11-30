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
            "Eletrecista",
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


            bool validation = false;


            if ((cb_servico.SelectedItem + "").Equals(""))
            {
                MessageBox.Show("Selecione o tipo de serviço");

            }
            else if (Validation.Cnpj(mb_cnpj.Text))
            {
                validation = true;
            }
            else
            {
                MessageBox.Show("Cnpj Invalido");
            }



            if (validation)
            {
                string nome = tb_nome.Text;
                string fatasia = tb_fantasia.Text;
                long cnpj = long.Parse(mb_cnpj.Text);
                string endereco = tb_endereco.Text + ", " + mb_cep.Text;
                string telefone = mb_phone.Text;
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
                tmp.Nome = nome;
                tmp.NomeFantasia = fatasia;
                tmp.Email = email;
                tmp.Cnpj = cnpj;
                tmp.Endereco = endereco;
                tmp.Telefone = telefone;
                tmp.Cpf = Session.Cpf;
                tmp.Image = link;
                tmp.Status = true;
                tmp.Categoria = servico;
                classes.ListaEmpresa.Add(tmp);
                FormPrincipal.MudarForm("servicos", new FormServicos());
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
    }
}
