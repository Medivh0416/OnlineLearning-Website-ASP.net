<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="WebApplication1.signUp" %>

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
            var pwd1 = document.getElementById("ContentPlaceHolderMain_rePassword");
            if (pwd1.value.length != 40 && pwd1.value.length != 0) {
                pwd1.value = hex_sha1(pwd1.value);
            }
        }
    </script>
    <style type="text/css">
        #form1 {
            height: 745px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form id="form1" runat="server">
        <div id="_left" style="float: left; width: 20%; height: 500px; padding-left: 10%">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" CssClass="panel-body">
                &nbsp;我们为您提供 
            <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1、边听边练——个性化听课
顶级名校名师网络视频授课，还原传统真实课堂，融电子板书、师生互动为一体。 
            <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2、用个性化智能错题本复习
“智能错题本”是系统针对学生答题情况自动生成的错题记录，同时也可收录课中经典题目。<br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
3、练习错题同类题——个性化巩固
顶级名校名师网络视频授课，还原传统真实课堂，融电子板书、师生互动为一体。<br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
4、网络答疑——解决个性化问题
课堂中不懂的问题可以随时到课堂内提问，答疑老师会尽快解答。
            </asp:Panel>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <div id="_right" style="float: left; width: 60%; padding-left: 10%">
            <asp:Panel ID="Panel1" runat="server" Height="28px">
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" AssociatedControlID="Panel1" Text="用户名：" Height="28px" Width="68px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="name" runat="server" CssClass="input-group-sm" AutoPostBack="True" OnTextChanged="name_TextChanged" Wrap="False" Height="28px" Width="280px"></asp:TextBox>
                <asp:Label ID="Label9" runat="server" AssociatedControlID="Panel1" ForeColor="#999966" Visible="False">用户名已被使用</asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" AssociatedControlID="Panel1" Text="密 码 ：" Height="28px" Width="68px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="password" runat="server" CssClass="input-group-sm" type="password" Height="28px" Width="280px"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:Label ID="Label10" runat="server" AssociatedControlID="Panel1" Text="确认密码：" Height="28px" Width="88px"></asp:Label>
                &nbsp;<asp:TextBox ID="rePassword" runat="server" CausesValidation="True" CssClass="input-group-sm" type="password" Height="28px" Width="280px"></asp:TextBox><asp:CompareValidator ID="CompareValidator1" runat="server"
                    ErrorMessage="密码前后输入，不一致！" ControlToCompare="password"
                    ControlToValidate="rePassword"></asp:CompareValidator>
                <br />
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" AssociatedControlID="Panel1" Text="性 别 ：" Height="28px" Width="68px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RDMale" runat="server" GroupName="Gender" Text="  男  " Height="28px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RDFemale" runat="server" GroupName="Gender" Text="  女    " Height="28px" Width="43px" />
                <br />
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" AssociatedControlID="Panel1" Text="居住地：" Height="28px" Width="68px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DDLprovince" runat="server" AutoPostBack="True" DataTextField="province" DataValueField="id" Height="28px" OnSelectedIndexChanged="DDLprovince_SelectedIndexChanged" Style="margin-left: 0px" Width="120px">
        </asp:DropDownList>
                <asp:DropDownList ID="DDLcity" runat="server" DataTextField="city" DataValueField="id" Height="28px" Style="margin-left: 9px" Width="120px">
                </asp:DropDownList>
                <br />
                <br />
                <br />
                <asp:Label ID="Label8" runat="server" AssociatedControlID="Panel1" Text="学 校 ：" Height="28px" Width="68px"></asp:Label>
                &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DDLschool" runat="server" DataTextField="school" DataValueField="id" Height="28px" Width="240px">
        </asp:DropDownList>
                <br />
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" AssociatedControlID="Panel1" Text="年 级 ：" Height="28px" Width="68px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DDLgrade" runat="server" DataTextField="grade" DataValueField="id" Height="28px" Width="240px">
        </asp:DropDownList>
                <br />
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" AssociatedControlID="Panel1" Text="昵 称 ：" Height="28px" Width="68px"></asp:Label>
                &nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="aliasName" runat="server" CssClass="ipt" Height="28px" Width="280px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ErrorMessage="昵称不能为空！" ControlToValidate="aliasName"></asp:RequiredFieldValidator>
                <br />
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" AssociatedControlID="Panel1" Text="邮 箱 ：" Height="28px" Width="68px"></asp:Label>
                &nbsp;&nbsp; &nbsp; &nbsp;<asp:TextBox ID="email" runat="server" CssClass="ipt" TextMode="Email" Height="28px" Width="280px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                    ErrorMessage="邮箱格式不符！" ControlToValidate="email"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <br />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server"
                    HeaderText="验证" />
                <br />
                <br />
                <br />
                <asp:Button ID="submit" runat="server" Enabled="False"
                    OnClick="submit_Click" OnClientClick="setpwd()" class="btn btn-primary btn-sm" Text="提交注册" />
                <br />
                <br />
            </asp:Panel>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</asp:Content>
