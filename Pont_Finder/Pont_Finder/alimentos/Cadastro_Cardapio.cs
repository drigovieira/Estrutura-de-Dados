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

namespace Pont_Finder.alimentos
{
    public partial class Cadastro_Cardapio : Form
    {
        private List<string> categorias = new List<string>();
        private List<string> ingredientesList = new List<string>();
        private int ID;
        private bool img = false;
        public Cadastro_Cardapio(int idEmpresa)
        {
            ID = idEmpresa;
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_nome.Text) && string.IsNullOrWhiteSpace(input_valor.Text) && string.IsNullOrWhiteSpace(inputIngrediente.Text))
            {
                MessageBox.Show("Por favor, preencha os campos vazios.", "Aviso!");
            }
            else
            {
                try
                {
                    Cardapio menu = new Cardapio();
                    menu.Nome = tb_nome.Text;
                    menu.Qtd = float.Parse(tb_qtdprato.Text);
                    menu.Ingredientes = ingredientesList;
                    menu.Preco = float.Parse(input_valor.Text);
                    menu.IdEmpresa = ID;
                    string link = "..//..//alimentos//data//image//cardapio//offImage.jpg";
                    if (img)
                    {
                        if (!Directory.Exists("..//..//alimentos//data//image//cardapio"))
                            Directory.CreateDirectory("..//..//alimentos//data//image//cardapio");

                        pb_img_1.Load();
                        pb_img_1.Image = Image.FromFile(openIcone.FileName);

                        Image bmp = new Bitmap(pb_img_1.Image);

                        Image bmp2 = new Bitmap(bmp, pb_img_1.Size);

                        pb_img_1.Image = bmp2;
                        int name = ID + ListCardapio.selectAll().Count;
                        link = "..//..//alimentos//data//image//cardapio//" + name + ".jpg";
                        pb_img_1.Image.Save(link, ImageFormat.Jpeg);
                    }
                    menu.Image = link;
                    ListCardapio.CardapioAdd(menu);
                    MessageBox.Show("Item adicionado ao cardápio!", "Status Operation:");
                    alimentos.Cadastro_Produto cadProduto = new Cadastro_Produto(ID);
                    FormPrincipal.MudarForm("alimentos", cadProduto);
                    tb_nome.Clear();
                    tb_qtdprato.Clear();
                    Ingredientes.Items.Clear();
                    input_valor.Clear();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("" + exp);
                }
            }
           
        }        

        private void BtnAddIngrediente_Click(object sender, EventArgs e)
        {
            Ingredientes.Items.Add(inputIngrediente.Text);
            ingredientesList.Add(inputIngrediente.Text);
            inputIngrediente.Clear();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            formAlimentos homeAlimentos = new formAlimentos();
            FormPrincipal.MudarForm("alimentos", homeAlimentos);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_img_1.ImageLocation = openIcone.FileName;
                img = true;
            }
        }

        private void Tb_qtdprato_TextChanged(object sender, EventArgs e)
        {
            tb_qtdprato.MaxLength = 5;
        }

        private void Tb_nome_TextChanged(object sender, EventArgs e)
        {
            tb_nome.MaxLength = 75;
        }

        private void InputIngrediente_TextChanged(object sender, EventArgs e)
        {
            inputIngrediente.MaxLength = 75;
        }

        private void Pb_img_1_Click(object sender, EventArgs e)
        {

        }

        private void Input_valor_TextChanged(object sender, EventArgs e)
        {
            input_valor.MaxLength = 10;
        }

        private void input_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void tb_qtdprato_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
    }
}
