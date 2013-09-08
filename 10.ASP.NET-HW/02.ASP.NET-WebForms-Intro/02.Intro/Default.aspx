<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02.Intro._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <p>"Hello, ASP.NET" - from ASPX code</p>
    <asp:Label ID="LabelFromCodeBehind" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="LabelAssembly" runat="server" Text="Label"></asp:Label>

   

</asp:Content>
