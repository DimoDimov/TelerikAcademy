<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_01.RandomNumbersHTML.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="minNumber">Input min number</label>
            <input type="text" id="minNumber" runat="server" value="min Number" />

            <label for="maxNumber">Input max number</label>
            <input type="text" id="maxNumber" runat="server" value="max Number" />
            <br />
            <label for="output">Output</label>
            <input type="text" id="output" runat="server"  />
            <br />
            <button onserverclick="onButtonClick" runat="server" id="Button">GenerateNumber</button>
           
        </div>
    </form>
    
</body>
</html>
