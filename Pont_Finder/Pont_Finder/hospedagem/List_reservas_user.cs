using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem
{
    public partial class List_reservas_user : Form
    {
        Form anterior;

        private long cpf, cnpj_empresa;
        public List_reservas_user(Form anterior)
        {
            this.anterior = anterior;
            InitializeComponent();
        }

        private void List_reservas_user_Load(object sender, EventArgs e)
        {
            int y = 5;
            int i = 0;

            List<Quarto> lista = roomList.quartosAtivos();
            lista.Reverse();

            List<classes.Reserva> lista_reservas = classes.reserveList.selectAll();

            Empresa emp = hostList.selectCpf(Session.Cpf);

            if (Session.Online)
            {
                

                if (emp == null)//VERSAO USUARIO
                {
                    cpf = Session.Cpf;

                    foreach (var item in lista)//PERCORRE TODOS QUARTOS
                    {

                        foreach (var res in lista_reservas)//PERCORRE TODAS RESERVAS
                        {

                            if (cpf == res.Usuario)
                            {
                                data.inc.user_list_reserva a = new data.inc.user_list_reserva(item.ID, res.Id);
                                a.Location = new Point(25, y);
                                y = y + a.Height + 5;
                                panel1.Controls.Add(a);
                                i++;
                            }
                        }

                    }

                }
                else //VERSAO ADMIN
                {
                    cnpj_empresa = emp.CNPJ;

                    foreach (var item in lista)//PERCORRE TODOS QUARTOS
                    {
                        
                        foreach(var res in lista_reservas)//PERCORRE TODAS RESERVAS
                        {

                            if (item.ID == res.IdQuarto)
                            {
                                if (item.Cnpj_Empresa == cnpj_empresa)
                                {
                                    data.inc.user_list_reserva a = new data.inc.user_list_reserva(item.ID, res.Id);
                                    a.Location = new Point(25, y);
                                    y = y + a.Height + 5;
                                    panel1.Controls.Add(a);
                                    i++;
                                }
                            }
                        }

                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("hospedagem", anterior);
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_1;
        }

        private void btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.Image = Properties.Resources.back_2;
        }
    }
}
