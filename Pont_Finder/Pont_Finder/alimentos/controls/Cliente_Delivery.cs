﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos.controls
{
    public partial class Cliente_Delivery : UserControl
    {
        private int IndexPedido;
        public Cliente_Delivery(int idPedido)
        {
            IndexPedido = idPedido;
            InitializeComponent();
        }
    }
}
