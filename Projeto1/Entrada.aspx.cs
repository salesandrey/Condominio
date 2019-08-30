using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto1
{
    public partial class Entrada : System.Web.UI.Page
    {
        static List<String> lista1, lista2;
        int contador1, contador2;
        const int limite = 3;
        protected void Page_Load(object sender, EventArgs e)//OK
        {
            if(lista1==null && lista2==null)
            {
                lista1 = new List<String>();
                lista2 = new List<String>();
                contador1 = 0;
                contador2 = 0;
            }
            carregarEntradasSaidas();
            DesativarLetter();
            BtEntrada.Style[HtmlTextWriterStyle.Color] = "Gray";
        }

        void carregarEntradasSaidas()
        {
            Label[] REntrada = new Label[lista1.Count];
            Label[] RSaida = new Label[lista2.Count];
            for(int i=0; i< REntrada.Length;i++)
            {
                REntrada[i] = new Label();
                REntrada[i].Width = 200;
                REntrada[i].Height = 80;
                REntrada[i].BackColor = System.Drawing.Color.Yellow;
                REntrada[i].Text = lista1.ElementAt(i);
                REntrada[i].Style[HtmlTextWriterStyle.Position] = "Absolute";
                REntrada[i].Style[HtmlTextWriterStyle.Top] = (300+ i*100).ToString() +"px";
                REntrada[i].Style[HtmlTextWriterStyle.Left] = "20px";
                pn122.Controls.Add(REntrada[i]);
            }
            for (int i = 0; i < RSaida.Length; i++)
            {
                RSaida[i] = new Label();
                RSaida[i].Width = 200;
                RSaida[i].Height = 80;
                RSaida[i].BackColor = System.Drawing.Color.Green;
                RSaida[i].Text = lista2.ElementAt(i);
                RSaida[i].Style[HtmlTextWriterStyle.Position] = "Absolute";
                RSaida[i].Style[HtmlTextWriterStyle.Top] = (300 + i * 100).ToString() + "px";
                RSaida[i].Style[HtmlTextWriterStyle.Left] = "240px";
                pn122.Controls.Add(RSaida[i]);
            }
        } // OK
        protected void BtHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home2.aspx");
        } //OK
        protected void BtCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        } // OK
        protected void BtPainel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mural.aspx");
        } // OK
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Queixas.aspx");
        } //OK
        protected void registrar_Click(object sender, EventArgs e)
        {
            if(txtNoome.Text!="")
            {
                if (dp12.SelectedValue=="Entrada")
                {
                BancoDeDados.SalvarChegada(DateTime.Now.ToString(), dp12.SelectedValue, dp13.SelectedValue, txtNoome.Text);
                    if (lista1.Count == limite)
                    {
                        lista1.Remove(lista1.ElementAt(contador1));
                        lista1.Add(BancoDeDados.HorarioChegada.Last());
                        contador1++;
                        if (contador1 == limite)
                        {
                            contador1 = 0;
                        }
                    }
                    else
                    {
                        lista1.Add(BancoDeDados.HorarioChegada.Last());

                    }
                }
                if (dp12.SelectedValue == "Saida")
                {
                    BancoDeDados.SalvarChegada(DateTime.Now.ToString(), dp12.SelectedValue, dp13.SelectedValue, txtNoome.Text);
                    if (lista2.Count == limite)
                    {
                        lista2.Remove(lista2.ElementAt(contador2));
                        lista2.Add(BancoDeDados.HorarioChegada.Last());
                        contador2++;
                        if (contador2 == limite)
                        {
                            contador2 = 0;
                        }
                    }
                    else
                    {
                        lista2.Add(BancoDeDados.HorarioChegada.Last());

                    }
                }
                carregarEntradasSaidas();
            }
        } // OK
        protected void btOK_Click(object sender, EventArgs e)
        {
            BancoDeDados.ELetter(txtLetter.Text);
            DesativarLetter();
        }
        void DesativarLetter()
        {
            if (BancoDeDados.LetterN)
            {
                btOK.Visible = false;
                lbNew.Visible = false;
                lbsubL.Visible = false;
                txtLetter.Visible = false;
            }
        }

        protected void BtLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaCadastro.aspx");
        }


        protected void logoff_Click1(object sender, EventArgs e)
        {
            BancoDeDados.LoginADM = "";
            BancoDeDados.SenhaADM = "";
            Response.Redirect("Home.aspx");
        }


        protected void BtEntrada_Click(object sender, EventArgs e)
        {

        }

        protected void BtConta_Click(object sender, EventArgs e)
        {

        }
    }
}