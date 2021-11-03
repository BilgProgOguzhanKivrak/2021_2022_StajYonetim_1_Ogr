<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebTest2.aspx.cs" Inherits="StayYonetimProg.test.WebTest2" %>

<%@ Register src="ControlLogin.ascx" tagname="ControlLogin" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        &nbsp;<uc1:ControlLogin ID="ControlLogin1" runat="server" />
                    </td>
                </tr>
            </table>
            <br />

            <table>
                <tr>
                    <td>
                        Şehirler
                    </td>
                    <td>
                        <asp:DropDownList ID="ddListSehirler" AutoPostBack ="true" runat="server" OnSelectedIndexChanged="ddListSehirler_SelectedIndexChanged">
                           </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        İlçe
                    </td>
                    <td>

                        <asp:DropDownList ID="ddListIlceler" runat="server">
                        </asp:DropDownList>

                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
