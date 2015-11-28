<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="infoTitle.aspx.cs" Inherits="WebApplication1.infoTitle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
        <style type="text/css">
        ul.nav li {
            text-align: center;
        }
        div.pagination {
            width: 100%; text-align: center;
        }
        #body {
            border: 1px solid gray;
             padding: 10px; 
             background-color: #fff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
     <div class="container">
        <div id="body" class="hero-unit">
            <h2>新闻列表(按上传时间排序)</h2>
            <ul id="list" class="nav nav-tabs nav-stacked">
                <li class="active"><a href="#">标题</a></li>
                <%--$("#list li:last")选中最后一个li--%>
            </ul>
            <div class="pagination">
                <ul>
                    <li><a id="previous" href="#">&larr;</a></li>
                    <li id="pages"><a id="next" href="#">&rarr;</a></li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
</asp:Content>
