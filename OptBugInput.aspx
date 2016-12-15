<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="OptBugInput.aspx.cs" Inherits="CBHProject.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    
        
        <asp:Label ID="Label4" runat="server" Font-Size="X-Large" Text="Option Budget"></asp:Label><br />
 

        <asp:Label ID="Label1" runat="server" Text="Date Budget"></asp:Label><br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label2" runat="server" Text="Takedown Budget"></asp:Label><br />

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label3" runat="server" Text="Revenues"></asp:Label><br />

        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        
       <asp:Label ID="Label5" runat="server" Text="Draw Schedule"></asp:Label><br />
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label6" runat="server" Text="Cumulative Draw Schedule"></asp:Label><br />

        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label7" runat="server" Text="Date Actual"></asp:Label><br />

        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
        
         <asp:Label ID="Label8" runat="server" Text="Takedown Actual"></asp:Label><br />
<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label9" runat="server" Text="Revenue Total"></asp:Label><br />

        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label10" runat="server" Text="Revenue Remaining"></asp:Label><br />

        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br />
        
        <asp:Button ID="Button1" runat="server" Text="Submit" />

</asp:Content>
