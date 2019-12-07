using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos
{
     class Cardapio
    {
        private float preco;
        private string  nome, image;
        private float qtd;
        private List<string> ingredientes, categoria;
        private bool status;
        private int id, idEmpresa, quantos;

        public float Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public List<string> Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public float Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
        public List<string> Ingredientes
        {
            get { return ingredientes; }
            set { ingredientes = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        public int Quantos
        {
            get { return quantos; }
            set { quantos = value; }
        }
    }
}
