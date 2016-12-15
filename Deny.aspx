<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Deny.aspx.cs" Inherits="CBHProject.Deny" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        Access Denied. <br /> 
        You do not have the appropriate privileges to view this page. <br /><br />
        <a href="Default.aspx">Back to Home</a>
    </div>
</asp:Content>
