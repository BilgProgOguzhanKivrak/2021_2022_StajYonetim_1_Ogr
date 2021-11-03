<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ControlLogin.ascx.cs" Inherits="StayYonetimProg.test.ControlLogin" %>
<table>
<tr>
    <td>
        İsim 
    </td>
    <td>

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    </td>
</tr>
<tr>
    <td>
        Soyisim
    </td>
    <td>

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

    </td>
</tr>
    <tr>
    <td colspan="2">


        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />


    </td>
</tr>
</table>