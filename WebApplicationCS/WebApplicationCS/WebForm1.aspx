<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationCS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1><strong>Nunca nem vi!!!!</strong></h1>
        <div>
            <strong><asp:Label ID="Label1" runat="server" Text="Imagens"></asp:Label></strong>
        </div>
        <p>
            <asp:FileUpload ID="FileUpload1" runat="server" Width="374px" />
            &nbsp
            <asp:Button ID="ProcessarButton" runat="server" Text="Processar" Width="145px" OnClick="ProcessarButton_Click" />
        </p>
    </form>
</body>
</html>
