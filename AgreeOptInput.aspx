<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="AgreeOptInput.aspx.cs" Inherits="CBHProject.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<asp:Label ID="Label4" runat="server" Font-Size="X-Large" 
            Text="Agreement - Option"></asp:Label><br />
        

        <asp:Label ID="Label12" runat="server" Text="Fund#"></asp:Label><br />
<asp:TextBox ID="TextBox11" runat="server"></asp:TextBox><br />
        
        <asp:Label ID="Label1" runat="server" Text="Optionor"></asp:Label><br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label2" runat="server" Text="Optionee"></asp:Label><br />

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label3" runat="server" Text="Insurance Required"></asp:Label><br />

        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        
        
        <asp:Label ID="Label5" runat="server" Text="Roll Price"></asp:Label><br />
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label6" runat="server" Text="Option Deposit"></asp:Label><br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label7" runat="server" Text="Phases"></asp:Label><br />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />

         <asp:Label ID="Label8" runat="server" Text="Order Premium"></asp:Label><br />
<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label9" runat="server" Text="Other Premium"></asp:Label><br />

        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label10" runat="server" Text="Option Comments"></asp:Label><br />

        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label13" runat="server" Text="Agreement Purchase Fund#"></asp:Label><br />
<asp:TextBox ID="TextBox12" runat="server"></asp:TextBox><br />
        
        <asp:Label ID="Label14" runat="server" Text="Option Budget Fund#"></asp:Label><br />
<asp:TextBox ID="TextBox13" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label11" runat="server" Text="Option Budget Period"></asp:Label><br />
<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox><br />

<asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />

</asp:Content>
