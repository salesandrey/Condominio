using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;

namespace Projeto1
{
    public partial class ListaCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CriarCelulas();
            BtLista.Style[HtmlTextWriterStyle.Color] = "Gray";
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

        void CriarCelulas()
        {
            TableCell[] celula = new TableCell[6];
            TableRow[] linha = new TableRow[BancoDeDados.Nomes.Count];

            for (int i = 0; i < BancoDeDados.Nomes.Count; i++)
            {
                linha[i] = new TableRow();
                
                for (int j = 0; j < 6; j++)
                {
                    celula[j] = new TableCell();
                    AjustarTamanhoCelula(j, celula[j], i);
                    celula[j].Height = 20;
                    celula[j].BackColor = Color.White;
                    linha[i].Cells.Add(celula[j]);
                }
                ttb.Rows.Add(linha[i]);
            }

        }
        void AjustarTamanhoCelula(int numero,TableCell cell,int numero2)
        {
            switch(numero)
            {
                case 0:
                    cell.Width = 300;
                    cell.Text = BancoDeDados.Nomes.ElementAt(numero2);
                    break;
                case 1:
                    cell.Width = 150;
                    cell.Text = BancoDeDados.DataN.ElementAt(numero2);
                    break;
                case 2:
                    cell.Width = 50;
                    cell.Text = BancoDeDados.SexoLista.ElementAt(numero2);
                    break;
                case 3:
                    cell.Width = 300;
                    cell.Text = BancoDeDados.CPFs.ElementAt(numero2);
                    break;
                case 4:
                    cell.Width = 200;
                    cell.Text = BancoDeDados.Tps.ElementAt(numero2);
                    break;
                case 5:
                    cell.Width = 100;
                    cell.Text = BancoDeDados.Aps.ElementAt(numero2);
                    break;
                default:
                    cell.Width = 300;
                    cell.Text = BancoDeDados.Nomes.ElementAt(numero2);
                    break;
            }
        }

        protected void BtLista_Click1(object sender, EventArgs e)
        {

        }

        protected void logoff_Click1(object sender, EventArgs e)
        {
            BancoDeDados.LoginADM = "";
            BancoDeDados.SenhaADM = "";
            Response.Redirect("Home.aspx");
        }
    }
}