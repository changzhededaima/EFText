﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webtest.aspx.cs" Inherits="EFText.Webtest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        <div>
        <asp:Button ID="Button2" runat="server" Text="查询" OnClick="Button2_Click" />
            </div>
            <div>
        <asp:Button ID="Button3" runat="server" Text="删除" OnClick="Button3_Click" style="height: 21px" />
                </div>
        <div>
            <asp:Button ID="Button4" runat="server" Text="修改" OnClick="Button4_Click" />
        </div>
    </form>
    <p>
&nbsp;</p>
</body>
</html>
