using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("b1");
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            Parent.Controls.Add(frm);
            frm.Parent = Parent;
            frm.FormBorderStyle = FormBorderStyle.None;    
            frm.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
