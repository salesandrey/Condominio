using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Projeto1
{
    public static class BancoDeDados
    {

        public static string LoginADM = "ADM";
        public static string SenhaADM = "ADM";
        public static string NewLetterS = "";
        public static bool LetterN = false;
        public static string Nome;
        public static string Sexo;
        public static String DataNascimento;
        public static string Tipo;
        public static string CPF;
        public static string Apartamento;
        public static List<String> Nomes = new List<string>();
        public static List<String> DataN = new List<string>();
        public static List<String> SexoLista = new List<string>();
        public static List<String> CPFs = new List<string>();
        public static List<String> Tps = new List<string>();
        public static List<String> Aps = new List<string>();
        public static List<String> Avisos = new List<string>();
        public static List<String> TipoAviso = new List<string>();
        public static List<String> HorarioAviso = new List<string>();
        public static List<String> HorarioChegada = new List<string>();



        public static List<String> Q = new List<string>();
        public static void SalvarCadastro(string n, string d, string s,string c, string t, string a)
        {
            Nomes.Add(n);
            DataN.Add(d);
            SexoLista.Add(s);
            CPFs.Add(c);
            Tps.Add(t);
            Aps.Add(a);
        }

        public static void SalvarQueixa(string k)
        {
            Q.Add(k);
        }
        public static void removerQueixa(int a)
        {
            Q.Remove(Q.ElementAt(a));
        }
        public static void SalvarChegada(string k,string tp, string tp2, string nm)
        {
            string a;
            if(tp=="Entrada")
            {
               a = nm + " "+"entrou em"+ k + "."  + "Tipo de visita:" + tp2 ;
            }
            else
            {
                a = nm + " " + "saiu em" + k + "." + "Tipo de visita:" + tp2;
            }

            HorarioChegada.Add(a);
        }
        public static bool Logar(string a, string b) // login do admin
        {
            if(a==LoginADM && b == SenhaADM)
            {
                return true;
            }
            else
            {
                return false;
            }      
        } 
        public static void ELetter(string s)
        {
            NewLetterS = s;
            LetterN = true;
        }

    }
}