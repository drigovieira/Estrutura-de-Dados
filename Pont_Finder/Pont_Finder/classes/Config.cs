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
            servicos.socialist.MensagemList.XmlLoad();
            servicos.socialist.ChatList.XmlLoad();
            //fim servicos

            //hospedagem
            hospedagem.hostList.CarregarXML();
            hospedagem.roomList.CarregarXML();
            hospedagem.classes.reserveList.CarregarXML();
            //fim hospedagem

            //avalie
            avalie.PostList.XmlLoad();
            avalie.classes.ComentariosList.XmlLoad();
            //fim avalie

            //eventos
            eventos.classes.Empresa_List.XmlLoad();
            eventos.Classes.Eventos_List.XmlLoad();
            //fim eventos

            //alimentos
            alimentos.CompanyList.XmlLoad();
            alimentos.classes.EvaluationList.XmlLoad();
            alimentos.ListCardapio.XmlLoad();
            //fim Alimentos


        }

        public static void Save()
        {
            //geral
            UserList.XmlSave();

            //servicos
            servicos.classes.PostList.XmlSave();
            servicos.classes.ListaEmpresa.XmlSave();
            servicos.socialist.MensagemList.XmlSave();
            servicos.socialist.ChatList.XmlSave();
            //fim servicos

            //hospedagem
            hospedagem.hostList.XmlSave();
            hospedagem.roomList.XmlSave();
            hospedagem.classes.reserveList.XmlSave();
            //fim hospedagem

            //avalie
            avalie.PostList.XmlSave();
            avalie.classes.ComentariosList.XmlSave();
            //fim avalie

            //eventos
            eventos.classes.Empresa_List.XmlSave();
            eventos.Classes.Eventos_List.XmlSave();
            //fim eventos

            //alimentos
            alimentos.CompanyList.XmlSave();
            alimentos.classes.EvaluationList.XmlSave();
            alimentos.ListCardapio.XmlSave();
            //fim Alimentos

        }

    }
}
