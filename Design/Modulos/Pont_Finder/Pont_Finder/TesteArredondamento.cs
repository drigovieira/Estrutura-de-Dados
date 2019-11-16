using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    class TesteArredondamento : PictureBox 
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, 50, 50);
            this.Region = new System.Drawing.Region(graphics);
            base.OnPaint(pe);
        }
    }
}
