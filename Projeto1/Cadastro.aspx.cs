using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DesativarLetter();
            BtCadastro.Style[HtmlTextWriterStyle.Color] = "Gray";
        }
        protected void BtHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home2.aspx");
        }
        protected void BtCd_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && dp1.SelectedValue != "" && txtData.Text != "" && txtCPF.Text != "" && dp2.SelectedValue != "")
            {
                if ((dp2.SelectedValue == "Morador" || dp2.SelectedValue == "Sindico") && txtAp.Text == "")
                {
                    Response.Write("faltam Apartamento");
                }
                else
                {
                    BancoDeDados.Nome = txtNome.Text;
                    BancoDeDados.Sexo = dp1.SelectedValue;
                    BancoDeDados.DataNascimento = txtData.Text;
                    BancoDeDados.CPF = txtCPF.Text;
                    BancoDeDados.Tipo = dp2.SelectedValue;
                    BancoDeDados.Apartamento = txtAp.Text;
                    BancoDeDados.SalvarCadastro(BancoDeDados.Nome, BancoDeDados.DataNascimento, BancoDeDados.Sexo, BancoDeDados.CPF, BancoDeDados.Tipo, BancoDeDados.Apartamento);
                    Response.Redirect("ListaCadastro.aspx");
                }
            }
            else
            {
                Response.Write("Faltam informações nos campos acima");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Queixas.aspx");
        }

        protected void BtPainel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mural.aspx");
        }

        protected void BtCadastro_Click(object sender, EventArgs e)
        {

        }

        protected void BtEntrada_Click(object sender, EventArgs e)
        {
            Response.Redirect("Entrada.aspx");
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