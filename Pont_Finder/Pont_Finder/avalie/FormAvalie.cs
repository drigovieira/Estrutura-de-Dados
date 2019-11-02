using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pont_Finder.avalie;

namespace Pont_Finder
{
    public partial class FormAvalie : Form
    {
        int leftcontrol = 10;
        int let = 0;
        int let2 = 0;

        public FormAvalie()
        {
            InitializeComponent();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formPostar fp = new formPostar();
            fp.ShowDialog();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 t1 = new UserControl1();

            panel3.Controls.Add(t1);

            t1.Top = let * let2;
            let = 25;
            let2 = 25;

            t1.Left = 5;

            leftcontrol = 0;
            leftcontrol = leftcontrol;
            t1.Att();



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


