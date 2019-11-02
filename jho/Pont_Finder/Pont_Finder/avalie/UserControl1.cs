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
            feed.Items.Clear();

            foreach (var item in PostList.poster)
            {
                feed.Items.Add(item.Tempohora);
                feed.Items.Add("");
                feed.Items.Add("Tipo do problema :");
                feed.Items.Add(item.Tipoproblema);
                feed.Items.Add("");
                feed.Items.Add("Localizado :");
                feed.Items.Add(item.Localizao);
                feed.Items.Add("");
                feed.Items.Add("Descrição :");
                feed.Items.Add(item.Desc);
            }

        }
    }
}
