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

namespace Pont_Finder
{
    public partial class formCriarConta : Form
    {
        private bool img = false;
        public formCriarConta()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            string cad_Name = textB_nome.Text;
            long cad_CPF = long.Parse(textB_cpf.Text);
            string cad_email = textB_email.Text;
            string cad_senha = textB_senha.Text;
            bool vCpf = true;
            bool vEmail = true;



            foreach (var item in UserList.selectAll())
            {
                if (item.Cpf == cad_CPF)
                    vCpf = false;
                
                if (item.Email == cad_email)
                    vEmail = false;     
            }

            if (vCpf)
            {
                if (vEmail)
                {
                    if (Validation.Cpf(cad_CPF))
                    {
                        if (Validation.Email(cad_email))
                        {

                            string link = "..//..//data//images//users//offImage.jpg";
                            if (img)
                            {
                                if (!Directory.Exists("..//..//data//images//users//"))
                                    Directory.CreateDirectory("..//..//data//images//users//");

                                pb_icone.Load();
                                pb_icone.Image = Image.FromFile(openIcone.FileName);

                                Image bmp = new Bitmap(pb_icone.Image);

                                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                                pb_icone.Image = bmp2;

                                link = "..//..//data//images//users//" + cad_CPF + ".jpg";
                                pb_icone.Image.Save(link, ImageFormat.Jpeg);
                            }


                            User user = new User();
                            user.Nome = cad_Name;
                            user.Email = cad_email;
                            user.Senha = cad_senha;
                            user.Cpf = cad_CPF;
                            user.Ativo = true;
                            user.Image = link;
                            UserList.Add(user);
                            MessageBox.Show("Usuário Cadastrado com sucesso!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Email inválido");
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("Cpf inválido");
                    }

                  
                }
                else
                {
                    MessageBox.Show("Email já cadastrado no sistema!");
                }        
            }
            else
            {
                MessageBox.Show("Cpf já cadastrado no sistema!");
            }
            //this.Dispose();
                       
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                pb_icone.Load();
                img = true;
            }
        }
    }
}
