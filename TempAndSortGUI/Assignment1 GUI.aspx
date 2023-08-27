<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment1 GUI.aspx.cs" Inherits="TempAndSort_consumer.Assignment1_GUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Test Site to consume service made in browser</div>
        <p>
            Enter Fahrenheit temperature to convert to celcius: </p>
        <p>
            <asp:TextBox ID="f2cBox" runat="server"></asp:TextBox>
            <asp:Button ID="f2cButton" runat="server" OnClick="f2cButton_Click" Text="Enter" />
        </p>
        Enter Celcius Temperature to convert to Fahrenheit:<p>
            <asp:TextBox ID="c2fBox" runat="server"></asp:TextBox>
            <asp:Button ID="c2fButton" runat="server" OnClick="c2fButton_Click" Text="Enter" />
        </p>
        Enter String of numbers (separated by commas) to sort:<p>
            <asp:TextBox ID="stringBox" runat="server"></asp:TextBox>
            <asp:Button ID="stringButton" runat="server" OnClick="stringButton_Click" Text="Enter" />
        </p>
        <asp:Label ID="outputLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
