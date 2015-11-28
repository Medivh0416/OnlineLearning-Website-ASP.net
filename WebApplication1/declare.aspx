<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="declare.aspx.cs" Inherits="WebApplication1.declare" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <style type="text/css">
        .style1
        {
            text-align:right;
            vertical-align:middle;
        }
        .lbl
        {
            color:red;        
        }
        .gridview{
            margin-left:20%!important;
            float:left;
            position:absolute;
        }
        /*.button{
            position:
            float:left;
        }*/
        *{margin:0;padding:0;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form runat="server">
            <div style="width:80%; margin-left:18%">
                <table style="width:100%; vertical-align:middle; height: 18px;">
                    <tr>
                        <td class = "style1">省份</td>
                        <td>
                            <asp:DropDownList ID="ddlPro" Width =" 80px" runat="server"></asp:DropDownList>
                        </td>
                        <td class = "style1">姓名</td>
                        <td>
                            <input id="txtName" style="width:83px" runat ="server" onkeyup="value=value.replace(/[^\u4E00-\u9FA5]/g,'')" 
                                onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\u4E00-\u9FA5]/g,''))" />
                        </td>
                        <td class = "style1">报考类别</td>
                        <td >
                            <select id="ddlCourse" style="width:80px" runat ="server">
                                <option value="0">理科</option>
                                <option value="1">文科</option>
                            </select>
                        </td>
                        <td class = "style1">高考分数</td>
                        <td>
                            <input id="txtGrade" runat ="server" style ="width:83px" onkeyup="if(isNaN(value))execCommand('undo')" 
                            onafterpaste="if(isNaN(value))execCommand('undo')"
                            onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;" />
                        </td>
                       <%-- <td class = "style1">位次</td>
                        <td>
                            <input id="txtRanking" style = "width:83px" runat ="server" onkeyup="if(isNaN(value))execCommand('undo')" 
                            onafterpaste="if(isNaN(value))execCommand('undo')" 
                            onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;"/>
                        </td>--%>
                        <td class = "style1">批次</td>
                        <td>
                            <select id="ddlBatch" style="width:80px" runat ="server">
                                <option value="0">一本</option>
                                <option value="1">二本</option>
                                <option value="2">三本</option>
                            </select>
                        </td>
                        <td>
                            <asp:Button ID="Submit" runat="server" Text="提交" OnClick="Submit_Click" />
                            <asp:Label ID="Label1" runat="server" Width="200px"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <asp:GridView ID="Gv1" runat="server" Width="50%" HorizontalAlign="Center" ShowHeader="False" CssClass="gridview">
                <RowStyle HorizontalAlign="Center" /> 
                </asp:GridView>
                
            </div>
            <div style ="margin-left:20%; position:relative;margin-top:920px">
                <asp:Button ID="btnExport" runat="server" OnClick="btnExport_Click" Text="导出为Excel" Visible="False" CssClass="button" />
            </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
</asp:Content>
