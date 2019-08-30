<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Entrada.aspx.cs" Inherits="Projeto1.Entrada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <link href="csss/back2.css" rel="stylesheet" />
        <link href="csss/Saidas.css" rel="stylesheet" />
        <div id="Logo"></div>
        <div id="FACE"></div>
        <div id="GMAIL"></div>
        <div id="TWITTER"></div>
        <div id="WHATS"></div>
        <p>
                &nbsp;</p>
          <asp:Button ID="BtHome" runat="server" Text="Home" Width="120px" Height="35px" OnClick="BtHome_Click" BackColor="White" />
          <asp:Label ID="lbSair" runat="server" Font-Bold="True" ForeColor="White" Text="Registro de Saídas"></asp:Label>
        <asp:Label ID="lbEntrar" runat="server" Font-Bold="True" ForeColor="White" Text="Registro de Entradas"></asp:Label>
        <asp:Button ID="registrar" runat="server" Font-Names="Bahnschrift SemiBold" OnClick="registrar_Click" Text="Registrar" />
        <asp:TextBox ID="txtNoome" runat="server"></asp:TextBox>
          <asp:Button ID="BtCadastro" runat="server" Text="Cadastro" Width="120px" Height="35px" OnClick="BtCadastro_Click" BackColor="White" />

          <asp:Calendar ID="clda" runat="server" BackColor="White" ForeColor="Black"></asp:Calendar>
        <asp:DropDownList ID="dp13" runat="server">
            <asp:ListItem>Familiar</asp:ListItem>
            <asp:ListItem>Serviço</asp:ListItem>
            <asp:ListItem>Emergência</asp:ListItem>
            <asp:ListItem>Convidado</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="dp12" runat="server">
            <asp:ListItem>Entrada</asp:ListItem>
            <asp:ListItem>Saida</asp:ListItem>
        </asp:DropDownList>
          <asp:Button ID="BtPainel" runat="server" Text="Painel de Avisos" Width="120px" Height="35px" OnClick="BtPainel_Click" BackColor="White" />
          <asp:Button ID="BtMural" runat="server" OnClick="Button4_Click" Text="Mural de Queixas" Width="120px" Height="35px" BackColor="White" EnableTheming="True" Font-Bold="False" />
          <asp:Button ID="BtEntrada" runat="server" Height="35px" Text="Registro de Entrada e Saída" OnClick="BtEntrada_Click" BackColor="White" Enabled="False" Font-Bold="False" />
          <asp:Button ID="BtConta" runat="server" Height="35px" Text="Contas e Recibos" OnClick="BtConta_Click" BackColor="White" Enabled="False" />
        <asp:Button ID="BtLista" runat="server" Height="35px" Text="Lista de Cadastros" BackColor="White" OnClick="BtLista_Click" />
          <asp:Label ID="lbNomeConv" runat="server" ForeColor="White" Text="Nome:"></asp:Label>
        <asp:Button ID="logoff" runat="server" Text="Logoff" BackColor="White" Height="35px" OnClick="logoff_Click1" />
        <div id="fundo">
            <asp:Panel ID="pn122" runat="server">
            </asp:Panel>
        </div>
        <div id="Complemento"></div>
        <asp:Image ID="ImMaps" runat="server" />
        <asp:Image ID="ImTel" runat="server" />
        <asp:TextBox ID="txtLetter" runat="server"></asp:TextBox>
        <asp:Label ID="lbNu" runat="server" ForeColor="White" Text="(41)3232-3232"></asp:Label>
        <asp:Label ID="lbEnd" runat="server" Font-Bold="True" ForeColor="White" Text="R.Lorem Ipsum, s/n,Prado Velho,Curitiba-Paraná"></asp:Label>
        <asp:Button ID="btOK" runat="server" BackColor="#99CCFF" Font-Bold="True" ForeColor="White" Text="ok" OnClick="btOK_Click" />
        <asp:Label ID="lbsubL" runat="server" ForeColor="White" Text="Receba novidades no seu e-mail:"></asp:Label>
        <asp:Label ID="lbNew" runat="server" Font-Names="Bahnschrift" ForeColor="White" Text="NewsLetter"></asp:Label>
        <asp:Label ID="lbD" runat="server" Font-Bold="True" ForeColor="White" Text="2019 © A.J. Gestão de Condomínios. Todos os Direitos Reservados."></asp:Label>
        <link href="csss/Back.css" rel="stylesheet" />
    </form>
</body>
</html>
