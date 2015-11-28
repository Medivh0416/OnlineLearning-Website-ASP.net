<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="input.aspx.cs" Inherits="WebApplication1.input" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <style type="text/css">
        .style1
        {
            text-align:right;
            vertical-align:middle;
        }
       
        .auto-style2 {
            text-align: right;
            vertical-align: middle;
            width: 20px;
        }
       
        .auto-style3 {
            height: 34px;
            width: 123px;
        } 
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form id="form1" runat="server">
        <div style="width:60%; margin-left:25%; margin-top: 2px; height: 44px;">
            <table>
                <tr>
                    <td class="auto-style3">手动输入数据：</td>       
                </tr>
                <tr>
                    <td class = "auto-style2">省份</td>
                    <td>
                        <input id ="txtPro" style="width:70px" runat ="server"/>
                    </td>
                   
                    <td >报考类别</td>
                    <td >
                        <select id="ddlCourse" style="width:70px" runat ="server">
                            <option value="0">理科</option>
                            <option value="1">文科</option>
                        </select>
                    </td>
                    <td class = "style1">批次</td>
                    <td>
                        <select id="ddlBatch" style="width:70px" runat ="server">
                            <option value="0">一本</option>
                            <option value="1">二本</option>
                        </select>
                    </td>
                    <td class = "style1">位次</td>
                    <td>
                        <input id="txtRanking" style = "width:53px" runat ="server" onkeyup="if(isNaN(value))execCommand('undo')" 
                    onafterpaste="if(isNaN(value))execCommand('undo')"/>
                    </td>
                    </tr>
                    <tr>
                    <td class = "style1">学校名称</td>
                    <td>
                        <input id="txtUniname" runat ="server" style ="width:83px" onkeyup="if(isNaN(value))execCommand('undo')" 
                    onafterpaste="if(isNaN(value))execCommand('undo')"/>
                    </td>
                    <td class = "style1">学校层次</td>
                    <td>
                        <select id="ddlLevel" style="width:50px" runat ="server">
                            <option value="0">无</option>
                            <option value="1">985</option>
                            <option value="2">211</option>
                        </select>
                    </td>
                    <td class="style1">学校所在城市</td>
                    <td>
                        <input id="txtCity" style ="width:60px" runat="server" onkeyup="if(isNaN(value))execCommand('undo')" 
                    onafterpaste="if(isNaN(value))execCommand('undo')"/>
                    </td>
                    <td class="style1">城市赋分</td>
                    <td>
                        <input id="txtCitypoint" style="width:23px" runat="server" onkeyup="if(isNaN(value))execCommand('undo')" 
                    onafterpaste="if(isNaN(value))execCommand('undo')"/>
                    </td>
                    <td>
                        <asp:Button ID="Submit" runat="server" Text="提交" OnClick="Submit_Click" />
                       <%-- <asp:Label ID="Label1" runat="server"></asp:Label>
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                        <asp:Label ID="Label5" runat="server"></asp:Label>
                        <asp:Label ID="Label6" runat="server"></asp:Label>
                        <asp:Label ID="Label7" runat="server"></asp:Label>
                        <asp:Label ID="Label8" runat="server"></asp:Label>--%>
                    </td>
                </tr>
            </table>
        </div>
        <div style="width:60%; margin-left: 25%; margin-top: 80px;">
            <td>从Eecel导入大学录取信息</td>
            <asp:FileUpload ID="fuUpload" runat="server"  />
            <asp:Button ID="btnImport" runat="server" Text="导入" OnClick="btnImport_Click" />
        </div>
        <div style="width: 60%; margin-left:25%; margin-top: 10px;">
            <td>从Excel导入一分一档对应信息</td>
            <asp:FileUpload ID="fuGrade" runat="server"  />
            <asp:Button ID="btnImportgrade" runat="server" Text="导入" OnClick="btnImportgrade_Click"  />
        </div>
        <div style="margin-left:25%; float:left" >
            <asp:GridView ID="gvExcel" runat="server" Width="682px" HorizontalAlign="Center">
            <RowStyle HorizontalAlign="Center" /> 
            </asp:GridView>
            
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
</asp:Content>
