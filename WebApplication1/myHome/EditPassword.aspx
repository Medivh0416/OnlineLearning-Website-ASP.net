<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPassword.aspx.cs" Inherits="WebApplication1.EditPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <script src="~/js/sha1.js" type="text/javascript"></script>
    <script type="text/javascript">
        function setpwd() {
            var pwd = document.getElementById("ContentPlaceHolderMain_oldPsw");
            if (pwd.value.length != 40 && pwd.value.length != 0)
                pwd.value = hex_sha1(pwd.value);
        }
        function setpwd1() {
            var pwd = document.getElementById("ContentPlaceHolderMain_newPsw");
            if (pwd.value.length != 40 && pwd.value.length != 0)
                pwd.value = hex_sha1(pwd.value);
        }
    </script>
    <title></title>
    <link type="text/css" href="~/css/bootstrap.min.css" rel="stylesheet" />
    <link type="text/css" href="~/css/sticky-footer-navbar.css" rel="stylesheet">
    <link type="text/css" href="~/css/global.css" rel="stylesheet" />
    <style type="text/css">
        body {
            padding:0;
            background-image:none;
            background-color:transparent;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div style="padding-top:50px">
    <label>请输入原密码：</label><asp:TextBox ID="oldPsw" runat="server" TextMode="Password"></asp:TextBox>
        <br /><br />
    <label>请输入新密码：</label><asp:TextBox ID="newPsw" runat="server" TextMode="Password"></asp:TextBox>
        <br /><br />
    <label>请重复新密码：</label><asp:TextBox ID="rePsw" runat="server" TextMode="Password"></asp:TextBox>
        <br /><br />
        <asp:Button ID="submit" runat="server" Text="确认" OnClick="submit_Click" OnClientClick="setpwd()"/>
        <asp:Button ID="Button1" runat="server" Text="提交" OnClientClick="setpwd1()"/>
    </div>
    </form>
</body>
</html>
