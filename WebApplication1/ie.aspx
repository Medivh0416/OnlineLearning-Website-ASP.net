<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="ie.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <style type="text/css" rel="stylesheet">
        #main {
            min-width:1171px;
        }
        .badge {
            float: right;
        }

        .accordion-heading {
            background-color: #F5F5F5;
        }

        .accordion-body {
            background-color: #fff;
        }

        .fix tr {
            background-color: #fff;
        }

        .leftBlock {
            float:left;
            width: 620px;
            padding-left: 15px;
            padding-right: 15px;
            position: relative;
        }

        .rightBlock {
            float:left;
            width: 480px;
            padding-left: 15px;
            padding-right: 15px;
            position: relative;
        }
        .container {width:1170px!important;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="container">
        <div class="leftBlock">
            <%--轮播插件--%>
            <div id="myCarousel" class="carousel slide">
                <div class="carousel-inner">
                    <div class="item active">
                        <%--<a href="http://iwan.baidu.com/search/k?kquery=%E6%8A%AB%E7%94%B2%E9%BE%99%E9%BE%9F_info&zt=ps" target="_blank">--%>
                        <img src="images/Carousel0.jpg" alt="Rammus_Splash_5" />
                    </div>
                    <div class="item">
                        <%--<a href="http://iwan.baidu.com/search/k?kquery=%E6%AD%A6%E5%99%A8%E5%A4%A7%E5%B8%88_info&zt=ps" target="_blank">--%>
                        <img src="images/Carousel1.jpg" alt="Jax_splash_6" />
                    </div>
                    <div class="item">
                        <%--<a href="http://iwan.baidu.com/search/k?kquery=%E5%BE%B7%E9%82%A6%E6%80%BB%E7%AE%A1_info&zt=ps" target="_blank">--%>
                        <img src="images/Carousel2.jpg" alt="XinZhao_Splash_0" />
                    </div>
                    <div class="item">
                        <%--<a href="http://iwan.baidu.com/search/k?kquery=%E9%BD%90%E5%A4%A9%E5%A4%A7%E5%9C%A3_info&zt=ps" target="_blank">--%>
                        <img src="images/Carousel3.jpg" alt="MonkeyKing_Splash_1" />
                    </div>
                </div>
                <a class="left carousel-control" href="#myCarousel" data-slide="prev">‹</a>
                <a class="right carousel-control" href="#myCarousel" data-slide="next">›</a>
            </div>
            <%--轮播插件end--%>

            <div class="accordion" id="accordion2">
                <div class="accordion-group">
                    <div class="accordion-heading">
                        <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseOne">高一
                        </a>
                    </div>
                    <div id="collapseOne" class="accordion-body collapse in">
                        <div class="accordion-inner">
                            <button type="button" class="btn btn-primary btn-lg">代数</button>
                            <button type="button" class="btn btn-primary btn-lg">空间向量</button>
                            <button type="button" class="btn btn-primary btn-lg">解析几何</button>
                            <button type="button" class="btn btn-primary btn-lg">立体几何</button>
                            <button type="button" class="btn btn-primary btn-lg">电学</button>
                            <button type="button" class="btn btn-primary btn-lg">力学</button>
                        </div>
                    </div>
                </div>
                <div class="accordion-group">
                    <div class="accordion-heading">
                        <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseTwo">高二
                        </a>
                    </div>
                    <div id="collapseTwo" class="accordion-body collapse">
                        <div class="accordion-inner">
                            <button type="button" class="btn btn-primary btn-lg">代数</button>
                            <button type="button" class="btn btn-primary btn-lg">空间向量</button>
                            <button type="button" class="btn btn-primary btn-lg">解析几何</button>
                            <button type="button" class="btn btn-primary btn-lg">立体几何</button>
                            <button type="button" class="btn btn-primary btn-lg">电学</button>
                            <button type="button" class="btn btn-primary btn-lg">力学</button>
                        </div>
                    </div>
                </div>
                <div class="accordion-group">
                    <div class="accordion-heading">
                        <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseThree">高三
                        </a>
                    </div>
                    <div id="collapseThree" class="accordion-body collapse">
                        <div class="accordion-inner">
                            <button type="button" class="btn btn-primary btn-lg">代数</button>
                            <button type="button" class="btn btn-primary btn-lg">空间向量</button>
                            <button type="button" class="btn btn-primary btn-lg">解析几何</button>
                            <button type="button" class="btn btn-primary btn-lg">立体几何</button>
                            <button type="button" class="btn btn-primary btn-lg">电学</button>
                            <button type="button" class="btn btn-primary btn-lg">力学</button>
                        </div>
                    </div>
                </div>
                <div class="accordion-group">
                    <div class="accordion-heading">
                        <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseFour">初中
                        </a>
                    </div>
                    <div id="collapseFour" class="accordion-body collapse">
                        <div class="accordion-inner">
                            <button type="button" class="btn btn-primary btn-lg">代数</button>
                            <button type="button" class="btn btn-primary btn-lg">空间向量</button>
                            <button type="button" class="btn btn-primary btn-lg">解析几何</button>
                            <button type="button" class="btn btn-primary btn-lg">立体几何</button>
                            <button type="button" class="btn btn-primary btn-lg">电学</button>
                            <button type="button" class="btn btn-primary btn-lg">力学</button>
                            <input runat="server" id="temp" style="position: absolute;" />

                        </div>
                    </div>
                </div>
            </div>


            <%--=============================--%>
        </div>
        <div class="rightBlock">
            <table class="table table-hover" style="border: 1px solid #DDDDDD; padding-bottom: 10px;">
                <thead style="background-color: #428BCA; color: white;">
                    <tr>
                        <th>
                            <a id="A1" href="news.aspx?id=33" target="_blank" runat="server" style="color: #fff;">最新新闻</a>
                        </th>
                    </tr>
                </thead>
                <tbody class="fix">
                    <tr>
                        <td>
                            <a href="news.aspx?id=0" target="_blank" runat="server" id="news0"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="news.aspx?id=1" target="_blank" runat="server" id="news1"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="news.aspx?id=2" target="_blank" runat="server" id="news2"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="news.aspx?id=3" target="_blank" runat="server" id="news3"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="news.aspx?id=4" target="_blank" runat="server" id="news4"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="news.aspx?id=5" target="_blank" runat="server" id="news5"></a>
                        </td>
                    </tr>
                </tbody>
            </table>

            <table class="table table-hover" style="border: 1px solid #DDDDDD; padding-bottom: 10px;">
                <thead style="background-color: #428BCA; color: white;">
                    <tr>
                        <th>
                            <a id="A2" href="infoTitle.aspx?id=1" target="_blank" runat="server" style="color: #fff;">最新资讯</a>
                        </th>
                    </tr>
                </thead>
                <tbody class="fix">
                    <tr>
                        <td>
                            <a href="info.aspx?id=0" target="_blank" runat="server" id="info0"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="info.aspx?id=1" target="_blank" runat="server" id="info1"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="info.aspx?id=2" target="_blank" runat="server" id="info2"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="info.aspx?id=3" target="_blank" runat="server" id="info3"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="info.aspx?id=4" target="_blank" runat="server" id="info4"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="info.aspx?id=5" target="_blank" runat="server" id="info5"></a>
                        </td>
                    </tr>
                </tbody>
            </table>

        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
    <script type="text/javascript">
        $('.carousel').carousel();
    </script>
</asp:Content>
