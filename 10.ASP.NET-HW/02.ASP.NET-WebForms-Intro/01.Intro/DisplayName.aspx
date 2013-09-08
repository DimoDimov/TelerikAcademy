<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="DisplayName.aspx.cs" 
    Inherits="_01.Intro.DisplayName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="displayName" runat="server">
        
        <asp:TextBox ID="TextBoxName" runat="server" ></asp:TextBox>
        <asp:Button ID="ButtonDisplayName" runat="server" Text="Button" OnClick="ButtonDisplayName_Click" />

        
        <asp:Label ID="LabelDisplayGreeting" runat="server"></asp:Label>

    </form>
</body>
</html>
