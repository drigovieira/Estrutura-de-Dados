using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem
{
    public partial class Cadastro_Empresa : Form
    {

        OpenFileDialog openimg = new OpenFileDialog();

        public Cadastro_Empresa()
        {
            InitializeComponent();
            pb_img1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void Cadastro_Empresa_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (tb_nameEmp.Text == "" || tb_nameFantasy.Text == "" || tb_email.Text == "" || tb_endereco.Text == "" || Convert.ToString(mkb_cnpj.Text) == "" || Convert.ToString(mkb_cep.Text) == "" || Convert.ToString(mkb_phone.Text) == "" || tb_descricaoHotel.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }
            else 
            {
                if (radio_hotel.Checked || radio_pousada.Checked)
                {
                    if (radio_star2.Checked || radio_star3.Checked || radio_star4.Checked || radio_star5.Checked)
                    {
                        List<string> ambientes = new List<string>();

                        string NomeEmpresa = tb_nameEmp.Text;
                        string NomeFantasia = tb_nameFantasy.Text;
                        string Email = tb_email.Text;
                        string Endereco = tb_endereco.Text;
                        long CNPJ = long.Parse(mkb_cnpj.Text);
                        int Cep = Convert.ToInt32(mkb_cep.Text);
                        int Tel = Convert.ToInt32(mkb_phone.Text);
                        string descricao = tb_descricaoHotel.Text;
                        string Foto = "";

                        string diretorio = "..//..//hospedagem//data//images//empresas//offImage.jpg";

                        string Ambientes = "";
                        long cpfadmin = Session.Cpf;
                        
                        if (ckb_estacionamento.Checked)
                        {
                            string a = "Estacionamento";
                            ambientes.Add(a);
                        }

                        if (ckb_piscina.Checked)
                        {
                            string a = "Piscina";
                            ambientes.Add(a);
                        }

                        if (ckb_salaJogos.Checked)
                        {
                            string a = "Sala de Jogos";
                            ambientes.Add(a);
                        }

                        if (ckb_academia.Checked )
                        {
                            string a = "Academia";
                            ambientes.Add(a);
                        }

                        foreach (var elemento in ambientes)
                        {
                            Ambientes = Ambientes+"  "+elemento;
                        }

                        bool validaCNPJ = true;
                        bool validaEmail = true;

                        foreach (var item in hostList.selectAll())
                        {
                            if (item.CNPJ == CNPJ)
                            {
                                validaCNPJ = false;
                            }
                                

                            if (item.Email == Email)
                            {
                                validaEmail = false;
                            }
                                
                        }

                        

                        if (validaCNPJ)
                        {
                            if (validaEmail)
                            {
                                if (("" + CNPJ).Length != 14)
                                {
                                    MessageBox.Show("CNPJ deve conter 14 dígitos");
                                    mkb_cnpj.Text = "";
                                }
                                else
                                {
                                    if (Validation.Email(Email))
                                    {
                                        Empresa empresa = new Empresa();

                                        empresa.Nomeempresa = NomeEmpresa;
                                        empresa.Nomefantasia = NomeFantasia;
                                        empresa.Endereco = Endereco;
                                        empresa.CNPJ = CNPJ;
                                        empresa.Cep = Cep;
                                        empresa.Telefone = Tel;
                                        empresa.Email = Email;
                                        
                                        empresa.CPFADMIN = cpfadmin;

                                        //Verifica se e hotel ou pousada
                                        if (radio_hotel.Checked)
                                        {
                                            empresa.Tipo = "Hotel";
                                        }
                                        if (radio_pousada.Checked)
                                        {
                                            empresa.Tipo = "Pousada";
                                        }

                                        //Verifica qtd de estrelas
                                        if (radio_star2.Checked)
                                        {
                                            empresa.Estrelas = 2;
                                        }
                                        if (radio_star3.Checked)
                                        {
                                            empresa.Estrelas = 3;
                                        }
                                        if (radio_star4.Checked)
                                        {
                                            empresa.Estrelas = 4;
                                        }
                                        if (radio_star5.Checked)
                                        {
                                            empresa.Estrelas = 5;
                                        }

                                        empresa.Descricao = descricao;
                                        empresa.Ambiente = Ambientes;
                                        empresa.Ativo = true;

                                        //Salvando Foto
                                        if (!Directory.Exists("..//..//hospedagem//data//images//empresas//"+ CNPJ +"//empresa//"))
                                            Directory.CreateDirectory("..//..//hospedagem//data//images//empresas//"+ CNPJ +"//empresa//");

                                        pb_img1.Load();

                                        int total_img = 0;

                                        foreach (var imagem in openimg.FileNames)
                                        {

                                            Image bmp = new Bitmap(Image.FromFile(imagem));

                                            Image bmp2 = new Bitmap(bmp, pb_img1.Size);

                                            pb_img1.Image = bmp2;

                                            diretorio = "..//..//hospedagem//data//images//empresas//" + CNPJ +"//empresa//"+total_img+ ".jpg";
                                            pb_img1.Image.Save(diretorio, ImageFormat.Jpeg);

                                            Foto = Foto+" * "+diretorio;

                                            total_img++;
                                        }


                                        empresa.Foto = Foto;


                                        //Adiciona na lista
                                        hostList.addEmpresa(empresa);

                                        MessageBox.Show("Empresa Cadastrada com Sucesso!");

                                        hospedagem.Listas_quartos listQuartos = new Listas_quartos();
                                        FormPrincipal.MudarForm("hospedagem", listQuartos);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Favor revisar o Email digitado, pois o mesmo é inválido!");
                                        tb_email.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Favor revisar o Email digitado, pois o mesmo já existe em nosso sistema!");
                                tb_email.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Favor revisar o CNPJ digitado, pois o mesmo já existe em nosso sistema!");
                            mkb_cnpj.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Você deve selecionar uma classificação para sua empresa. (2 - 5 Estrelas)");
                    }
                }
                else
                {
                    MessageBox.Show("Você deve selecionar um tipo para sua empresa. (Hotel ou Pousada)");
                }
            }
            
        }

        private void bt_add_img_Click(object sender, EventArgs e)
        {
            

            openimg.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.jpg";

            openimg.Multiselect = true;

            if (openimg.ShowDialog() == DialogResult.OK)
            {
                foreach (var img in openimg.FileNames)
                {
                    pb_img1.ImageLocation = img;
                    pb_img1.Load();
                }
            }
        }

        private void Mkb_cnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
