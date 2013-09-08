<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_04.RegisterStudents.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Input First Name:"></asp:Label>
        <input id="inputFirstName" type="text" runat="server" /><br />
        <asp:Label ID="Label2" runat="server" Text="Input Last Name:"></asp:Label>
        <input id="inputLastName" type="text" runat="server" /><br />
        <asp:Label ID="Label3" runat="server" Text="Input Faculty:"></asp:Label>
        <input id="inputFacultyNumber" type="text" runat="server" /><br />
        <asp:Label ID="Label4" runat="server" Text="Input University:"></asp:Label>
        <asp:DropDownList ID="inputUniversity" runat="server">
            <asp:ListItem>Technical University</asp:ListItem>
            <asp:ListItem>UNSS</asp:ListItem>
            <asp:ListItem>Sofia University</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label runat="server" Text="Input Specialty:"></asp:Label>
        <asp:DropDownList ID="inputSpecialty" runat="server" >
            <asp:ListItem>C# developer</asp:ListItem>
            <asp:ListItem>Web Developer</asp:ListItem>
            <asp:ListItem>Guru Developer</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Input Courses:"></asp:Label>
        <asp:ListBox ID="inputCourses" runat="server" SelectionMode="Multiple">
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>JavaScript</asp:ListItem>
            <asp:ListItem>Databases</asp:ListItem>
            <asp:ListItem>WebTechnologies</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" />
    
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="First Name:"></asp:Label>
        <input id="outputFName" runat="server" type="text" /><br />
        <asp:Label ID="Label8" runat="server" Text="Last Name"></asp:Label>
        <input id="outputLName" runat="server" type="text" /><br />
        <asp:Label ID="Label9" runat="server" Text="Faculty:"></asp:Label>
        <input id="outputFaculty" runat="server" type="text" /><br />
        <asp:Label ID="Label12" runat="server" Text="Specialty:"></asp:Label>
        <input id="outputSpecialty" runat="server" type="text" /><br />
        <asp:Label ID="Label10" runat="server" Text="University"></asp:Label>
        <input id="outputUniversity" runat="server" type="text" /><br />
        <asp:Label ID="Label11" runat="server" Text="Course/Courses:"></asp:Label>
        <input id="outputCourses" runat="server" type="text" /><br />
    
    </div>
    </form>
</body>
</html>
