using Pont_Finder.eventos.classes;
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
           
                }

            }
        }

    
        


    


      


        
    


 
