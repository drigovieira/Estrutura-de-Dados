using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //geral
            UserList.XmlLoad();
            //fim geral

            //servicos
            servicos.classes.PostList.XmlLoad();
            servicos.classes.ListaEmpresa.XmlLoad();
            //fim servicos

            //hospedagem
            hospedagem.hostList.CarregarXML();
            //fim hospedagem

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
