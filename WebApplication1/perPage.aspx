<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="perPage.aspx.cs" Inherits="WebApplication1.perPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <style type="text/css">
        #left {
            float: left;
            left: 1%;
            width: 35%;
        }

        #mid {
            float: left;
            width: 60%;
            margin: 5px 0 5px 0;
            position: relative;
        }

        #u_doc {
            color: #0d0033;
        }

        #badge Image {
            height: 120px;
            width: 120px;
        }

        .accordion-heading {
            background-color: #eee;
        }

        .accordion-inner {
            background-color: #fff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form runat="server">
        <div id="left" style="float: left; width: 27%; padding-left: 8%">
            <div>
                <asp:Image ID="logo" runat="server" Height="180px" Width="180px" />
            </div>
            <div>
                <ul id="u_doc">
                    <li>昵称：<asp:Label ID="l_name1" runat="server"></asp:Label></li>
                    <li>现居：<asp:Label ID="l_city" runat="server"></asp:Label></li>
                    <li>等级：<asp:Label ID="l_level" runat="server"></asp:Label>
                        <span style="padding-left: 20px">积分:<asp:Label ID="l_score" runat="server"></asp:Label></span>
                    </li>
                    <li>个人简介：<asp:Label ID="l_intro" runat="server"></asp:Label></li>
                    <li>关注：<asp:Label ID="l_follow" runat="server"></asp:Label></li>
                    <li>粉丝：<asp:Label ID="l_fans" runat="server" Text="Label"></asp:Label></li>
                </ul>
            </div>
        </div>
        <div id="mid" style="float: left; width: 60%">
            <div id="mid_belw">
                <h2 style="font-family: Microsoft YaHei, serif">
                    <asp:Label ID="l_name" runat="server"></asp:Label>
                    的主页</h2>
                <y style="padding-left: 5px">我的心情：
                <asp:Label ID="l_sign" runat="server"></asp:Label>
            </y>
                <div>
                    <a>主页 </a>
                    <a>他的徽章 </a>
                    <a>留言板 </a>
                    <a>他的帖子 </a>
                </div>
                <div id="moment">

                    

                    <div class="accordion" id="accordion2">
                        <div class="accordion-group">
                            <div class="accordion-heading">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseOne">他的动态
                                </a>
                            </div>
                            <div id="collapseOne" class="accordion-body collapse in">
                                <div class="accordion-inner">
                                    <div>
                                        <asp:ListView ID="lvRecord" runat="server">
                                            <ItemTemplate>
                                                <div style="border: thin,dashed; padding-top: 5px; font-family: 'Microsoft YaHei'">
                                                    &nbsp;&nbsp;Ta用时&nbsp;&nbsp;<%#Eval("workTime")%>&nbsp;&nbsp;秒完成&nbsp;&nbsp;<%#Eval("questionName")%><br />
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%#Eval("date")%>
                                                </div>
                                            </ItemTemplate>
                                        </asp:ListView>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="accordion-group">
                            <div class="accordion-heading">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseTwo">在学的课程
                                </a>
                            </div>
                            <div id="collapseTwo" class="accordion-body collapse">
                                <div class="accordion-inner">
                                    <div id="d_study" style="font-family: 'FangSong_GB2312 '">
                                        <asp:ListView ID="lv_study" runat="server">
                                            <ItemTemplate>
                                                <table border="0" cellpadding="0" cellspacing="0" align="center">
                                                    <tr>
                                                        <td style="width: 80px; height: 80px; text-align: center;" rowspan="2">
                                                            <img src='<%# Eval("pic") %>' width="100" height="120" runat="server" id="Img1">
                                                            <td style="width: 100px; height: 30px;">&nbsp;&nbsp;<%#Eval("sName")%></td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="vertical-align: top; text-align: left; height: 100px; width: 400px;">&nbsp;&nbsp;<%# Eval("comment")%></td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </asp:ListView>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="accordion-group">
                            <div class="accordion-heading">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseThree">徽章墙
                                </a>
                            </div>
                            <div id="collapseThree" class="accordion-body collapse">
                                <div class="accordion-inner">
                                    <div id="badge">
                                        <h3 class="alert">徽章墙</h3>
                                        <asp:Panel ID="p_badge" runat="server" ForeColor="#660066" Width="80%">
                                            <asp:Image ID="i_badge" runat="server" Height="120px" ImageUrl="~/images/Badge/tps.png" />
                                        </asp:Panel>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="accordion-group">
                            <div class="accordion-heading">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseFour">留言板
                                </a>
                            </div>
                            <div id="collapseFour" class="accordion-body collapse">
                                <div class="accordion-inner">
                                    <div id="d_board" style="font-family: 'FangSong_GB2312 '">
                                        <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <div>
                                                    <asp:TextBox ID="TextWord" runat="server" Width="300" Height="80" TextMode="MultiLine"></asp:TextBox>
                                                    <br />
                                                    <asp:Button ID="Submit" class="btn btn-primary btn-sm" runat="server" Text="发表" OnClick="Submit_Click" />
                                                    <asp:DataList ID="board" runat="server">
                                                        <ItemTemplate>
                                                            <table border="0" cellpadding="0" cellspacing="0" align="center">
                                                                <tr>
                                                                    <td style="width: 80px; height: 80px; text-align: center;" rowspan="2">
                                                                        <img src='<%# Eval("logo") %>' width="80" height="80" runat="server" id="Img1">
                                                                        <td style="width: 100px; height: 30px;">&nbsp;&nbsp;<%#Eval("aliasName")%>发表于：<%# Eval("time")%><asp:Label ID="Label1" runat="server"></asp:Label></td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="4" style="vertical-align: top; text-align: left; height: 100px; width: 400px;">&nbsp;&nbsp;<%# Eval("text")%><asp:Label ID="Label8" runat="server"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </ItemTemplate>
                                                    </asp:DataList>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
    
</asp:Content>
