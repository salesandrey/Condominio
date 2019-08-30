<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaCadastro.aspx.cs" Inherits="Projeto1.ListaCadastro" %>

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
                &nbsp;</p>
          <asp:Button ID="BtHome" runat="server" Text="Home" Width="120px" Height="35px" OnClick="BtHome_Click" BackColor="White" />
          <asp:Label ID="lb0" runat="server" Text="Lista de Cadastros" ForeColor="White"></asp:Label>
          <asp:Button ID="BtCadastro" runat="server" Text="Cadastro" Width="120px" Height="35px" OnClick="BtCadastro_Click" BackColor="White" />
          <asp:Button ID="BtPainel" runat="server" Text="Painel de Avisos" Width="120px" Height="35px" OnClick="BtPainel_Click" BackColor="White" />
          <asp:Button ID="BtMural" runat="server" OnClick="Button4_Click" Text="Mural de Queixas" Width="120px" Height="35px" BackColor="White" />
          <asp:Button ID="BtEntrada" runat="server" Height="35px" Text="Registro de Entrada e Saída" OnClick="BtEntrada_Click" BackColor="White" />
          <asp:Button ID="BtConta" runat="server" Height="35px" Text="Contas e Recibos" BackColor="White" OnClick="BtConta_Click" Enabled="False" />
          <asp:Button ID="BtLista" runat="server" Height="35px" Text="Lista de Cadastros" BackColor="White" Enabled="False" OnClick="BtLista_Click1" />
          <asp:Button ID="logoff" runat="server" Text="Logoff" BackColor="White" Height="35px" OnClick="logoff_Click1" />
          <div id="fundo">
              <asp:Table ID="ttb" runat="server">
                  <asp:TableRow runat="server">
                      <asp:TableCell runat="server" BackColor="#CCCCFF" Width="300px">Nome</asp:TableCell>
                      <asp:TableCell runat="server" BorderColor="White" ForeColor="Black" BackColor="#CCCCFF" Width="150px">Data de Nascimento</asp:TableCell>
                      <asp:TableCell runat="server" BackColor="#CCCCFF" Width="50px">Sexo</asp:TableCell>
                      <asp:TableCell runat="server" BackColor="#CCCCFF" Width="300px">CPF</asp:TableCell>
                      <asp:TableCell runat="server" BackColor="#CCCCFF" Width="200px">Tipo</asp:TableCell>
                      <asp:TableCell runat="server" BackColor="#CCCCFF" Width="100px">Apartamento</asp:TableCell>
                  </asp:TableRow>
              </asp:Table>
        
        </div>
        
          <asp:Image ID="ImMaps" runat="server" />
          <asp:Image ID="ImTel" runat="server" />
          <asp:TextBox ID="txtLetter" runat="server"></asp:TextBox>
          <asp:Label ID="lbNu" runat="server" ForeColor="White" Text="(41)3232-3232"></asp:Label>
          <asp:Label ID="lbEnd" runat="server" Font-Bold="True" ForeColor="White" Text="R.Lorem Ipsum, s/n,Prado Velho,Curitiba-Paraná"></asp:Label>
          <asp:Button ID="btOK" runat="server" BackColor="#99CCFF" Font-Bold="True" ForeColor="White" Text="ok" OnClick="btOK_Click" />
          <asp:Label ID="lbsubL" runat="server" ForeColor="White" Text="Receba novidades no seu e-mail:"></asp:Label>
          <asp:Label ID="lbNew" runat="server" Font-Names="Bahnschrift" ForeColor="White" Text="NewsLetter"></asp:Label>
          <asp:Label ID="lbD" runat="server" Font-Bold="True" ForeColor="White" Text="2019 © A.J. Gestão de Condomínios. Todos os Direitos Reservados."></asp:Label>
         <div id="Complemento"></div>
        <link href="csss/lista.css" rel="stylesheet" />
        <link href="csss/back2.css" rel="stylesheet" />
    </form>
</body>
</html>
