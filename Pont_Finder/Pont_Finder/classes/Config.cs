using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.classes
{
    class Config
    {

        public static void Load()
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
            hospedagem.roomList.CarregarXML();
            //fim hospedagem
        }

        public static void Save()
        {
            //geral
            UserList.XmlSave();

            //servicos
            servicos.classes.PostList.XmlSave();
            servicos.classes.ListaEmpresa.XmlSave();
            //fim servicos

            //hospedagem
            hospedagem.hostList.XmlSave();
            hospedagem.roomList.XmlSave();
            //fim hospedagem
        }

    }
}
