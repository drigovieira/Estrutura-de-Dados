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
    public partial class Editar_Quarto : Form
    {
        private int id, qtd_pessoas, qtd_disponivel, qtd_casal, qtd_solteiro;
        private string nome, empresa, servicos, foto, status, tipo;

        private double valor;
        private bool ativo;
        private bool img = false;
        Quarto quarto = new Quarto();

        private void Button1_Click(object sender, EventArgs e)
        {
            openimg.Filter = "Image Files(*.jpeg;*.bmp;*.jpg)|*.jpeg;*.bmp;*.jpg";

            if (openimg.ShowDialog() == DialogResult.OK)
            {
                pb_img_1.ImageLocation = openimg.FileName;
                pb_img_1.Load();
                img = true;                
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("hospedagem", anterior);
        }

        UserControl user = new UserControl();

        private void Btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_1;
        }

        private void Btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.Image = Properties.Resources.back_2;
        }

        private void Tb_nome_TextChanged(object sender, EventArgs e)
        {
            tb_nome.MaxLength = 50;
        }

        private void Tb_qtdquarto_TextChanged(object sender, EventArgs e)
        {
            tb_qtdquarto.MaxLength = 10;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Editar_Quarto_Load(object sender, EventArgs e)
        {

        }

        private void Input_valor_TextChanged(object sender, EventArgs e)
        {
            input_valor.MaxLength = 10;
        }

        OpenFileDialog openimg = new OpenFileDialog();

        Form anterior;

        public Editar_Quarto(int id, Form anterior)
        {
            quarto = roomList.SelectId(id);

            Empresa emp = hostList.selectCnpj(quarto.Cnpj_Empresa);

            this.nome = quarto.NomeQuarto;
            this.qtd_pessoas = quarto.Qtd_Pessoas;
            this.qtd_disponivel = quarto.Qtd_Disponivel;
            this.empresa = emp.Nomefantasia;
            this.servicos = quarto.Servicos;
            this.foto = quarto.Foto;
            this.valor = quarto.Valor_Diario;
            this.status = quarto.Status;
            this.ativo = quarto.Ativo;
            this.tipo = quarto.Tipo;
            this.qtd_solteiro = quarto.Qtd_Solteiro;
            this.qtd_casal = quarto.Qtd_Casal;

            this.anterior = anterior;
            InitializeComponent();

            if (quarto.Foto != null)
            {
                pb_img_1.ImageLocation = quarto.Foto;
            }
            else
            {
                pb_img_1.ImageLocation = "..//..//hospedagem//data//images//empresas//offImage.png";
            }
                
            tb_nome.Text = this.nome;

            if (tipo == "Solteiro")
            {
                radioButton1.Checked = true;
            }

            if (tipo == "Casal")
            {
                radioButton3.Checked = true;
            }

            if (tipo=="Outro")
            {
                radioButton2.Checked = true;
            }





            tb_casal.Text ="" + qtd_casal;

            tb_solteiro.Text = "" + qtd_solteiro;

            //tb_value_pessoas.Text = "" + this.qtd_pessoas;
            tb_qtdquarto.Text = "" + this.qtd_disponivel;
            input_valor.Text = "" + this.valor;



                if (servicos.Contains("Almoço"))
                {
                    checkBox3.Checked = true;
                }
                if (servicos.Contains("Café da manha"))
                {
                    checkBox1.Checked = true;
                }
                if (servicos.Contains("Ar condicionado"))
                {
                    checkBox2.Checked = true;
                }
                if (servicos.Contains("Tv a cabo"))
                {
                    checkBox5.Checked = true;
                }
                if (servicos.Contains("Espaço PET"))
                {
                    checkBox7.Checked = true;
                }

                if (servicos.Contains("Wi-fi"))
                {
                    checkBox4.Checked = true;
                }
                if (servicos.Contains("Café da tarde"))
                {
                    checkBox6.Checked = true;
                }



        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Bt_cadastrar_Click(object sender, EventArgs e)
        {
            if (pb_img_1.Image == null || tb_nome.Text == "" || tb_qtdquarto.Text == "" ||
                input_valor.Text == "" || (checkBox1.Checked == false && checkBox2.Checked == false
                && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false
                && checkBox6.Checked == false && checkBox7.Checked == false))
            {
                MessageBox.Show("Algum campo obrigatório está vazio ");
            }
            else
            {

                DialogResult confirm = MessageBox.Show("Deseja realmente alterar o quarto?", "Alterar Quarto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    List<string> servicos = new List<string>();

                   //int id = roomList.Tam;

                    string nome = tb_nome.Text;
                    string status = "Disponivel";
                    string lista_servicos = "";
                    string tipo_quarto = "";
                    int qtd_pessoas = int.Parse(tb_solteiro.Text) + int.Parse(tb_casal.Text);
                    int qtdcasa = int.Parse(tb_casal.Text);
                    int qtdsolt = int.Parse(tb_solteiro.Text);
                    int qtd_disponivel = int.Parse(tb_qtdquarto.Text);
                    double valor = double.Parse(input_valor.Text);
                    bool ativo = true;
                    long empresa = 0;


                    if (tipo == "Solteiro")
                    {
                        tipo_quarto = "Solteiro";
                    }

                    if (tipo == "Casal")
                    {
                        tipo_quarto = "Casal";
                    }

                    if (tipo == "Outro")
                    {
                        tipo_quarto = "Outro";
                    }

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


                     //PEGA OS VALORES DOS SERVIÇOS
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
                    if (checkBox4.Checked)
                    {
                        string a = "Café da tarde";
                        servicos.Add(a);
                    }
                    if (checkBox5.Checked)
                    {
                        string a = "TV a cabo";
                        servicos.Add(a);
                    }
                    if (checkBox6.Checked)
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
                    else
                    {
                        diretorio = foto;
                    }

                    //quarto.ID = id;
                    quarto.Cnpj_Empresa = empresa;
                    quarto.NomeQuarto = nome;
                    quarto.Tipo = tipo_quarto;
                    quarto.Qtd_Solteiro = qtdsolt;
                    quarto.Qtd_Casal = qtdcasa;
                    quarto.Qtd_Pessoas = qtd_pessoas;
                    quarto.Qtd_Disponivel = qtd_disponivel;
                    quarto.Servicos = lista_servicos;
                    quarto.Valor_Diario = valor;
                    quarto.Foto = diretorio;
                    quarto.Status = status;
                    quarto.Ativo = ativo;

                    //roomList.addQuarto(quarto);

                    MessageBox.Show("O quarto: " + nome + " foi alterado com Sucesso!");

                    this.Close();

                    hospedagem.Hosp_Home hp = new Hosp_Home();
                    FormPrincipal.MudarForm("hospedagem", hp);

                    //MessageBox.Show("Quarto editado!");
                    FormPrincipal.MudarForm("hospedagem", new Listas_quartos(new Cadastro_Empresa(new Hosp_Home())));
                }
                else
                {


                }

            }
        }

        
    }
    }
