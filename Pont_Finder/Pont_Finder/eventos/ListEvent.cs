using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos
{
    public partial class ListEvent : Form
    {
        public ListEvent()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            eventos.Post_Eventos ptEvent = new eventos.Post_Eventos();
            FormPrincipal.MudarForm("eventos", ptEvent);
        }

        private void ListEvent_Load(object sender, EventArgs e)
        {
            int y = 5;
            int i = 0;

 
            foreach (var item in Classes.Eventos_List.Posts)
            {
              
                    User_Card.Card_list_Emp a = new User_Card.Card_list_Emp(item.Id);
                    a.Location = new Point(10, y);
                    y = y + a.Height + 5;
                    painel.Controls.Add(a);
                    i++;
                

            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("eventos", new eventos.FormEventos());
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
