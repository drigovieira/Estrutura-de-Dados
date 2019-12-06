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
            try
            {
                Cardapio menu = new Cardapio();
                menu.Nome = tb_nome.Text;
                menu.Categoria = categorias;
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
                    link = "..//..//alimentos//data//image//cardapio//" + name+".jpg";
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
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show("" + exp);
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                categorias.Add("Churrascaria");
            }
            else
            {
                if (categorias.Contains("Churrascaria"))
                {
                    categorias.Remove("Churrascaria");
                }
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                categorias.Add("Comida Japonesa");
            }
            else
            {
                if (categorias.Contains("Comida Japonesa"))
                {
                    categorias.Remove("Comida Japonesa");
                }
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                categorias.Add("Pizzaria");
            }
            else
            {
                if (categorias.Contains("Pizzaria"))
                {
                    categorias.Remove("Pizzaria");
                }
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                categorias.Add("Sorveteria");
            }
            else
            {
                if (categorias.Contains("Sorveteria"))
                {
                    categorias.Remove("Sorveteria");
                }
            }
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                categorias.Add("Petiscaria");
            }
            else
            {
                if (categorias.Contains("Petiscaria"))
                {
                    categorias.Remove("Petiscaria");
                }
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                categorias.Add("Hambúrgueria");
            }
            else
            {
                if (categorias.Contains("Hambúrgueria"))
                {
                    categorias.Remove("Hambúrgueria");
                }
            }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                categorias.Add("Comida Italiana");
            }
            else
            {
                if (categorias.Contains("Comida Italiana"))
                {
                    categorias.Remove("Comida Italiana");
                }
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                categorias.Add("Frutos do Mar");
            }
            else
            {
                if (categorias.Contains("Frutos do Mar"))
                {
                    categorias.Remove("Frutos do Mar");
                }
            }
        }

        private void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                categorias.Add("Outros");
            }
            else
            {
                if (categorias.Contains("Outros"))
                {
                    categorias.Remove("Outros");
                }
            }
        }

        private void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                categorias.Add("Convencional");
            }
            else
            {
                if (categorias.Contains("Convencional"))
                {
                    categorias.Remove("Convencional");
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
    }
}
