﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SobreNos.aspx.cs" Inherits="Projeto1.Home" %>

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
        <div id="FOTO1"></div>
        <div id="FOTO2"></div>
        <asp:TextBox ID="Login" runat="server"></asp:TextBox>
        <asp:TextBox ID="Senha" runat="server"></asp:TextBox>
        <asp:Label ID="lb1" runat="server" Text="Login:"></asp:Label>
        <asp:Label ID="lb2" runat="server" Text="Senha:"></asp:Label>
        <asp:Button ID="btEnter" runat="server" Font-Names="Bahnschrift Light" Text="Entrar" OnClick="btEnter_Click" />
        <link href="csss/SemLog.css" rel="stylesheet" />
        <link href="csss/back2.css" rel="stylesheet" />
        <link href="csss/Back.css" rel="stylesheet" />
        <p>
                &nbsp;</p>
        <asp:Button ID="BtHome" runat="server" Text="Home" Width="120px" Height="35px" OnClick="BtHome_Click" BackColor="White" />
                <asp:Label ID="lo1" runat="server" Text="Sobre Nós"></asp:Label>
                <asp:Label ID="lo2" runat="server" Text="Trabalho Acadêmico da Disciplina Experiência Criativa.BSI-Bacharelado em Sistemas de Informação. PUCPR"></asp:Label>
                <asp:Label ID="lo4" runat="server" Text="Andrey Sales BSI"></asp:Label>
        <link href="csss/Personc.css" rel="stylesheet" />
        <asp:Label ID="lbMs" runat="server" ForeColor="#FF6600" Text="Nome de Usuário ou Senha Incorretos"></asp:Label>
        <asp:Image ID="ImMaps" runat="server" />
        <asp:Image ID="ImTel" runat="server" />
        <asp:Label ID="lbEn" runat="server" Font-Names="Bahnschrift Condensed" Text="Entrar no Sistema" ValidateRequestMode="Disabled"></asp:Label>
        <asp:Label ID="lbNu" runat="server" ForeColor="White" Text="(41)3232-3232"></asp:Label>
        <asp:Label ID="lbEnd" runat="server" Font-Bold="True" ForeColor="White" Text="R.Lorem Ipsum, s/n,Prado Velho,Curitiba-Paraná"></asp:Label>
        <asp:TextBox ID="txtLetter" runat="server"></asp:TextBox>
        <asp:Button ID="btOK" runat="server" BackColor="#99CCFF" Font-Bold="True" ForeColor="White" Text="ok" OnClick="btOK_Click" />
        <asp:Label ID="lbsubL" runat="server" ForeColor="White" Text="Receba novidades no seu e-mail:"></asp:Label>
        <asp:Label ID="lbNew" runat="server" Font-Names="Bahnschrift" ForeColor="White" Text="NewsLetter"></asp:Label>
        <asp:Label ID="lbD" runat="server" Font-Bold="True" ForeColor="White" Text="2019 © A.J. Gestão de Condomínios. Todos os Direitos Reservados."></asp:Label>
        <asp:Button ID="BtSobre" runat="server" Text="Sobre Nós" Width="120px" Height="35px" OnClick="BtSobre_Click" BackColor="White" Enabled="False" />
        <asp:Button ID="btServicos" runat="server" Text="Nossos Serviços" Width="120px" Height="35px" OnClick="BtServicos_Click" BackColor="White" />
        <asp:Button ID="BtContato" runat="server" Text="Contato" Width="120px" Height="35px" OnClick="BtContato_Click" BackColor="White" />

        <div id="fundo">
                <asp:Label ID="lo3" runat="server" Text="Jhonatan Medeiros BSI"></asp:Label>
                </div>
        <div id="Complemento"></div>
        <div>
        </div>
    </form>
</body>
</html>
