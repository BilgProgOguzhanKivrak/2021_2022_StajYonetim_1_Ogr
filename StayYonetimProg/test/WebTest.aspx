<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebTest.aspx.cs" Inherits="StayYonetimProg.test.WebTest" %>

<%@ Register src="ControlLogin.ascx" tagname="ControlLogin" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="chkListDepo" runat="server" OnSelectedIndexChanged="chkListDepo_SelectedIndexChanged" AutoPostBack="true" RepeatDirection="Horizontal">
                <asp:ListItem Value="1">Kitap</asp:ListItem>
                <asp:ListItem Value="2">Poster</asp:ListItem>
                <asp:ListItem Value="3">Bilgisayar</asp:ListItem>
                <asp:ListItem Value="4">Kağıt</asp:ListItem>
                <asp:ListItem Value="5">DVD</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="lblBilgi" runat="server"></asp:Label>
            <uc1:ControlLogin ID="ControlLogin1" runat="server" />
        </div>
    </form>
</body>
</html>
