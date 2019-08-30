<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home2.aspx.cs" Inherits="Projeto1.Home2" %>

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
         <link href="csss/back2.css" rel="stylesheet" />
         <link href="csss/SobreNos.css" rel="stylesheet" />
         <asp:Button ID="BtHome" runat="server" Text="Home" Width="120px" Height="35px" OnClick="BtHome_Click" BackColor="White" Enabled="False" />
         <asp:Button ID="BtCadastro" runat="server" Text="Cadastro" Width="120px" Height="35px" OnClick="BtCadastro_Click" BackColor="White" />
         <asp:Button ID="BtPainel" runat="server" Text="Painel de Avisos" Width="120px" Height="35px" OnClick="BtPainel_Click" BackColor="White" />
         <asp:Button ID="BtMural" runat="server" OnClick="Button4_Click" Text="Mural de Queixas" Width="120px" Height="35px" BackColor="White" />
         <asp:Button ID="BtEntrada" runat="server" Height="35px" Text="Registro de Entrada e Saída" OnClick="BtEntrada_Click" BackColor="White" />
         <asp:Button ID="BtConta" runat="server" Height="35px" Text="Contas e Recibos" OnClick="BtConta_Click" BackColor="White" Enabled="False" />
         <asp:Button ID="BtLista" runat="server" Height="35px" Text="Lista de Cadastros" BackColor="White" OnClick="BtLista_Click1" />
         <asp:Button ID="logoff" runat="server" Text="Logoff" BackColor="White" Height="35px" OnClick="logoff_Click1" />
         <asp:Image ID="ImMaps" runat="server" />
         <asp:Image ID="ImTel" runat="server" />
         <asp:Label ID="lbNu" runat="server" ForeColor="White" Text="(41)3232-3232"></asp:Label>
         <asp:Label ID="lbEnd" runat="server" Font-Bold="True" ForeColor="White" Text="R.Lorem Ipsum, s/n,Prado Velho,Curitiba-Paraná"></asp:Label>
         <asp:TextBox ID="txtLetter" runat="server"></asp:TextBox>
         <asp:Label ID="lbD" runat="server" Font-Bold="True" ForeColor="White" Text="2019 © A.J. Gestão de Condomínios. Todos os Direitos Reservados."></asp:Label>
         <asp:Button ID="btOK" runat="server" BackColor="#99CCFF" Font-Bold="True" ForeColor="White" Text="ok" OnClick="btOK_Click" />
         <asp:Label ID="lbsubL" runat="server" ForeColor="White" Text="Receba novidades no seu e-mail:"></asp:Label>
         <asp:Label ID="lbNew" runat="server" Font-Names="Bahnschrift" ForeColor="White" Text="NewsLetter"></asp:Label>
         <asp:Label ID="lbfr2" runat="server" ForeColor="White" Text="-Quadro de avisos online"></asp:Label>
         <asp:Label ID="lbfr3" runat="server" ForeColor="White" Text="-Registro de entrada e saída da portaria"></asp:Label>
         <asp:Label ID="lbfr4" runat="server" ForeColor="White" Text="E muito mais!"></asp:Label>
         <asp:Label ID="lbsub" runat="server" Text="Cadastre-se e adquira seu primeiro mês gratuitamente!" ForeColor="White"></asp:Label>
         <asp:Label ID="lbCorpo" runat="server" Text="Com o objetivo de deixar o controle de condomínios muito mais fácil e prático, a A.J. Gestão Condomínios pensou nos mais variavéis problemas enfrentados nessa gestão, e o resultado não poderia ser  melhor. Estabelecer uma comunicação para a resolução de problemas envolvendo interação de vizinhos, estabelecer  um aviso geral de reuniões para moradores e funcionários e auxiliar o síndico nos processos de administração." ForeColor="White"></asp:Label>
         <asp:Label ID="lbfr" runat="server" Text="-Cadastro de moradores, funcionários e síndico.Visando quem está utilizando e fazendo postagem no sistema." ForeColor="White"></asp:Label>
        <asp:Label ID="lbTi" runat="server" Text="Agora você tem uma nova opção no controle de condomínios !" ForeColor="White"></asp:Label>
         <asp:Image ID="ImSer" runat="server" />
         <div id="fundo"></div>
         <div id="Complemento"></div>
         <link href="csss/Back.css" rel="stylesheet" />
    </form>
</body>
</html>
