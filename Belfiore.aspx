<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Belfiore.aspx.cs" Inherits="CBHProject.Belfiore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <div class="hero-unit">
        <h1>Belfiore</h1>
        <p>update Belfiore database</p>
      </div>
      <div>
        <asp:Panel ID="BelfiorePanel" DefaultButton="Button1" runat="server">
            <asp:FileUpload ID="FileUpload1" name="FileUpload1" runat="server" 
                Height="22px" /> 
            <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" 
                Height="25px" /><br />
        </asp:Panel>
      </div>
      <div>
        <asp:RegularExpressionValidator ID="regexValidator" runat="server"
            ControlToValidate="FileUpload1"
            ErrorMessage="Only CSV files are allowed" 
            ValidationExpression="(.*\.([cC][sS][vV])$)">
        </asp:RegularExpressionValidator> 
      </div>
      <asp:TextBox ID="BelTextBox" Textmode="MultiLine" runat="server" Height="207px" 
        Width="264px" ReadOnly="True"></asp:TextBox>
</asp:Content>
