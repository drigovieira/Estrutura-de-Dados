using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem.data.inc
{
    public partial class icon : UserControl
    {
        private string servico_tooltip;

        ToolTip tt = new ToolTip();
        public icon(string icone)
        {

            InitializeComponent();


            pb_icon.ImageLocation = icone;
            pb_icon.Load();

            if (pb_icon.ImageLocation == "..\\..\\hospedagem\\data\\icones\\cafe.png")
            {
                servico_tooltip = "Café da tarde";
            }

            if (pb_icon.ImageLocation == "..\\..\\hospedagem\\data\\icones\\Ar_condicionado(1).png")
            {
                servico_tooltip = "Ar Condicionado";
            }

            if (pb_icon.ImageLocation == "..\\..\\hospedagem\\data\\icones\\breakfast.png")
            {
                servico_tooltip = "Café da manhã";
            }

            if (pb_icon.ImageLocation == "..\\..\\hospedagem\\data\\icones\\almoço.png")
            {
                servico_tooltip = "Almoço";
            }

            if (pb_icon.ImageLocation == "..\\..\\hospedagem\\data\\icones\\tv.png")
            {
                servico_tooltip = "TV a cabo";
            }

            if (pb_icon.ImageLocation == "..\\..\\hospedagem\\data\\icones\\pet.png")
            {
                servico_tooltip = "Espaço PET";
            }

            if (pb_icon.ImageLocation == "..\\..\\hospedagem\\data\\icones\\wifi.png")
            {
                servico_tooltip = "Wi-fi";
            }
        }

        private void pb_icon_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(this.pb_icon, servico_tooltip);
            tt.Show(servico_tooltip, this.pb_icon);
        }

        

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pb_icon_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
