<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webdemo.aspx.cs" Inherits="EFText.Webdemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" />
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 21px" Text="查询" />
    </form>
</body>
</html>
