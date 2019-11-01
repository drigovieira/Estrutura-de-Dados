using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_quartos
{
    static class Program
    {
        [STAThread]
        static void Main(string [] args)
        {

            string str = "Nome: {0} \nEmail: {1} \nSenha: {2} \nCPF: {3} \nStatus: {4} \n";

            lista_quartos lista_de_quartos = new lista_quartos();

            quarto Quarto = new quarto();

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
