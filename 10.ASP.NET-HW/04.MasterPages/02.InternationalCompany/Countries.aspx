<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Countries.aspx.cs" Inherits="InternationalCompany.Countries" %>
<asp:Content ID="ContentHeader" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="ContentMain" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
   <h1>Our offices all over the world</h1>
    <p>Select the nearest office</p>
    <div id="mainPageContent">
        <asp:HyperLink runat="server" NavigateUrl="~/Bulgaria/BulgariaHome.aspx" 
            Text="Bulgaria" CssClass="country"/>
        <asp:HyperLink runat="server" NavigateUrl="~/Greece/Home.aspx"
             Text="Greece" CssClass="country"/>
        <asp:HyperLink runat="server" NavigateUrl="~/Romania/Home.aspx"
            Text="Romania" CssClass="country"/>
    </div>

</asp:Content>
