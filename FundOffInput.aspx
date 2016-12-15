<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="FundOffInput.aspx.cs" Inherits="CBHProject.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    
         
        <asp:Label ID="Label4" runat="server" Font-Size="X-Large" Text="Fund Offering"></asp:Label><br />
    
    
        
         
        <asp:Label ID="Label1" runat="server" Text="Project IRR"></asp:Label><br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label2" runat="server" Text="Project WDP"></asp:Label><br />

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label3" runat="server" Text="Project IRR (Leveraged)"></asp:Label><br />

        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        
         
    
        
        <asp:Label ID="Label5" runat="server" Text="Project WDP (Leveraged)"></asp:Label><br />
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label6" runat="server" Text="Equity Rqd"></asp:Label><br />

        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label7" runat="server" Text="Pref Rate"></asp:Label><br />

        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
        
         
        <asp:Label ID="Label8" runat="server" Text="Hurdle Rate"></asp:Label><br />
<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />

    
        
        <asp:Label ID="Label9" runat="server" Text="Split to Hurdle"></asp:Label><br />

        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label10" runat="server" Text="Split after Hurdle"></asp:Label><br />

        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br />
        
         
        <asp:Label ID="Label11" runat="server" Text="Participation (INCA)"></asp:Label><br />
<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox><br />

    
        <asp:Label ID="Label12" runat="server" Text="Investor IRR (forecast)"></asp:Label><br />

        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label13" runat="server" Text="Equity Comments"></asp:Label><br />

        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox><br />
        
         
        <asp:Label ID="Label14" runat="server" Text="Loan to Cost (%)"></asp:Label><br />
<asp:TextBox ID="TextBox13" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label15" runat="server" Text="Debt"></asp:Label><br />

        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox><br />

    
        
        <asp:Label ID="Label16" runat="server" Text="Interest"></asp:Label><br />

        <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox><br />
        
         
        <asp:Label ID="Label17" runat="server" Text="Loan Fee"></asp:Label><br />
<asp:TextBox ID="TextBox16" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label18" runat="server" Text="Appraisal"></asp:Label><br />

        <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label19" runat="server" Text="Closing"></asp:Label><br />

        <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox><br />
        
         
    
        <asp:Label ID="Label20" runat="server" Text="Interest Reserve"></asp:Label><br />
<asp:TextBox ID="TextBox19" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label21" runat="server" Text="Release Price"></asp:Label><br />

        <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label22" runat="server" Text="Total Budgeted Interest"></asp:Label><br />

        <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox><br />
        
         
        <asp:Label ID="Label23" runat="server" Text="Interest To Date"></asp:Label><br />
<asp:TextBox ID="TextBox22" runat="server"></asp:TextBox><br />

        
    

        <asp:Label ID="Label24" runat="server" Text="Est Balance"></asp:Label><br />

        <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label25" runat="server" Text="Current Balance"></asp:Label><br />

        <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox><br />
        
         
        <asp:Label ID="Label26" runat="server" Text="Debt Comments"></asp:Label><br />
<asp:TextBox ID="TextBox25" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label27" runat="server" Text="Underwriting Fee"></asp:Label><br />

        <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox><br />

        
    

        <asp:Label ID="Label28" runat="server" Text="Management Fee (INCA)"></asp:Label><br />

        <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox><br />
        
         
        <asp:Label ID="Label29" runat="server" Text="Management Fee Collected"></asp:Label><br />
<asp:TextBox ID="TextBox28" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label30" runat="server" Text="Cash Flow (forecast)"></asp:Label><br />

        <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox><br />

    
        <asp:Label ID="Label31" runat="server" Text="Cash Flow (actual)"></asp:Label><br />

        <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox><br />
        
         
        <asp:Label ID="Label32" runat="server" Text="Base Economics Comments"></asp:Label><br />
<asp:TextBox ID="TextBox31" runat="server"></asp:TextBox><br />

   <asp:Button ID="Button1" runat="server" Text="Submit" />     

</asp:Content>
