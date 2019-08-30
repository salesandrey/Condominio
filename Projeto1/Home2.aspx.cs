using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto1
{
    public partial class Home2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BtHome.Style[HtmlTextWriterStyle.Color] = "Gray";
            BtHome.Enabled = false;
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

        protected void BtHome_Click(object sender, EventArgs e)
        {

        }

        protected void BtCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }

        protected void BtPainel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mural.aspx");
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

        protected void BtLista_Click(object sender, EventArgs e)
        {

        }

        protected void BtLista_Click1(object sender, EventArgs e)
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