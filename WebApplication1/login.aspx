<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true"
    CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <script src="js/jquery-1.11.0.js" type="text/javascript"></script>
    <script src="js/layer/layer.min.js" type="text/javascript"></script>
    <script src="js/sha1.js" type="text/javascript"></script>
    <script type="text/javascript">
        function setpwd() {
            var pwd = document.getElementById("ContentPlaceHolderMain_password");
            if (pwd.value.length != 40 && pwd.value.length != 0) {
                pwd.value = hex_sha1(pwd.value);
            }
        }
        $(document).ready(function () {                        //通过jQuery的方法暂时把导航条隐藏起来
            $('.footer').remove();
            $('.navbar').remove();
            $('title').html('Login');                          //修改title
            $("#placeHolder").remove();
        });
    </script>
    <link type="text/css" href="style/Style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div id="loginMain">
        <form id="formLogin" runat="server">
            <div id="divLogin">
                <div id="divLoginTitle">
                    <h3>登&nbsp;&nbsp;&nbsp;&nbsp;录</h3>
                </div>
                <div id="divLoginUserName" class="divLoginInput">
                    <label for="userName" class="lbl">
                        用户名</label>
                    <asp:TextBox ID="userName" class="ipt form-control" runat="server"></asp:TextBox>
                </div>
                <div id="divLoginPassword" class="divLoginInput">
                    <label for="password" class="lbl">
                        密&nbsp;&nbsp;&nbsp;码</label>
                    <asp:TextBox ID="password" class="ipt form-control" TextMode="Password" runat="server"></asp:TextBox>
                </div>
                <div id="divLoginVerify" class="divLoginInput">
                    <label for="password" class="lbl">
                        验证码</label>
                    <asp:TextBox ID="verifyCode" class="verifyCode form-control" runat="server"></asp:TextBox>
                    <asp:ImageButton class="ImageVerify" runat="server" ImageUrl="~/ValidNums.aspx" Style="height: 40px; width: 80px" />
                </div>
                <div id="divLoginBtn" class="divLoginInput">
                    <asp:Button class="btn btn-primary btn-block" runat="server" Text="登陆" OnClick="btnLogin_Click" OnClientClick="setpwd()" />
                </div>
                <div id="divRegisterBtn" class="divLoginInput">
                    <asp:Button ID="Button1" class="btn btn-primary btn-block" runat="server" Text="注册" OnClick="btnLogin_Click1" />
                </div>
            </div>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
</asp:Content>
