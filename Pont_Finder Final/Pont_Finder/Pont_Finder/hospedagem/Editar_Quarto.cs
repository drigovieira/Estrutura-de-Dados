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
        private int id, qtd_pessoas, qtd_disponivel, qtd_solteiro, qtd_casal;
        private string nome, empresa, servicos, foto, status,tipo;
       

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
            FormPrincipal.MudarForm("hospedagem", new Listas_quartos(new Hosp_Home()));
        }

        UserControl user = new UserControl();

        private void Btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_1;
        }

   
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tb_solteiro.Enabled = true;
            tb_casal.Enabled = true;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tb_solteiro.Text = "";
            tb_casal.Text = "";
            tb_solteiro.Enabled = false;
            tb_casal.Enabled = false;
        }

        private void RadioButton3_Click(object sender, EventArgs e)
        {
            tb_solteiro.Text = "";
            tb_casal.Text = "";
            tb_solteiro.Enabled = false;
            tb_casal.Enabled = false;
        }

        private void Btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.Image = Properties.Resources.back_2;
        }

        
        OpenFileDialog openimg = new OpenFileDialog();

        Form anterior;

        public Editar_Quarto(int id, Form anterior)
        {
            quarto = roomList.SelectId(id);

            Empresa emp = hostList.selectCnpj(quarto.Cnpj_Empresa);
            this.id = quarto.ID;
            this.nome = quarto.NomeQuarto;
            this.qtd_pessoas = quarto.Qtd_Pessoas;
            this.qtd_disponivel = quarto.Qtd_Disponivel;
            this.empresa = emp.Nomefantasia;
            this.servicos = quarto.Servicos;
            this.foto = quarto.Foto;
            this.valor = quarto.Valor_Diario;
            this.status = quarto.Status;
            this.ativo = quarto.Ativo;
            this.qtd_casal = quarto.Qtd_Casal;
            this.qtd_solteiro = quarto.Qtd_Solteiro;
            this.tipo = quarto.Tipo;

            
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
               input_valor.Text == "" || (checkBox1.Checked == false && checkBox2.Checked == false
               && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false
               && checkBox6.Checked == false && checkBox7.Checked == false) || (radioButton1.Checked == false &&
               radioButton2.Checked == false && radioButton3.Checked == false))
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
                    string tipo = "";
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
                    if (radioButton1.Checked)
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
                       
                        qtd_solteiro = 1;
                        qtd_casal = 1;

                        tipo = "Outro";
                        if (tb_casal.Text == "" && tb_solteiro.Text!="")
                        {
                            qtd_solteiro = Convert.ToInt32(tb_solteiro.Text);
                            qtd_pessoas = qtd_solteiro;
                        }
                        if (tb_solteiro.Text == "" && tb_casal.Text !="")
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
                        if(tb_casal.Text=="" && tb_casal.Text=="")
                        {
                            qtd_casal = 1;
                            qtd_solteiro = 1;
                            qtd_pessoas = 3;

                        }
                    }
                    //pega os servicos
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
                    else
                    {
                        diretorio = foto;
                    }

                   
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
                    //roomList.addQuarto(quarto);

                    MessageBox.Show("O quarto: " + nome + " foi alterado com Sucesso!");

                    this.Close();

                    //hospedagem.Hosp_Home hp = new Hosp_Home();
                    //FormPrincipal.MudarForm("hospedagem", hp);

                    //quarto.Ativo = false;

                    //MessageBox.Show("Quarto editado!");
                    FormPrincipal.MudarForm("hospedagem", new Listas_quartos(new Hosp_Home()));

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

            if(tipo=="Outro")
            {
                radioButton2.Checked = true;
                tb_casal.Text =""+qtd_casal;
                tb_solteiro.Text = "" + qtd_solteiro;
            }
            if (tipo == "Casal")
            {
                radioButton3.Checked = true;
                tb_casal.Enabled = false;
                tb_solteiro.Enabled = false;
            }
            if (tipo == "Solteiro")
            {
                radioButton1.Checked = true;
                tb_casal.Enabled = false;
                tb_solteiro.Enabled = false;
            }
            //marca checkbox da lista
            if (servicos.Contains(" Café da manhã "))
            {
                checkBox1.Checked = true;
            }
            if (servicos.Contains(" Ar Condicionado "))
            {
                checkBox2.Checked = true;
            }
            if (servicos.Contains(" Almoço "))
            {
                checkBox3.Checked = true;
            }
            if (servicos.Contains(" Café da tarde "))
            {
                checkBox6.Checked = true;
            }
            if (servicos.Contains(" TV a cabo "))
            {
                checkBox5.Checked = true;
            }
            if (servicos.Contains(" Wi-fi "))
            {
                checkBox4.Checked = true;
            }
            if (servicos.Contains(" Espaço PET"))
            {
                checkBox7.Checked = true;
            }
            /*foreach (var item in roomList.Quartos)
            {
                if (item.Servicos.Contains(" Café da manhã "))
                {
                    checkBox1.Checked = true;
                }
                if (item.Servicos.Contains(" Ar Condicionado "))
                {
                    checkBox2.Checked = true;
                }
                if (item.Servicos.Contains(" Almoço "))
                {
                    checkBox3.Checked = true;
                }
                if (item.Servicos.Contains(" Café da tarde "))
                {
                    checkBox6.Checked = true;
                }
                if (item.Servicos.Contains(" TV a cabo "))
                {
                    checkBox5.Checked = true;
                }
                if (item.Servicos.Contains(" Wi-fi "))
                {
                    checkBox4.Checked = true;
                }
                if (item.Servicos.Contains(" Espaço PET"))
                {
                    checkBox7.Checked = true;
                }

            }*/





        }
    }
}