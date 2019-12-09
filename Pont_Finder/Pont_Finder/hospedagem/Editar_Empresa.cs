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
    public partial class Editar_Empresa : Form
    {
        private string nomeempresa, nomefantasia, endereco, email, descricao, ambiente, foto, tipo, logo;
        private int cep, id;
        private bool ativo;
        private long cnpj, cpfadmin, telefone;

        public static string fotin = null;

        bool loguinho = false;

        OpenFileDialog openimg = new OpenFileDialog();
        OpenFileDialog openlogo = new OpenFileDialog();

        Empresa emp = hostList.selectCpf(Session.Cpf);

        public Editar_Empresa(Form anterior, long cpf_empresa)
        {

            InitializeComponent();


            this.nomeempresa = emp.Nomeempresa;
            this.nomefantasia = emp.Nomefantasia;
            this.endereco = emp.Endereco;
            this.email = emp.Email;
            this.descricao = emp.Descricao;
            this.ambiente = emp.Ambiente;
            this.foto = emp.Foto;
            this.tipo = emp.Tipo;
            this.logo = emp.Logo;
            this.cep = emp.Cep;
            this.ativo = emp.Ativo;
            this.cnpj = emp.CNPJ;
            this.telefone = emp.Telefone;


        }

        private void ckb_wifi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_alterar_Click(object sender, EventArgs e)//DENIS BOTAO ALTERAR
        {
            emp.Endereco = tb_endereco.Text;
            emp.Cep = Convert.ToInt32(mkb_cep.Text);
            emp.Telefone = long.Parse(mkb_phone.Text);
            emp.Descricao = tb_descricaoHotel.Text;

            MessageBox.Show("Empresa atualizada!");

            //Achei necessario colocar
            FormPrincipal.MudarForm("hospedagem", new Hosp_Home());
        }

        private void bt_add_img_Click(object sender, EventArgs e)
        {
            openimg.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.jpg";

            openimg.Multiselect = true;

            if (openimg.ShowDialog() == DialogResult.OK)
            {
                int x = 5;
                int abcd = 0;

                pn_galery.Controls.Clear();


                foreach (var img in openimg.FileNames)
                {
                    data.inc.Img_list gallery = new data.inc.Img_list(img);

                    gallery.Location = new Point((x), 12);
                    x = x + gallery.Width + 5;
                    pn_galery.Controls.Add(gallery);

                    if (abcd == 0)
                    {
                        fotin = img;
                        pb_img1.ImageLocation = img;
                        pb_img1.Load();
                        abcd++;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ckb_lugarPet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_academia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_salaJogos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_piscina_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_estacionamento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pnl_ambDisp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tb_nameEmp_TextChanged(object sender, EventArgs e)
        {
            tb_nameEmp.MaxLength = 50;
        }

        private void Tb_nameFantasy_TextChanged(object sender, EventArgs e)
        {
            tb_nameFantasy.MaxLength = 75;
        }

        private void Tb_endereco_TextChanged(object sender, EventArgs e)
        {
            tb_endereco.MaxLength = 50;
        }

        private void Tb_email_TextChanged(object sender, EventArgs e)
        {
            tb_email.MaxLength = 50;
        }

        private void Editar_Empresa_Load(object sender, EventArgs e) 
        {
            tb_nameEmp.Enabled = false;
            tb_nameFantasy.Enabled = false;
            mkb_cnpj.Enabled = false;

            tb_nameEmp.Text = nomeempresa;
            tb_nameFantasy.Text = nomefantasia;
            mkb_cnpj.Text = ""+cnpj;
            mkb_cep.Text = "" + cep;
            mkb_phone.Text = "" + telefone;
            tb_endereco.Text = endereco;
            tb_email.Text = email;
            tb_descricaoHotel.Text = descricao;

            if(tipo =="Hotel")
            {
                radio_hotel.Checked = true;
            }
            else
            {
                radio_pousada.Checked = true;
            }

            pictureBox1.ImageLocation = logo;
            pictureBox1.Load();

            //PREENCHido CheckBOXS COM DADOS DA LISTA      DENIS
            if (ambiente.Contains("Estacionamento"))
            {
                ckb_estacionamento.Checked = true;
            }
      
            if (ambiente.Contains("Piscina"))
            {
                ckb_piscina.Checked = true;
            }

            if (ambiente.Contains("Sala de jogos"))
            {
                ckb_salaJogos.Checked = true;
            }

            if (ambiente.Contains("Academia"))
            {
                ckb_academia.Checked = true;
            }

        }
    }
}
