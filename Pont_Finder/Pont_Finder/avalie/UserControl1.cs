using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie
{
    public partial class UserControl1 : UserControl
    {


        


        public UserControl1()
        {
            InitializeComponent();
        }


        public void Att()
        {
            

            foreach (var item in PostList.poster)
            {
                userhora.Text = (item.Tempohora);
                userboxproblema.Text = (item.Tipoproblema);
                userboxlocalizacao.Text = (item.Localizao);
                userboxdescricao.Text = (item.Desc);
            }

        }

        public void Del()
        {
            userhora.Text = "";
            userboxproblema.Text = "";
            userboxlocalizacao.Text = "";
            userboxdescricao.Text = "";
        }
    }
}
