using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder
{
    class Model
    {
        public static Color Servicos_Cor
        {
            get => Color.FromArgb(30, 125, 204); 
        }

        public static Color Servicos_Cor_Back
        {
            get => Color.FromArgb(233, 235, 238);
        }

        public static Color Hospedagem_Cor
        {
            get => Color.FromArgb(69, 172, 20);
        }


        public static Image Img_Voltar
        {
            get => Properties.Resources.back_1;
        }

        public static Image Img_Voltar_Click
        {
            get => Properties.Resources.back_2;
        }

    }
}
