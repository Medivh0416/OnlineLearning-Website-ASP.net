<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="perEdit.aspx.cs" Inherits="WebApplication1.perEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link type="text/css" href="~/css/bootstrap.min.css" rel="stylesheet" />
    <link type="text/css" href="~/css/sticky-footer-navbar.css" rel="stylesheet" />
    <link type="text/css" href="~/css/global.css" rel="stylesheet" />
    <script src="../js/sha1.js" type="text/javascript"></script>
    <script type="text/javascript">
        function setpwd() {
            var pwd = document.getElementById("oldPsw");
            if (pwd.value.length != 40 && pwd.value.length != 0)
                pwd.value = hex_sha1(pwd.value);
            var pwd1 = document.getElementById("newPsw");
            if (pwd1.value.length != 40 && pwd1.value.length != 0)
                pwd1.value = hex_sha1(pwd1.value);
            var pwd2 = document.getElementById("rePsw");
            if (pwd2.value.length != 40 && pwd2.value.length != 0)
                pwd2.value = hex_sha1(pwd2.value);
        }
    </script>
    <style type="text/css">
        body {
            padding: 0;
            background-image: none;
            background-color: transparent;
        }
    </style>
    <style type="text/css">
        .pic_text {
            color: Red;
        }

        .pic_label {
            color: Gray;
            margin-top: 5px;
            margin-bottom: 5px;
        }

        .pic_image {
            margin: 5px;
        }

        div {
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;
            <asp:Button ID="btn_edit" runat="server" Text="修改个人资料" OnClick="btn_edit_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btn_pic" runat="server" Text="修改头像" OnClick="btn_pic_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btn_pass" runat="server" Text="修改密码" OnClick="btn_pass_Click" />
            <asp:MultiView ID="per_view" runat="server" ActiveViewIndex="0">
                <asp:View ID="v_input" runat="server">
                    <div id="listview" style="padding-left: 30px">
                        <br />
                        <br />
                        <label>昵 称 ：</label><asp:TextBox ID="aliasName" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <label>性 别 ：</label>
                        <asp:RadioButton ID="RDMale" runat="server" GroupName="Gender" Text="  男  " />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RDFemale" runat="server" GroupName="Gender" Text="  女" />
                        <br />
                        <br />
                        <label>城 市 ：</label><asp:DropDownList ID="DDLprovince" runat="server" AutoPostBack="True" DataTextField="province" DataValueField="id" Height="28px" OnSelectedIndexChanged="DDLprovince_SelectedIndexChanged" Style="margin-left: 0px" Width="120px"></asp:DropDownList>
                        <asp:DropDownList ID="DDLcity" runat="server" DataTextField="city" DataValueField="id" Height="28px" Style="margin-left: 9px" Width="120px"></asp:DropDownList>
                        <br />
                        <br />
                        <label>学 校 ：</label><asp:DropDownList ID="DDLschool" runat="server" DataTextField="school" DataValueField="id" Height="28px" Width="240px">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <label>年 纪 ：</label><asp:DropDownList ID="DDLgrade" runat="server" DataTextField="grade" DataValueField="id" Height="28px" Width="240px">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:Button ID="submit" runat="server" Text=" 提 交 " OnClick="submit_Click" CssClass="btn" />
                    </div>
                </asp:View>
                <asp:View ID="upPic" runat="server">
                    <div style="padding-left: 30px">
                        <h3>您上传的头像会自动生成三种尺寸，请注意小尺寸的头像是否清晰</h3>
                        <div class="pic_image" style="float: left; padding-left: 5px; height: 200px; width: 200px">
                            <asp:Image ID="pic" runat="server" Height="200px" Width="200px" />
                        </div>
                        <div style="float: left; padding-left: 10px; height: 120px; width: 120px">
                            <asp:Image ID="pic_mid" runat="server" Height="120px" Width="120px" />
                        </div>
                        <div style="float: left; padding-left: 10px; height: 80px; width: 80px">
                            <asp:Image ID="pic_s" runat="server" Height="80px" Width="80px" />
                        </div>
                    </div>
                    <div style="clear: both"></div>
                    <div>
                        <y style="color: purple; border: medium; padding: 5px">这个头像我不喜欢，我要换换</y>
                        <br />
                        <y style="color: #808080; border: medium; padding: 5px">从你的电脑中选择你喜欢的图片: </y>
                        <div style="padding-top: 5px">
                            <asp:FileUpload ID="pic_upload" runat="server" /><asp:Label ID="lbl_pic" runat="server" class="pic_text"></asp:Label>
                        </div>
                        <div class="pic_label">上传图片格式为.jpg, .gif, .bmp,.png,图片大小不得超过1M</div>
                        <div>
                            <asp:Button ID="btn_upload" runat="server" Text="上传" OnClick="btn_upload_Click" Style="height: 21px" />
                        </div>
                    </div>
                </asp:View>
                <asp:View ID="passWord" runat="server">
                    <div style="padding-top: 50px">
                        <label>请输入原密码：</label><asp:TextBox ID="oldPsw" runat="server" TextMode="Password"></asp:TextBox>
                        <br />
                        <br />
                        <label>请输入新密码：</label><asp:TextBox ID="newPsw" runat="server" TextMode="Password"></asp:TextBox>
                        <br />
                        <br />
                        <label>请重复新密码：</label>
                        <asp:TextBox ID="rePsw" runat="server" CausesValidation="True" type="password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server"
                    ErrorMessage="密码前后输入，不一致！" ControlToCompare="newPsw"
                    ControlToValidate="rePsw"></asp:CompareValidator>
                        <br /><br />
                        <asp:Button ID="btn_confirm" runat="server" Text="确认" OnClick="btn_confirm_Click" OnClientClick="setpwd()" />
                        <%--<asp:Button ID="btn_submit" runat="server" Text="提交" OnClientClick="setpwd1()" OnClick="btn_submit_Click1" />--%>
                    </div>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
