using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto1
{
    public partial class NServicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btServicos.Style[HtmlTextWriterStyle.Color] = "gray";
            btServicos.Enabled = false;
            lbMs.Visible = false;
            DesativarLetter();
        }

        protected void BtHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void BtSobre_Click(object sender, EventArgs e)
        {
            Response.Redirect("SobreNos.aspx");
        }

        protected void BtServicos_Click(object sender, EventArgs e)
        {

        }

        protected void BtContato_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contatos.aspx");
        }

        protected void btEnter_Click(object sender, EventArgs e)
        {
            if (BancoDeDados.Logar(Login.Text, Senha.Text))
            {
                Response.Redirect("Home2.aspx");
            }
            else
            {
                lbMs.Visible = true;
            }
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
    }
}