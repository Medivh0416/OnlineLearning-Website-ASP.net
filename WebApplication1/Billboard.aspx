<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="Billboard.aspx.cs" Inherits="WebApplication1.Billboard" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form runat="server"  style="margin: 0 auto;width:1000px">
        <div id="main">
            <div id="board">
                <div id="left" runat="server" style="display: inline-block; padding-left: 10px; width: 26%; float: left; left: 1%">
                    <h3>星星榜</h3>

                    <div>
                        <asp:ListView ID="ListView1" runat="server" Style="position: relative">
                            <ItemTemplate>
                                <table style="left: 1px; position: relative; top: 0px; border-right: #e8e8e8 1px solid; border-left: #e8e8e8 1px solid;">
                                    <tr>
                                        <td style="width: 80px; border: #e8e8e8 1px solid;" align="center">
                                            <div style="width: 100px; position: relative; height: 100px">
                                                <asp:Image ID="logo" runat="server" Height="90px" Width="90px" ImageUrl='<%#DataBinder.Eval(Container.DataItem,"logo") %>' /><br />
                                                <asp:LinkButton ID="lkbUser" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"id") %>' OnCommand="lkbUser_Click" Style="position: relative" Text='<%#DataBinder.Eval(Container.DataItem,"aliasName") %>'></asp:LinkButton>
                                            </div>
                                        </td>
                                        <td style="width: 100px; border: #e8e8e8 1px solid; height: 121px">
                                            <div style="left: 3px; width: 180px; position: relative; top: 0px; text-align: left; height: 82px;">
                                                <y>小伙伴得分
                                            <%#DataBinder.Eval(Container.DataItem, "score")%></y>
                                                <br />
                                                <div style="padding-top: 5px">
                                                    <asp:LinkButton ID="lbt_up" runat="server" OnCommand="editUp" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"id") %>'><img src="images/up.png" style="width:20px;height:20px"/></asp:LinkButton><asp:Label ID="up" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"up") %>'></asp:Label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
                <div id="middle" runat="server" style="display: inline-block; width: 26%; float: left; left: 1%">
                    <h3>能力榜</h3>
                    <div>
                        <asp:ListView ID="ListView2" runat="server" Style="position: relative">
                            <ItemTemplate>
                                <table style="left: 1px; position: relative; top: 0px; border-right: #e8e8e8 1px solid; border-left: #e8e8e8 1px solid;">
                                    <tr>
                                        <td style="width: 80px; border: #e8e8e8 1px solid;" align="center">
                                            <div style="width: 100px; position: relative; height: 100px">
                                                <asp:Image ID="logo" runat="server" Height="90px" Width="90px" ImageUrl='<%#DataBinder.Eval(Container.DataItem,"logo") %>' /><br />
                                                <asp:LinkButton ID="lkbUser" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"id") %>' OnCommand="lkbUser_Click" Style="position: relative" Text='<%#DataBinder.Eval(Container.DataItem,"aliasName") %>'></asp:LinkButton>
                                            </div>
                                        </td>
                                        <td style="width: 100px; border: #e8e8e8 1px solid; height: 121px">
                                            <div style="left: 3px; width: 180px; position: relative; top: 0px; text-align: left; height: 82px;">
                                                <y>小伙伴等级
                                            <%#DataBinder.Eval(Container.DataItem, "level")%></y>
                                                <br />
                                                <div style="padding-top: 5px">
                                                    <asp:LinkButton ID="lbt_up" runat="server" OnCommand="editUp" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"id") %>'><img src="images/up.png" style="width:20px;height:20px"/></asp:LinkButton><asp:Label ID="up" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"up") %>'></asp:Label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
                <div id="right" runat="server" style="display: inline-block; width: 26%; float: left; left: 1%">
                    <h3>时间榜</h3>
                    <div>

                        <asp:ListView ID="ListView3" runat="server" Style="position: relative">
                            <ItemTemplate>
                                <table style="left: 1px; position: relative; top: 0px; border-right: #e8e8e8 1px solid; border-left: #e8e8e8 1px solid;">
                                    <tr>
                                        <td style="width: 80px; border: #e8e8e8 1px solid;" align="center">
                                            <div style="width: 100px; position: relative; height: 100px">
                                                <asp:Image ID="logo" runat="server" Height="90px" Width="90px" ImageUrl='<%#DataBinder.Eval(Container.DataItem,"logo") %>' /><br />
                                                <asp:LinkButton ID="lkbUser" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"id") %>' OnCommand="lkbUser_Click" Style="position: relative" Text='<%#DataBinder.Eval(Container.DataItem,"aliasName") %>'></asp:LinkButton>
                                            </div>
                                        </td>
                                        <td style="width: 100px; border: #e8e8e8 1px solid; height: 121px">
                                            <div style="left: 3px; width: 180px; position: relative; top: 0px; text-align: left; height: 82px;">
                                                <y>小伙伴做题
                                            <%#DataBinder.Eval(Container.DataItem, "workTime")%>秒</y>
                                                <br />
                                                <div style="padding-top: 5px">
                                                    <asp:LinkButton ID="lbt_up" runat="server" OnCommand="editUp" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"id") %>'><img src="images/up.png" style="width:20px;height:20px"/></asp:LinkButton><asp:Label ID="up" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"up") %>'></asp:Label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">

    <%--    <link type="text/css" href="css/Billboard.css" rel="stylesheet" />--%>
</asp:Content>
