<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="query.aspx.cs" Inherits="WebApplication1.query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form id="form1" runat="server">
        <div>
            <div style="width: 956px; margin-left: 23%; margin-top: 5px; height: 322px;">
                <table style="width:80%;margin-left:18%;font-size:25px;font-weight:700">
                    <tr>
                        <td>
                            使用高考志愿填报查询记录表
                        </td>
                    </tr>
                </table>
                <div style="margin-top:20px; float:left;">
                    <asp:GridView ID="gvShow" runat="server" Width="682px" HorizontalAlign="Center" AllowPaging="True" PageIndex="9" onpageindexchanging="gvShow_PageIndexChanging" PagerSettings-Mode="NumericFirstLast" PagerSettings-LastPageText="&nbsp尾页&nbsp" PagerSettings-NextPageText="&nbsp下一页&nbsp" PagerSettings-PreviousPageText="&nbsp上一页&nbsp" PageSize="20" PagerSettings-FirstPageText="&nbsp首页&nbsp">
                        <RowStyle HorizontalAlign="Center" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
</asp:Content>
