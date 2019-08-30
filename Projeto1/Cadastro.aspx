<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Projeto1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 593px;
            width: 1370px;
        }
    </style>
    </head>
<body>
        <form id="form1" runat="server">
           <link href="csss/cdcss.css" rel="stylesheet" />
           
            <div id="Logo"></div>
            <div id="FACE"></div>
            <div id="GMAIL"></div>
            <div id="TWITTER"></div>
            <div id="WHATS"></div>
            <p>
                &nbsp;</p>
            
            <asp:Button ID="BtHome" runat="server" Text="Home" Width="120px" Height="35px" OnClick="BtHome_Click" BackColor="White" />
            <asp:Button ID="BtCadastro" runat="server" Text="Cadastro" Width="120px" Height="35px" OnClick="BtCadastro_Click" Enabled="False" BackColor="White" />
            <asp:Button ID="BtPainel" runat="server" Text="Painel de Avisos" Width="120px" Height="35px" OnClick="BtPainel_Click" BackColor="White" />
            <asp:Button ID="BtMural" runat="server" OnClick="Button4_Click" Text="Mural de Queixas" Width="120px" Height="35px" BackColor="White" />
            <asp:Button ID="BtEntrada" runat="server" Height="35px" Text="Registro de Entrada e Saída" OnClick="BtEntrada_Click" BackColor="White" />
            <asp:Button ID="BtConta" runat="server" Height="35px" Text="Contas e Recibos" BackColor="White" Enabled="False" />
            <asp:Button ID="BtLista" runat="server" Height="35px" Text="Lista de Cadastros" BackColor="White" OnClick="BtLista_Click" />
            <asp:Button ID="logoff" runat="server" Text="Logoff" BackColor="White" Height="35px" OnClick="logoff_Click1" />
        <div id="fundo">
            <asp:Label ID="Label1" runat="server" Text="Cadastro"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Data de Nascimento :"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="Sexo:"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="CPF:"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="Tipo:"></asp:Label>
            <asp:Label ID="Label7" runat="server" Text="Apartamento:"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtData" runat="server" TextMode="Date"></asp:TextBox>
            <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtAp" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
            
            <asp:DropDownList ID="dp1" runat="server">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Feminino</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="dp2" runat="server">
                <asp:ListItem>Morador</asp:ListItem>
                <asp:ListItem>Funcionario</asp:ListItem>
                <asp:ListItem>Sindico</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="BtCd" runat="server" OnClick="BtCd_Click" Text="Cadastrar" />
            <asp:Image ID="ImMaps" runat="server" />
            <asp:Image ID="ImTel" runat="server" />
            <asp:TextBox ID="txtLetter" runat="server"></asp:TextBox>
            <asp:Label ID="lbNu" runat="server" ForeColor="White" Text="(41)3232-3232"></asp:Label>
            <asp:Label ID="lbEnd" runat="server" Font-Bold="True" ForeColor="White" Text="R.Lorem Ipsum, s/n,Prado Velho,Curitiba-Paraná"></asp:Label>
            <asp:Button ID="btOK" runat="server" BackColor="#99CCFF" Font-Bold="True" ForeColor="White" Text="ok" OnClick="btOK_Click" />
            <asp:Label ID="lbsubL" runat="server" ForeColor="White" Text="Receba novidades no seu e-mail:"></asp:Label>
            <asp:Label ID="lbNew" runat="server" Font-Names="Bahnschrift" ForeColor="White" Text="NewsLetter"></asp:Label>
            <asp:Label ID="lbD" runat="server" Font-Bold="True" ForeColor="White" Text="2019 © A.J. Gestão de Condomínios. Todos os Direitos Reservados."></asp:Label>
            </div>
            <div id="Complemento"></div>
            
            <link href="csss/back2.css" rel="stylesheet" />
            <link href="csss/Back.css" rel="stylesheet" />
        </form>
</body>
</html>
