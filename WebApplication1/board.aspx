<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="board.aspx.cs" Inherits="WebApplication1.board" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">

       <form id="form1" runat="server">
    <div style="padding-top:100px">
        <table border="0" cellpadding="0" cellspacing="0" style="width: 760px; position: relative">
            <tr>
                <td>
                    &nbsp; &nbsp;
                    <asp:DataList ID="DataList1" runat="server" Style="position: relative; top: 0px; left: 0px;" OnItemDataBound="DataList1_ItemDataBound" Width="100%">
                        <ItemTemplate>
                            <table border="0" cellpadding="0" cellspacing="0" style="border-top: #e8e8e8 1px solid;
                                left: 1px; width: 996px; position: relative; top: 0px; height: 32px">
                                <tr>
                                    <td style="width: 21px; height: 27px; border-left: #e8e8e8 1px solid;" align="center">
                                    </td>
                                    <td align="right" style="border-right: #e8e8e8 1px solid;
                                        width: 978px; height: 27px">
                                        <div style="left: 2px; width: 350px; position: relative; top: 0px; height: 26px;
                                            text-align: left">
                                           <a href="mailto:<%#DataBinder.Eval(Container.DataItem,"email") %>" ></a>&nbsp;Email
                                           &nbsp;&nbsp;&nbsp;主页&nbsp;&nbsp;&nbsp;发布时间：
                   <%--                         <%#DataBinder.Eval(Container.DataItem, "time", "{0:D}")%>--%>

                                        </div>
                                    </td>
                                </tr>
                            </table>
                            <table border="0" cellpadding="0" cellspacing="0" style="left: 1px; width: 996px;
                                position: relative; top: 0px; border-right: #e8e8e8 1px solid; border-left: #e8e8e8 1px solid; height: 100%;">
                                <tr>
                                    <td style="width: 125px; border-right: #e8e8e8 1px solid;" align="center">
                                        <div style="width: 100px; position: relative; height: 100px">
                                        <asp:Label ID="lblUserPic" runat="server" Style="position: relative" Text=<%#DataBinder.Eval(Container.DataItem,"id") %>></asp:Label></td>
                                    <td style="width: 431px; border-bottom: #e8e8e8 1px solid; height: 121px">
                                        <div style="left: 3px; width: 855px; position: relative; top: 0px;
                                            text-align: left; height: 82px;">
                                            <%#DataBinder.Eval(Container.DataItem, "text")%>
                                            <br />——————————————————<br /><a href="add.aspx" target="_blank">发表留言</a>
                                            <asp:LinkButton ID="lbtnReply" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"id")%>'
                                                OnCommand="lbtnReply_Command" Style="position: relative; top: 0px" OnClick="lbtnReply_Click">回复</asp:LinkButton>
                                            <asp:LinkButton ID="lbtnDelete" runat="server"
                                                OnCommand="lbtnDelete_Command" Style="position: relative"  CommandArgument='<%#DataBinder.Eval(Container.DataItem,"id")%>'>删除</asp:LinkButton>&nbsp;
                                             </div>
                                    </td>
                                </tr>
                               
                            </table>
                            <table border="0" cellspacing="0" style="border-top: #e8e8e8 1px solid; left: 1px;
                                width: 996px; position: relative; top: 0px; height: 13px">
                                <tr>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <SeparatorTemplate>
                            <br />                            
                        </SeparatorTemplate>
                    </asp:DataList></td>
            </tr>
            <tr>
                <td align="right">
                    共<asp:Label ID="lblMesTotal" runat="server" Style="position: relative" Text="Label"></asp:Label>条留言&nbsp;
                    第<asp:Label ID="lblPageCur" runat="server" Style="position: relative" Text="Label"></asp:Label>页&nbsp;
                    共<asp:Label ID="lblPageTotal" runat="server" Style="position: relative" Text="Label"></asp:Label>页&nbsp;
                    <asp:Button ID="Button3" runat="server" Style="position: relative" Text="首页" OnClick="Button3_Click" />
                    <asp:Button ID="Button1" runat="server" Style="position: relative" Text="上一页" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Style="position: relative" Text="下一页" OnClick="Button2_Click" />
                    <asp:Button ID="Button4" runat="server" Style="position: relative" Text="尾页" OnClick="Button4_Click" />
                    &nbsp; 转到<asp:DropDownList ID="DropDownList1" runat="server" Style="position: relative">
                    </asp:DropDownList>&nbsp;
                    <asp:Button ID="Button5" runat="server" Style="position: relative" Text="GO" OnClick="Button5_Click" /></td>
            </tr>
            </table>
    
    </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
    </asp:Content>