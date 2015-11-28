<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="card.aspx.cs" Inherits="WebApplication1.BBS.card" MaintainScrollPositionOnPostback="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form id="main" runat="server">
        <div id="d_top"></div>
        <div id="left" style="float: left; width: 20%; padding-left: 5%">
            <h2>讨论小组</h2>
            <asp:BulletedList ID="bl_subject" runat="server" DataTextField="sName" DataValueField="id" DisplayMode="LinkButton" OnClick="bl_subject_Click">
            </asp:BulletedList>
        </div>
        <div id="mid" style="float: left; width: 65%; padding-left: 5%; padding-right: 5%">
            <h1>当前所在：<br />
                <asp:Label ID="lb_dis" runat="server" Text="Label"></asp:Label>
            </h1>
            <div id="sendcard">
                <h2>所有帖子:</h2>
                <asp:DataList ID="dl_card" runat="server">
                    <ItemTemplate>
                        <table border="0" cellpadding="0" cellspacing="0" align="center">
                            <tr>
                                <td style="width: 100px; height: 70px; text-align: center;" rowspan="2">
                                    <img src='<%# Eval("logo") %>' width="60" height="50" runat="server" id="Img1">
                                    <br />
                                    <%#Eval("aliasName")%>
                                </td>
                                <br />
                                <td style="height: 30px; width: 550px; text-align: left;">&nbsp;&nbsp;<asp:LinkButton ID="title" runat="server" Font-Size="X-Large" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"sendcardId") %>' OnCommand="lkbTitle_Click"><%# Eval("title") %></asp:LinkButton></td>
                            </tr>
                            <tr>
                                <td colspan="4" style="vertical-align: top; width: 450px; text-align: left; height: 40px;">&nbsp;&nbsp;<%# Eval("text")%></td>
                                <td style="width: 150px; height: 20px;">&nbsp;&nbsp;<%# Eval("date", "{0:M月d日 h点m分}")%></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList><br />
                <br />
                共<asp:Label ID="lblMesTotal" runat="server" Style="position: relative" Text="Label"></asp:Label>条帖子&nbsp;
                    第<asp:Label ID="lblPageCur" runat="server" Style="position: relative" Text="Label"></asp:Label>页&nbsp;
                    共<asp:Label ID="lblPageTotal" runat="server" Style="position: relative" Text="Label"></asp:Label>页&nbsp;
                    <asp:Button ID="Button3" runat="server" class="btn btn-primary btn-sm" Text="首页" OnClick="Button3_Click" />
                <asp:Button ID="Button1" runat="server" class="btn btn-primary btn-sm" Text="上一页" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" class="btn btn-primary btn-sm" Text="下一页" OnClick="Button2_Click" />
                <asp:Button ID="Button4" runat="server" class="btn btn-primary btn-sm" Text="尾页" OnClick="Button4_Click" />
                <br />
                <br />
                <br />
                <div>
                    标题：
                    <br />
                    <asp:TextBox ID="TB_title" runat="server"></asp:TextBox>
                    <br />
                    正文：
                    <br />
                        <asp:TextBox ID="FreeTextBox1" runat="server" Height="113px" TextMode="MultiLine"
                            Width="600px" CssClass="ckeditor"></asp:TextBox>
                        <br />
                        <asp:Button ID="btnOK" runat="server" class="btn btn-primary btn-sm" OnClick="btnOK_Click" Text="发帖" />
                        &nbsp;<asp:Button ID="cancle" runat="server" OnClick="cancle_Click"
                             class="btn btn-primary btn-sm" Text="取消" />
                </div>
                <br />
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
</asp:Content>
