<%--用于更新新闻--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="backstage.aspx.cs" Inherits="WebApplication1.msboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <style type="text/css">
        body {
          padding-top:70px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="container"><label>title:</label><input type="text" /><br />
    <label>url:</label><input type="text" /><br />
    <label>date:</label><input type="text" /><br />
    <button type="button">submit</button></div>
    <label runat="server" id="label1"></label>
   <%--  <nav>
        <ul class="pagination">
            <li class="disabled"><a href="#">&laquo;</a></li>
            <li class="active"><a href="#">1</a></li>
            <li><a href="#">2</a></li>
            <li><a href="#">3</a></li>
            <li><a href="#">4</a></li>
            <li><a href="#">5</a></li>
            <li title="下一页"><a href="#">&raquo;</a></li>
        </ul>
    </nav>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">

</asp:Content>