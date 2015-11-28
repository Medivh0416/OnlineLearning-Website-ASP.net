<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="forum.aspx.cs" Inherits="WebApplication1.BBS.forum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <link href="css/display.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form id="main" runat="server">
        <div style="width:800px; margin: 0 auto">
        <div style="height:100px;width:800px;">
            <img src="images/banner.jpg"/>
        </div>
        <div id="mid" style="width: 794px; margin: 0 auto;padding-top:10px">
            <a href="card.aspx">返回上级</a>
            <div style="background-color:#fcfcfc;">
                <table border="0" cellpadding="0" cellspacing="0" class="TableCss" align="center">
                    <tr>
                        <td colspan="5" rowspan="1" style="width: 794px; height: 1px; text-align: center;background-image:url(images/帖子及回帖信息页/头一小条.jpg)"></td>
                    </tr>
                    <tr>
                        <td style="width: 160px; height: 148px; text-align: center;" rowspan="2">
                            <br />
                            <asp:Image ID="logo" runat="server" Height="70px" Width="80" />
                            <br />
                            <br />
                            <asp:Label ID="name" runat="server" Text="Label"></asp:Label>
                            <br />
                            等级：<asp:Label ID="level" runat="server" Text="Label"></asp:Label></td>
                        <td style="width: 374px; height: 23px; text-align: left;">&nbsp;<div id="d_title" runat="server"></div></td>
                        <td style="width: 182px; height: 23px;"> 原 问 题 </td>
                        <td style="width: 78px; height: 23px;" colspan="2"></td>
                    </tr>
                    <tr>
                        <td colspan="4" style="vertical-align: top; text-align: left; height: 125px; width: 634px;">&nbsp;&nbsp;

                            <br />
                            <div id="d_text" runat="server"></div>
                        </td>
                    </tr>
                </table>
                <div style="clear: both">
                </div>
            </div>
            <table align="center" style="width: 810px; margin-right: 0px;" class="TableCss" border="0"
                cellpadding="0" cellspacing="0" width="795">
                <tr>
                    <td style="vertical-align: top; text-align: left;" class="style3" valign="top"
                        align="center" width="810">
                        <asp:ListView ID="lv_reply" runat="server">
                            <ItemTemplate>
                                <div>
                                <table border="0" cellpadding="0" cellspacing="0" class="TableCss" align="center">
                                    <tr>
                                        <td colspan="5" rowspan="1" style="width: 794px; height: 1px; text-align: center;background-image:url(images/帖子及回帖信息页/头一小条.jpg)"></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 160px; height: 148px; text-align: center;" rowspan="2">
                                            <br />
                                            <img src='<%# Eval("logo") %>' width="80" height="70" runat="server" id="Img1">
                                            <br />
                                            <br />
                                            <%#Eval("aliasName")%>
                                            <br />
                                            等级：<%#Eval("levelName")%></td>
                                        <br />
                                        </td>
                                    <td style="width: 374px; height: 23px; text-align: left;">&nbsp;</td>
                                        <td style="width: 182px; height: 23px;"><%# Eval("date", "{0:M月d日 h点m分}")%></td>
                                        <td style="width: 78px; height: 23px;" colspan="2">
                                            <asp:LinkButton ID="lbt_up" runat="server" OnCommand="editUp" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"followcardId") %>'><img src="images/up.png" style="width:20px;height:20px"/></asp:LinkButton><label id="lb_praise"><%# Eval("praise")%></label></td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="vertical-align: top; text-align: left; height: 125px; width: 634px;">&nbsp;&nbsp;<%# Eval("text")%></td>
                                    </tr>
                                </table>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                        <br />
                        共<asp:Label ID="lblMesTotal" runat="server" Style="position: relative" Text="Label"></asp:Label>条回复&nbsp;
                    第<asp:Label ID="lblPageCur" runat="server" Style="position: relative" Text="Label"></asp:Label>页&nbsp;
                    共<asp:Label ID="lblPageTotal" runat="server" Style="position: relative" Text="Label"></asp:Label>页&nbsp;
                    <asp:Button ID="Button3" runat="server" class="btn btn-primary btn-sm" Text="首页" OnClick="Button3_Click" />
                        <asp:Button ID="Button1" runat="server" class="btn btn-primary btn-sm" Text="上一页" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" class="btn btn-primary btn-sm" Text="下一页" OnClick="Button2_Click" />
                        <asp:Button ID="Button4" runat="server" class="btn btn-primary btn-sm" Text="尾页" OnClick="Button4_Click" />
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align: top; text-align: left;" class="style4"
                        align="right">&nbsp;</td>
                </tr>
                <tr>
                    <td class="style6">
                        <br />
                        <asp:TextBox ID="FreeTextBox1" runat="server" Height="113px" TextMode="MultiLine"
                            Width="700px" CssClass="ckeditor"></asp:TextBox>
                        <br />
                        <asp:Button ID="btnOK" runat="server" class="btn btn-primary btn-sm" OnClick="btnOK_Click" Text="回复" />
                        &nbsp;<asp:Button ID="cancle" runat="server" OnClick="cancle_Click" class="btn btn-primary btn-sm" Text="取消" />
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
    </div>
  </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
</asp:Content>
