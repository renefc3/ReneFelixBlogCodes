<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exemplo.aspx.cs" Inherits="ExemploVariaveis.Exemplo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
    <fieldset title="Variavel estatica">
       <br />
        <asp:Label ID="LBL_Estatico" runat="server" Text="Variavel Estatica"></asp:Label>
        <asp:TextBox ID="TXT_ValorEstatico" runat="server"></asp:TextBox>
        <br />
        Valor Atual:
        <asp:Label ID="LBL_EstaticoAtual" runat="server" Text=""></asp:Label>
    </fieldset>
    <br />
    <br />

     <fieldset title="Variavel de Cache">
        <br />
        <asp:Label ID="LBL_Cache" runat="server" Text="Variavel de Cache"></asp:Label>
        <asp:TextBox ID="TXT_ValorCache" runat="server"></asp:TextBox>
        <br />
        Valor Atual:
        <asp:Label ID="LBL_CacheAtual" runat="server" Text=""></asp:Label>
    </fieldset>

    <br />
    <br />

     <fieldset title="Variavel de Sessão">
        <br />
        <asp:Label ID="LBL_Sessao" runat="server" Text="Variavel de Sessão"></asp:Label>
        <asp:TextBox ID="TXT_ValorSessao" runat="server"></asp:TextBox>
        <br />
        Valor Atual:
        <asp:Label ID="LBL_SessaoAtual" runat="server" Text=""></asp:Label>
    </fieldset>

    <br />
    <br />


    <asp:Button ID="btn_Submit" runat="server" Text="Submit" onclick="btn_Submit_Click" />

    </form>
</body>
</html>
