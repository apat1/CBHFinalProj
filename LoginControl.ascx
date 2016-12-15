<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="CBHProject.LoginControl" %>
    <link type="text/css" rel="stylesheet" href="css/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="css/style.css" />
    <script src="js/jquery-1.9.1.min.js" type="text/javascript"></script>
    <link href="css/bootstrap-responsive.min.css" rel="stylesheet" type="text/css" />
<div>
    <div class="hero-unit">
        <h1>Login</h1>
      </div>
    <table border="0" cellpadding="2" cellspacing="2">
        <tr>
            <td>Username:&nbsp;</td>
            <td><asp:TextBox runat="server" id="textUser" style="width:200px" /></td>
        </tr>
        <tr>
            <td>Password:&nbsp;</td>
            <td><asp:TextBox runat="server" id="textPass" TextMode="Password" style="width:200px" /></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Panel ID="LoginPanel" DefaultButton="btnLogin" runat="server">
                    <asp:Button id="btnLogin" runat="server" Text="Log In" 
                    onclick="btnLogin_Click" />
                    <asp:Button ID="btnReg" runat="server" onclick="btnReg_Click" Text="Register" />
                </asp:Panel> 
            </td>
        </tr>
    </table>
    <br />
    <asp:Label id="lblResult" runat="server" />
</div>