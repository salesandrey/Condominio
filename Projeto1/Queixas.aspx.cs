using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;

namespace Projeto1
{
    
    public partial class Q : System.Web.UI.Page
    {
        int ValorY;
        bool ex;
        protected void Page_Load(object sender, EventArgs e)//OK
        {
            ValorY = 400;
            ex= false;
            txtQ.Visible = false;
            btEnviar.Visible = false;
            pn1.Visible = false;
            BtMural.Style[HtmlTextWriterStyle.Color] = "Gray";
            btExcluir.Visible = false;
            DesativarLetter();
        }
        protected void BtHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home2.aspx");
        }
        void verificar()
        {
            
            if (BancoDeDados.Q.Count >= 3)
            {
                btCriar.Enabled = false;
            }
            else
            {
                btCriar.Enabled = true;
            }

        }
        void AtivarBt()
        {
            if(BancoDeDados.Q.Count>0)
            {
                btExcluir.Visible = true;
            }
            else
            {
                btExcluir.Visible = false;
            }

        }
        protected void BtCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }//OK
        protected void BtPainel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mural.aspx");
        }//OK
        protected void Button4_Click(object sender, EventArgs e)
        {

        }//OK
        protected void BtEntrada_Click(object sender, EventArgs e)
        {
            Response.Redirect("Entrada.aspx");
        }//OK
        protected void BtConta_Click(object sender, EventArgs e)
        {

        }
        protected void btVer_Click(object sender, EventArgs e) // botao visualizar
        {
            AtivarBt();
            verificar();
            pn1.Visible = true; // ativa o painel
            txtQ.Visible = false; // desativa a caixa de texto
            btEnviar.Visible = false; // desativa o botao enviar
            Label[] l = new Label[BancoDeDados.Q.Count];
            Label[] horal = new Label[BancoDeDados.Q.Count];
            for (int i = 0; i < BancoDeDados.Q.Count; i++)
            {
                l[i] = new Label();
                horal[i] = new Label();
                l[i].Width = 250;
                l[i].Height = 100;
                horal[i].Width = 250;
                horal[i].Height = 20;
                horal[i].Text = "Publicado em " + DateTime.Now;
                l[i].Text = BancoDeDados.Q.ElementAt<String>(i);
                l[i].ForeColor = Color.Black;
                l[i].BackColor = Color.White;
                horal[i].ForeColor = Color.White;
                l[i].Style[HtmlTextWriterStyle.Position] = "Absolute";
                horal[i].Style[HtmlTextWriterStyle.Position] = "Absolute";
                l[i].Style[HtmlTextWriterStyle.Top] = ValorY + "px";
                l[i].Style[HtmlTextWriterStyle.Left] = (400 + i * 270).ToString() + "px";
                horal[i].Style[HtmlTextWriterStyle.Top] = (ValorY+100).ToString() + "px";
                horal[i].Style[HtmlTextWriterStyle.Left] = (400 + i * 270).ToString() + "px";
                l[i].Visible = true;
                horal[i].Visible = true;
                pn1.Controls.Add(l[i]);
                pn1.Controls.Add(horal[i]);  
                if(ex)
                {
                    pn1.Controls.Remove(l[i]);
                    pn1.Controls.Remove(horal[i]);
                    ex = false;
                }
            }
        }
        protected void btCriar_Click(object sender, EventArgs e) // botao criar pressionar
        {
            txtQ.Visible = true; // ativa a caixa de texto
            btEnviar.Visible = true; // ativa o botao enviar
            pn1.Visible = false; // desativa o painel de reclamações
        }
        protected void btEnviar_Click(object sender, EventArgs e) // botao enviar
        {
            if (txtQ.Text != "")
            {
                BancoDeDados.SalvarQueixa(txtQ.Text); // adiciona o texto na lista de queixas do metedo bancodedados
                btEnviar.Visible = false;//desativa o botao
                txtQ.Visible = false;//desativa a caixa de texto
                verificar();
            }
        }

        protected void btExcluir_Click(object sender, EventArgs e)
        {
            for(int i=BancoDeDados.Q.Count;i>0;i--)
            {
                BancoDeDados.removerQueixa(i-1);
                ex = true;
            }
            btExcluir.Visible = false;
            verificar();
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