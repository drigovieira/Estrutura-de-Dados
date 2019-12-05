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
        private int id, qtd_pessoas, qtd_disponivel;
        private string nome, empresa, servicos, foto, status;

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

            this.anterior = anterior;
            InitializeComponent();
            /*
            if (quarto.Foto != null)
            {
                pb_hotel.ImageLocation = quarto.Foto;
            }
            else
            {
                pb_hotel.ImageLocation = "..//..//hospedagem//data//images//empresas//offImage.png";
            }
                
            lb_nome.Text = this.nome;
            lb_value_pessoas.Text = "" + this.qtd_pessoas;
            lb_value_quartos.Text = "" + this.qtd_disponivel;
            lb_rs.Text = "R$" + this.valor;
            */
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Bt_cadastrar_Click(object sender, EventArgs e)
        {
            if (pb_img_1.Image == null || tb_nome.Text == "" || tb_qtdquarto.Text == "" ||
                input_valor.Text == "" || (rb_pessoas_1.Checked == false && rb_pessoas_2.Checked == false
                && rb_pessoas_3.Checked == false && rb_pessoas_4.Checked == false && rb_pessoas_5.Checked == false
                && rb_pessoas_6.Checked == false) || (checkBox1.Checked == false && checkBox2.Checked == false
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
                    int qtd_pessoas = 0;
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
                    if (rb_pessoas_1.Checked)
                    {
                        qtd_pessoas = 1;
                    }
                    if (rb_pessoas_2.Checked)
                    {
                        qtd_pessoas = 2;
                    }
                    if (rb_pessoas_3.Checked)
                    {
                        qtd_pessoas = 3;
                    }
                    if (rb_pessoas_4.Checked)
                    {
                        qtd_pessoas = 4;
                    }
                    if (rb_pessoas_5.Checked)
                    {
                        qtd_pessoas = 5;
                    }
                    if (rb_pessoas_6.Checked)
                    {
                        qtd_pessoas = 6;
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

                    //hospedagem.Hosp_Home hp = new Hosp_Home();
                    //FormPrincipal.MudarForm("hospedagem", hp);

                    //quarto.Ativo = false;

                    //MessageBox.Show("Quarto editado!");
                    FormPrincipal.MudarForm("hospedagem", new Listas_quartos(new Cadastro_Empresa(new Hosp_Home())));
                }
                else
                {


                }

            }
        }

        private void Editar_Quarto_Load(object sender, EventArgs e)
        {
            if (quarto.Foto != null)
            {
                pb_img_1.ImageLocation = quarto.Foto;
            }
            else
            {
                pb_img_1.ImageLocation = "..//..//hospedagem//data//images//empresas//offImage.png";
            }

            tb_nome.Text = nome;            
            //tb_qtdpessoas.Text = "" + this.qtd_pessoas;
            tb_qtdquarto.Text = "" + qtd_disponivel;
            input_valor.Text = "" + valor;
            if(qtd_pessoas == 1)
            {
                rb_pessoas_1.Checked = true;
            }
            if (qtd_pessoas == 2)
            {
                rb_pessoas_2.Checked = true;
            }
            if (qtd_pessoas == 3)
            {
                rb_pessoas_3.Checked = true;
            }
            if (qtd_pessoas == 4)
            {
                rb_pessoas_4.Checked = true;
            }
            if (qtd_pessoas == 5)
            {
                rb_pessoas_5.Checked = true;
            }
            if (qtd_pessoas == 6)
            {
                rb_pessoas_6.Checked = true;
            }

           
            foreach (var item in roomList.Quartos)
            {
                if (item.Servicos.Contains("Almoço"))
                {
                    checkBox3.Checked = true;
                }
                if (item.Servicos.Contains("Café da manha"))
                {
                    checkBox1.Checked = true;
                }
                if (item.Servicos.Contains("Ar condicionado"))
                {
                    checkBox2.Checked = true;
                }
                if (item.Servicos.Contains("Tv a cabo"))
                {
                    checkBox5.Checked = true;
                }
                if (item.Servicos.Contains("Espaço PET"))
                {
                    checkBox7.Checked = true;
                }
                
                if (item.Servicos.Contains("Wi-fi"))
                {
                    checkBox4.Checked = true;
                }
                if (item.Servicos.Contains("Café da tarde"))
                {
                    checkBox6.Checked = true;
                }

            }
            


        }
    }
}