<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="WebApplication1.admin.admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form runat="server">
        <h1>你好，管理员</h1>
        <div style="margin: 0 auto;">
            <div id="d_left" style="float: left; padding-left: 50px">
                <ul>
                    <li>
                        <asp:Button ID="edit" runat="server" class="btn btn-primary btn-sm" Style="padding: 1px" Text="查看用户信息" OnClick="edit_Click" />
                    </li>
                    <li>
                        <a href="CMS.aspx" class="btn btn-primary btn-sm" style="padding: 1px">上传新闻</a>
                    </li>
                    <li>
                        <a href="input.aspx" class="btn btn-primary btn-sm" style="padding: 1px">志愿数据导入</a>
                    </li>
                    <li>
                        <a href="query.aspx" class="btn btn-primary btn-sm" style="padding: 1px">志愿查询</a>
                    </li>
                    <li>
                        <a href="upload.aspx" class="btn btn-primary btn-sm" style="padding: 1px">上传题目</a>
                    </li>
                </ul>
            </div>
            <div id="d_right" style="float: left; padding-left: 50px;" runat="server">
                <div id="d_lv_contack" runat="server">
                    <asp:ListView ID="lv_contack" runat="server">
                        <ItemTemplate>
                            <div style="padding: 5px">
                                <div style="float: left; width: 500px">
                                    <h3>留言时间:<%#Eval("date")%></h3>
                                    <span>姓名：:<%#Eval("conName")%></span>&nbsp;&nbsp;&nbsp;&nbsp;
                        <span>电话：<%#Eval("tel")%></span>&nbsp;&nbsp;&nbsp;&nbsp;<br />
                                    <span>留言内容：<%#Eval("text")%></span><br /><span>用户名:<%#Eval("name")%></span><br /></div>
                                <div style="clear: both"></div>
                            </div>

                        </ItemTemplate>
                    </asp:ListView>
                    共<asp:Label ID="lblMesTotal" runat="server" Style="position: relative" Text="Label"></asp:Label>条记录&nbsp;
                    第<asp:Label ID="lblPageCur" runat="server" Style="position: relative" Text="Label"></asp:Label>页&nbsp;
                    共<asp:Label ID="lblPageTotal" runat="server" Style="position: relative" Text="Label"></asp:Label>页&nbsp;
                    <asp:Button ID="Button3" runat="server" class="btn btn-primary btn-sm" Text="首页" OnClick="Button3_Click" />
                    <asp:Button ID="Button1" runat="server" class="btn btn-primary btn-sm" Text="上一页" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" class="btn btn-primary btn-sm" Text="下一页" OnClick="Button2_Click" />
                    <asp:Button ID="Button4" runat="server" class="btn btn-primary btn-sm" Text="尾页" OnClick="Button4_Click" />
                    <br />
                    <br />
                    <br />
                </div>
                <div id="d_lv_user" runat="server">
                    <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_search" runat="server" Text="查找用户" OnClick="btn_search_Click" />
                    <asp:ListView ID="lv_user" runat="server" ItemPlaceholderID="itemholder">
                        <LayoutTemplate>
                            <div id="itemholder" runat="server"></div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div style="padding: 5px">
                                <div style="float: left; width: 80px">
                                    <asp:Button ID="bt_edit" runat="server" class="btn btn-primary btn-sm" Text="编辑" /><br />
                                    <asp:Button ID="bt_delete" runat="server" class="btn btn-primary btn-sm" Text="删除" CommandName="delete" OnClientClick="return confirm('确定删除么？')" />
                                </div>
                                <div style="float: left; width: 500px">
                                    <h3>用户名:<%#Eval("name")%></h3>
                                    <br />
                                    <span>昵称:<%#Eval("aliasName")%></span>&nbsp;&nbsp;&nbsp;&nbsp;
                        <span>金币:<%#Eval("coin")%></span>&nbsp;&nbsp;&nbsp;&nbsp;
                        <span>性别:<%#Eval("gender")%></span><br /><span>邮箱:<%#Eval("email")%></span>&nbsp;&nbsp;&nbsp;&nbsp;
                        <span>做题时间:<%#Eval("workTime")%></span><br /></div>
                                <div style="clear: both"></div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <br />

            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
</asp:Content>
