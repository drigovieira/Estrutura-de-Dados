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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            Parent.Controls.Add(frm);
            frm.Parent = Parent;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            this.Dispose();
        }
    }
}
