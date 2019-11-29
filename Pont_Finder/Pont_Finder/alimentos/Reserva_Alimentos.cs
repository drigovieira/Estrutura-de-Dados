﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class Reserva_Alimentos : Form
    {
        private int local, Company;
        public Reserva_Alimentos(int idEmpresa)
        {
            Company = idEmpresa;
            local = 0;
            InitializeComponent();
            Listar();
        }
        public void Listar()
        {
            foreach(var item in ListCardapio.selectAll())
            {
                if (item.IdEmpresa == Company)
                {
                    Item_Alimentos AliItem = new Item_Alimentos(item.Preco, item.Nome, item.Image, item.Qtd, item.Ingredientes, item.Categoria, item.Id);
                    AliItem.Location = new Point(0, local);
                    local = local + AliItem.Height + 5;
                    menu.Controls.Add(AliItem);
                }
            }
        }
    }
}
