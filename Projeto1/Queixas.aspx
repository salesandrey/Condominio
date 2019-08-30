<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Queixas.aspx.cs" Inherits="Projeto1.Q" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Logo"></div>
        <div id="FACE"></div>
        <div id="GMAIL"></div>
        <div id="TWITTER"></div>
        <div id="WHATS"></div>
         <p>
                &nbsp;</p>&nbsp;<link href="csss/QueixaCs.css" rel="stylesheet" /><asp:Button ID="BtHome" runat="server" Text="Home" Width="120px" Height="35px" OnClick="BtHome_Click" BackColor="White" />
          <asp:Button ID="BtCadastro" runat="server" Text="Cadastro" Width="120px" Height="35px" OnClick="BtCadastro_Click" BackColor="White" />
          <asp:Button ID="BtPainel" runat="server" Text="Painel de Avisos" Width="120px" Height="35px" OnClick="BtPainel_Click" BackColor="White" />
          <asp:Button ID="BtMural" runat="server" OnClick="Button4_Click" Text="Mural de Queixas" Width="120px" Height="35px" BackColor="White" Enabled="False" EnableTheming="True" Font-Bold="False" />
          <asp:Button ID="BtEntrada" runat="server" Height="35px" Text="Registro de Entrada e Saída" OnClick="BtEntrada_Click" BackColor="White" />
          <asp:Button ID="BtConta" runat="server" Height="35px" Text="Contas e Recibos" OnClick="BtConta_Click" BackColor="White" Enabled="False" />
          <asp:Button ID="BtLista" runat="server" Height="35px" Text="Lista de Cadastros" BackColor="White" OnClick="BtLista_Click" />
          <asp:Button ID="btExcluir" runat="server" OnClick="btExcluir_Click" Text="Excluir" />
          <asp:Button ID="logoff" runat="server" Text="Logoff" BackColor="White" Height="35px" OnClick="logoff_Click1" />
          <div id="fundo">
              <asp:Button ID="btVer" runat="server" Text="Visualizar" OnClick="btVer_Click" />
              <asp:Button ID="btCriar" runat="server" Text="Criar" OnClick="btCriar_Click" />
              <asp:Button ID="btEnviar" runat="server" Text="Enviar" OnClick="btEnviar_Click" />
              <asp:TextBox ID="txtQ" runat="server" Height="111px" Width="325px"></asp:TextBox>
              <asp:Label ID="lb1" runat="server" Text="Queixas"></asp:Label>
              <asp:Panel ID="pn1" runat="server">
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
        <link href="csss/back2.css" rel="stylesheet" />
        <link href="csss/Back.css" rel="stylesheet" />
    </form>
</body>
</html>
