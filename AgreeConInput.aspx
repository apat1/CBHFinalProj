<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="AgreeConInput.aspx.cs" Inherits="CBHProject.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br /><asp:Label ID="Label4" runat="server" Font-Size="X-Large" cssClass="legend" Text="Agreement - Construction"></asp:Label><br /><br />

     <asp:Label ID="Label8" runat="server" Text="Fund#"></asp:Label><br />
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label5" runat="server" Text="Owner Name"></asp:Label><br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label6" runat="server" Text="Contractor Name"></asp:Label><br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label7" runat="server" Text="Insurance Required:"></asp:Label><br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    
    <asp:Label ID="Label1" runat="server" Text="Contract Sum"></asp:Label><br />
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label2" runat="server" Text="Current Contract Sum"></asp:Label><br />
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label3" runat="server" Text="Construction Comment"></asp:Label><br />
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br /><br />

    <asp:Label ID="Label9" runat="server" Text="Due Diligence Fund#"></asp:Label><br />
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br /><br />

    <asp:Label ID="Label10" runat="server" Text="Agreement Option Fund#"></asp:Label><br />
    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br /><br />

    <asp:Label ID="Label11" runat="server" Text="INCA Documents Fund#"></asp:Label><br />
    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox><br /><br />

    <asp:Label ID="Label12" runat="server" Text="Due Diligence Fund#1"></asp:Label><br />
    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox><br /><br />

    <asp:Label ID="Label13" runat="server" Text="Due Diligence Fund#2"></asp:Label><br />
    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox><br /><br />
    
    <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
</asp:Content>
