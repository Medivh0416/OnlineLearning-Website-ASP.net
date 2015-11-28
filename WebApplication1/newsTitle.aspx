<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="newsTitle.aspx.cs" Inherits="WebApplication1.newsTitle" %>

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
    <script type="text/javascript">
        var idLength = '<%=getIdLength()%>';
        var currentPage = '<%=getId()%>'; //需要访问的页数
        //需要显示的title条数
        var allPage = Math.ceil(idLength / 20);
        //如果超出请求范围（id太大）则出错；
        if (currentPage > allPage ||currentPage == "" || currentPage == null) {
            location.href = "404.html";
        }
    </script>

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
    <script type="text/javascript">
        var loop;
        (idLength > 20) ? loop = 20 : loop = idLength;

        $(document).ready(function () {
            //添加title
            var insertTitle1 = "<li><a href='news.aspx?id=";
            var insertTitle2 = "' target='_black'>";
            var insertTitle3 = "</a></li>";
            var i = 0;
            getTitle(i);  //ajax动态添加title 使用递归调用
            //非常重要。不能在for循环里使用ajax。返回的值不一定是按顺序地返回
            function getTitle(i) {
                //在function里不能访问全局变量？
                if (i >= loop) { return; } else {
                    $.ajax({
                        type: "GET",
                        url: "Handler.ashx",
                        datatype: "json",
                        data: { "method": "getTitle", "id": i },
                        success: function (title) {
                            $("#list li:last").after(insertTitle1 + ((currentPage - 1) * 20 + i) + insertTitle2 + title + insertTitle3);
                            getTitle(++i);    //在success里递归调用
                        }
                    });
                }
            }

            //动态添加页码
            var pages1 = "<li><a href='newstitle.aspx?id=";
            var pages2 = "'>";
            var pages3 = "</a></li>"
            var navList = 0;  //显示在页面里的导航标签数量
            allPage > 10 ? navList = 10 : navList = allPage;
            for (var i = 1; i <= navList; i++) {
                $("#pages").before(pages1 + i + pages2 + i + pages3);
            }

            var $prev = $("#previous");
            var $next = $("#next");
            if (currentPage == 1 || currentPage == "") {
                $prev.parent().addClass("disabled");
            } else {
                $prev.attr("href", "newsTitle.aspx?id=" + (parseInt(currentPage) - 1));
            }
            if (currentPage == navList || currentPage == "") {

                $next.parent().addClass("disabled");
            } else {
                $next.attr("href", "newsTitle.aspx?id=" + (parseInt(currentPage) + 1));
            }


        });
    </script>
</asp:Content>
