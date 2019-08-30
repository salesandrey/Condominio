using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;

namespace Projeto1
{
    public partial class M : System.Web.UI.Page
    {
        static bool testatv = true;
        protected void Page_Load(object sender, EventArgs e)
        {           
            if(testatv)
            {
                TesteFuncionamento.AdicionarAvisosTeste();
                testatv = false;
            }
            
            CarregarAvisos();
            DesativarLetter();
            BtPainel.Style[HtmlTextWriterStyle.Color] = "Gray";
        }

        void CarregarAvisos()
        {
            Label[] avisos = new Label[BancoDeDados.Avisos.Count];
            Label[] Horaavisos = new Label[BancoDeDados.HorarioAviso.Count];
            pn1.Visible = true;
            pn2.Visible = true;
            for(int i=0;i<BancoDeDados.Avisos.Count;i++)
            {
                avisos[i] = new Label();
                Horaavisos[i] = new Label();
                avisos[i].Text = BancoDeDados.Avisos.ElementAt(i);
                avisos[i].Style[HtmlTextWriterStyle.Color] = "Black";
                avisos[i].Width = 150;
                avisos[i].Height = 150;
                Horaavisos[i].Text = BancoDeDados.HorarioAviso.ElementAt(i);
                Horaavisos[i].Style[HtmlTextWriterStyle.Color] = "White";
                Horaavisos[i].Width = 150;
                Horaavisos[i].Height = 20;

                switch (BancoDeDados.TipoAviso.ElementAt(i))
                {
                    case "Reuniao":
                        {
                            avisos[i].BackColor = Color.Blue;
                            break;
                        }
                    case "Anuncio":
                        {
                            avisos[i].BackColor = Color.DarkGreen;
                            break;
                        }
                    case "Atas":
                        {
                            avisos[i].BackColor = Color.Yellow;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                pn1.Controls.Add(avisos[i]);
                pn2.Controls.Add(Horaavisos[i]);
                Horaavisos[i].Style[HtmlTextWriterStyle.Position] = "Absolute";
                Horaavisos[i].Style[HtmlTextWriterStyle.Top] = "450px";
                Horaavisos[i].Style[HtmlTextWriterStyle.Left] = (100 + i * 170).ToString() + "px";
                avisos[i].Style[HtmlTextWriterStyle.Position] = "Absolute";
                avisos[i].Style[HtmlTextWriterStyle.Top] = "300px";
                avisos[i].Style[HtmlTextWriterStyle.Left] = (100+i*170).ToString()+"px";
            }

        }

        protected void BtHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home2.aspx");
        }

        protected void BtCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }

        protected void BtPainel_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Queixas.aspx");
        }

        protected void BtEntrada_Click(object sender, EventArgs e)
        {
            Response.Redirect("Entrada.aspx");
        }

        protected void BtConta_Click(object sender, EventArgs e)
        {

        }

        protected void btcriar_Click(object sender, EventArgs e)
        {

        }

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
    }
}