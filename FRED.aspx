<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="FRED.aspx.cs" Inherits="CBHProject.FRED" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <div class="hero-unit">
        <h1>FRED</h1>
        <p>update FRED database</p>
      </div>
      <asp:Panel ID="FREDPanel" DefaultButton="Button1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Update" onclick="Button1_Click" /><br />
      </asp:Panel>
    <asp:TextBox ID="TextBox1" Textmode="MultiLine" runat="server" Height="207px" 
          Width="264px" ReadOnly="True"></asp:TextBox>
</asp:Content>
