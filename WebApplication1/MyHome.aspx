<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="MyHome.aspx.cs" Inherits="WebApplication1.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <style type="text/css">
        body {
            min-width: 751px;
        }

        #menu li {
            padding: 10px 0;
            list-style: none;
        }

        #ContentPlaceHolderMain_home li {
            padding-bottom: 10px;
            list-style: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form id="form" runat="server" style="height: 468px">
        <div>
            <div id="_left" style="float: left; width: 15%; padding-left: 5%; padding-top: 20px;">
                <div id="menu">
                    <a id="Myhome" href="MyHome.aspx">个人中心</a>
                    <br />
                    <asp:BulletedList ID="bltMenu" runat="server" CssClass="list-group-item-heading" DisplayMode="LinkButton" OnClick="bltMenu_Click">
                        <asp:ListItem Value="~/myHome/myTask.aspx">开始做题</asp:ListItem>
                        <asp:ListItem Value="~/myHome/buy.aspx">购买题目</asp:ListItem>
                        <asp:ListItem Value="~/myHome/perView.aspx">查看个人资料</asp:ListItem>
                        <asp:ListItem Value="~/myHome/perEdit.aspx">编辑个人资料</asp:ListItem>
                        <%--                <asp:ListItem Value="~/myHome/upPic.aspx">上传头像</asp:ListItem>
                <asp:ListItem Value="~/myHome/EditPassword.aspx">修改密码</asp:ListItem>--%>
                        <asp:ListItem Value="~/myHome/charge.aspx">学币充值</asp:ListItem>
                        <asp:ListItem Value="#">我的心得</asp:ListItem>
                        <asp:ListItem Value="~/myHome/contackUs.aspx">联系我们</asp:ListItem>
                    </asp:BulletedList>
                </div>

            </div>
            <div id="_right" style="float: left; width: 70%; height: auto;padding-left: 2%;">
                <iframe runat="server" id="iframe" style="float: inherit; width: 100%; min-height: 534px; border: 0;"></iframe>
                <div id="home" runat="server">
                    <ul>
                        <li>
                            <asp:Image ID="logo" runat="server" Height="200px" Width="200px" />
                        </li>
                        <li>
                            <asp:Label ID="l_name" runat="server"></asp:Label>
                            <br />
                            粉丝：<asp:Label ID="l_fans" runat="server"></asp:Label>
                            关注：<asp:Label ID="l_follow" runat="server">411</asp:Label>
                        </li>
                        <li>我是<asp:Label ID="l_gender" runat="server"></asp:Label>生
                            今年上<asp:Label ID="l_grade" runat="server"></asp:Label>
                            位于<asp:Label ID="l_city" runat="server"></asp:Label>
                            <br />
                        </li>
                        <li>个性签名：<asp:Label ID="l_sign" runat="server"></asp:Label></li>
                        <li>解题总数：<asp:Label ID="l_count" runat="server"></asp:Label>
                            积分：<asp:Label ID="l_score" runat="server"></asp:Label>
                            能力值：<asp:Label ID="l_identity" runat="server"></asp:Label>
                        </li>
                        <li>在线时间：<asp:Label ID="l_time" runat="server"></asp:Label><br />
                            闯关数:<asp:Label ID="l_level" runat="server"></asp:Label><br />
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
</asp:Content>
