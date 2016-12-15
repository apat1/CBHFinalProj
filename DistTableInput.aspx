<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="DistTableInput.aspx.cs" Inherits="CBHProject.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    
        
        <asp:Label ID="Label4" runat="server" Font-Size="X-Large" 
            Text="Distribution Table"></asp:Label><br />
    
    <asp:Label ID="Label6" runat="server" Text="Fund#"></asp:Label><br />
<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />

<asp:Label ID="Label7" runat="server" Text="Date (Budget)"></asp:Label><br />
<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
        
         <asp:Label ID="Label1" runat="server" Text="Distribution #"></asp:Label><br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label2" runat="server" Text="Amount Budget"></asp:Label><br />

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label3" runat="server" Text="Date (Actual)"></asp:Label><br />

        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        
    
        <asp:Label ID="Label5" runat="server" Text="Amount (Actual)"></asp:Label><br />
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />

        

        <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />

</asp:Content>
