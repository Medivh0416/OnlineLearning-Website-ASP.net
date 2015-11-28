<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="info.aspx.cs" Inherits="WebApplication1.info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <style type="text/css">
        #divider {
            line-height:10px; height:1px; width:90%; margin:10px auto; background-color:#EEEEEE;
        }
        #body {
            background-color:#fff;
        }
        li {
            font-size:14px;
            line-height:20px!important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="container">
        <div id="body" class="hero-unit" style="border: 1px solid gray; padding: 10px;">
            <h2 id="title" runat="server" style="text-align: center"></h2>
            <div id="date0" runat="server" style="text-align: center"></div>

                <div id="divider"></div>

            <p id="content1" runat="server">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</p>
            <nav>
                <ul class="pager">
                    <li class="previous"><a href="#">&larr; 上一条新闻</a></li>
                    <li class="next"><a href="#">下一条新闻 &rarr;</a></li>
                </ul>
            </nav>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
     <script type="text/javascript">
         //index是从0开始算的，idlength是从1开始算的
         var index = '<%=getId()%>';
         var idLength = '<%=getIdLength()%>';
         $(document).ready(function () {
             if (index == 0) {
                 $(".previous").addClass("disabled");
                 $(".previous a").text("没有了");
             } else {
                 var strPrevious = "news.aspx?id=" + (parseInt(index) - 1);    //parseInt（）把字符串转换成整数
                 $(".previous a").attr("href", strPrevious);
             };
             if (parseInt(index) >= parseInt(idLength) - 1) {
                 $(".next").addClass("disabled");
                 $(".next a").text("没有了");
             } else {
                 var strNext = "news.aspx?id=" + (parseInt(index) + 1);
                 $(".next a").attr("href", strNext);
             };
         });
    </script>
</asp:Content>
