<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02.RandomGenWebServerControls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label runat="server" Text="minNumber"></asp:Label>
        <asp:TextBox ID="minNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="maxNumber"></asp:Label>
        <asp:TextBox ID="maxNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Output"></asp:Label>
        <asp:TextBox ID="output" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="GenerateNumber" runat="server" OnClick="Button1_Click" Text="GenerateRandomNum" />
    
    </div>
    </form>
</body>
</html>
