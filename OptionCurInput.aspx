<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="OptionCurInput.aspx.cs" Inherits="CBHProject.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    
         
        <asp:Label ID="Label4" runat="server" Font-Size="X-Large" 
            Text="Option Current"></asp:Label><br />
    
    
       
        <asp:Label ID="Label6" runat="server" Text="Fund#"></asp:Label><br />
<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />

         <asp:Label ID="Label1" runat="server" Text="Current Roll Price"></asp:Label><br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label2" runat="server" Text="Other Lot Revenue"></asp:Label><br />

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label3" runat="server" Text="Cur Option Deposit"></asp:Label><br />

        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        
    
        <asp:Label ID="Label5" runat="server" Text="Management Fee"></asp:Label><br />
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        

      <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />   
        

</asp:Content>
