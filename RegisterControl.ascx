<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegisterControl.ascx.cs" Inherits="CBHProject.RegisterControl" %>
<div>
    <h1>New User Registration</h1>
    <table border="0" cellpadding="2" cellspacing="2">
        <tr>
                <td></td>
                <td><asp:Image ID="Image1" runat="server" style="width:200px"/></td>
        </tr>
        <tr>
            <td>Captcha:&nbsp;</td>
            <td><asp:TextBox ID="textCaptcha" runat="server" style="width:200px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Username:&nbsp;</td>
            <td><asp:TextBox runat="server" id="textUsername" style="width:200px" /></td>
        </tr>
        <tr>
            <td>Password:&nbsp;</td>
            <td><asp:TextBox runat="server" id="textPassword" TextMode="Password" style="width:200px" /></td>
        </tr>
        <tr>
            <td>Confirm Password:&nbsp;</td>
            <td><asp:TextBox runat="server" id="textConfirm" TextMode="Password" style="width:200px" /></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Panel ID="RegPanel" DefaultButton="btnRegister" runat="server">
                    <asp:Button id="btnRegister" runat="server" Text="Make Account" onclick="btnRegister_Click" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    <br />
    <asp:Label id="lblError" runat="server" />
</div>