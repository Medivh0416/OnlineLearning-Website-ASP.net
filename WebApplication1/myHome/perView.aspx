<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="perView.aspx.cs" Inherits="WebApplication1.perView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link type="text/css" href="~/css/bootstrap.min.css" rel="stylesheet" />
    <link type="text/css" href="~/css/sticky-footer-navbar.css" rel="stylesheet" />
    <link type="text/css" href="~/css/global.css" rel="stylesheet" />
    <style type="text/css">
        body {
            padding: 0;
            background-image: none;
            background-color: transparent;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="listview">
            <ul class="list-unstyled">
            <li><label>用户名 ：</label><asp:Label ID="userName" runat="server"></asp:Label>
            <br /></li>
            <li>
            <label>昵 称 ：</label><asp:Label ID="aliasName" runat="server"></asp:Label>
            <br /></li>
            <li>
            <label>性 别 ：</label><asp:Label ID="gender" runat="server"></asp:Label>
            <br /></li>
            <li>
            <label>邮 箱 ：</label><asp:Label ID="email" runat="server"></asp:Label>
            <br /></li>
            <li>
            <label>等 级 ：</label><asp:Label ID="level" runat="server"></asp:Label>
            <br /></li>
            <li>
            <label>分 数 ：</label><asp:Label ID="score" runat="server"></asp:Label>
            <br /></li>
            <li>
            <label>金 币 ：</label><asp:Label ID="coin" runat="server"></asp:Label>
            <br /></li>
            <li>
            <label>城 市 ：</label><asp:Label ID="city" runat="server"></asp:Label>
            <br /></li>
            <li>
            <label>学 校 ：</label><asp:Label ID="school" runat="server"></asp:Label>
            <br />
            </li>
            </ul>
        </div>

    </form>
</body>
</html>
