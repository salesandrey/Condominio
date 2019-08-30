using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto1
{
    public static class TesteFuncionamento
    {




        public static void AdicionarAvisosTeste()
        {
            string a = "Reunião de Condominio mensal marcada para o dia 22 de fevereiro às 18:00 no salão de festas do condominio.";
            string b = "Novas atas realizadas no dia 29 de janeiro aprovadas.";
            string c = "Vaga de garagem disponivel, favor entra em contato com o proprietario do apartamento 144.";

            string d = "Publicado em 19/05/2018";
            string e = "Publicado em 20/01/2019";
            string f = "Publicado em 09/01/2019";
            BancoDeDados.HorarioAviso.Add(d);
            BancoDeDados.HorarioAviso.Add(e);
            BancoDeDados.HorarioAviso.Add(f);
            BancoDeDados.Avisos.Add(a);
            BancoDeDados.Avisos.Add(b);
            BancoDeDados.Avisos.Add(c);
            BancoDeDados.TipoAviso.Add("Reuniao");
            BancoDeDados.TipoAviso.Add("Atas");
            BancoDeDados.TipoAviso.Add("Anuncio");
        }
    }

   
}