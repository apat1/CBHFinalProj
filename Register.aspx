<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CBHProject.Register" %>
<%@ Register TagPrefix="register" TagName="registerForm" Src="RegisterControl.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <register:registerForm ID="regForm" runat="server" />
</asp:Content>
