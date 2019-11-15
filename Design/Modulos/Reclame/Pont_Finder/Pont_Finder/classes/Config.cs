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

            //avalie
            avalie.PostList.XmlLoad();
            //fim avalie

            //eventos
            eventos.classes.Empresa_List.XmlLoad();
            eventos.Classes.Eventos_List.XmlLoad();
            //fim eventos


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

            //avalie
            avalie.PostList.XmlSave();
            //fim avalie

            //eventos
            eventos.classes.Empresa_List.XmlSave();
            eventos.Classes.Eventos_List.XmlSave();
            //fim eventos

        }

    }
}
