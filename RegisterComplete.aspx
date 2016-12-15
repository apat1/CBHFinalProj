<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegisterComplete.aspx.cs" Inherits="CBHProject.RegisterComplete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p align="center" style="font-size: xx-large; font-weight: bold;">
    Registration Complete</p>
<p align="center" style="font-size: medium; font-weight: normal;">
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Login.aspx">Log In Now</asp:HyperLink>
</p>
<p align="center">
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Click here to return to Home page.</asp:HyperLink>
</p>
</asp:Content>
