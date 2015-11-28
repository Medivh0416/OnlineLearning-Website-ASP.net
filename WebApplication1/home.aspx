<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication1.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <link type="text/css" href="css/home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <!-- Begin page content -->
    <div class="container">
        <div class="row">
            <div class="col-sm-7 span7">
                <!--============carousel轮播插件================-->
                <div id="carousel-example" class="carousel slide" data-ride="carousel">
                    <!-- Indicators -->
                    <ol class="carousel-indicators">
                        <li data-target="#carousel-example" data-slide-to="0" class="active"></li>
                        <li data-target="#carousel-example" data-slide-to="1"></li>
                        <li data-target="#carousel-example" data-slide-to="2"></li>
                        <li data-target="#carousel-example" data-slide-to="3"></li>
                    </ol>
                    <!-- Wrapper for slides -->
                    <div class="carousel-inner">
                        <a href="http://iwan.baidu.com/search/k?kquery=%E6%8A%AB%E7%94%B2%E9%BE%99%E9%BE%9F_info&zt=ps" target="_blank" class="item active">
                            <img src="images/Rammus_Splash_5.jpg" alt="Rammus_Splash_5" />
                            <!--504*297比例的图，自适应大小-->
                            <div class="carousel-caption">Rammus_Splash_5</div>
                        </a>
                        <a href="http://iwan.baidu.com/search/k?kquery=%E6%AD%A6%E5%99%A8%E5%A4%A7%E5%B8%88_info&zt=ps" target="_blank" class="item">
                            <img src="images/Jax_splash_6.jpg" alt="Jax_splash_6" />
                            <div class="carousel-caption">Jax_Splash_6</div>
                        </a>
                        <a href="http://iwan.baidu.com/search/k?kquery=%E5%BE%B7%E9%82%A6%E6%80%BB%E7%AE%A1_info&zt=ps" target="_blank" class="item">
                            <img src="images/XinZhao_Splash_0.jpg" alt="XinZhao_Splash_0" />
                            <div class="carousel-caption">XinZhao_Splash_0</div>
                        </a>
                        <a href="http://iwan.baidu.com/search/k?kquery=%E9%BD%90%E5%A4%A9%E5%A4%A7%E5%9C%A3_info&zt=ps" target="_blank" class="item">
                            <img src="images/MonkeyKing_Splash_1.jpg" alt="MonkeyKing_Splash_1" />
                            <div class="carousel-caption">MonkeyKing_Splash_1</div>
                        </a>
                    </div>
                    <!-- Controls -->
                    <a class="left carousel-control" href="#carousel-example" data-slide="prev">
                        <span class="glyphicon glyphicon-chevron-left"></span></a>
                    <!--向左向右图标-->
                    <a class="right carousel-control" href="#carousel-example" data-slide="next">
                        <span class="glyphicon glyphicon-chevron-right"></span></a>
                </div>
                <!--carousel轮播插件 end-->
                <!--===================================-->
                <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
                    <div class="panel panel-default">
                        <div class="panel-heading" role="tab" id="headingOne">
                            <h4 class="panel-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">高一部分
                                </a>
                            </h4>
                        </div>
                        <div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
                            <div class="panel-body">
                                <button type="button" class="btn btn-primary btn-lg">代数</button>
                                <button type="button" class="btn btn-primary btn-lg">空间向量</button>
                                <button type="button" class="btn btn-primary btn-lg">解析几何</button>
                                <button type="button" class="btn btn-primary btn-lg">立体几何</button>
                                <button type="button" class="btn btn-primary btn-lg">电学</button>  
                                <button type="button" class="btn btn-primary btn-lg">力学</button>                               
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-default">
                        <div class="panel-heading" role="tab" id="headingTwo">
                            <h4 class="panel-title">
                                <a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">高二部分</a>
                            </h4>
                        </div>
                        <div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
                            <div class="panel-body">
                                <button type="button" class="btn btn-primary btn-lg">第一单元</button>
                                <button type="button" class="btn btn-primary btn-lg">第二单元</button>
                                <button type="button" class="btn btn-primary btn-lg">第三单元</button>
                                <button type="button" class="btn btn-primary btn-lg">第四单元</button>
                                <button type="button" class="btn btn-primary btn-lg">第五单元</button>
                                <button type="button" class="btn btn-primary btn-lg">第六单元</button>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-default">
                        <div class="panel-heading" role="tab" id="headingThree">
                            <h4 class="panel-title">
                                <a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false" aria-controls="collapseThree">高三部分</a>
                            </h4>
                        </div>
                        <div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
                            <div class="panel-body">
                                <button type="button" class="btn btn-primary btn-lg">第一单元</button>
                                <button type="button" class="btn btn-primary btn-lg">第二单元</button>
                                <button type="button" class="btn btn-primary btn-lg">第三单元</button>
                                <button type="button" class="btn btn-primary btn-lg">第四单元</button>                               
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-default">
                        <div class="panel-heading" role="tab" id="headingFour">
                            <h4 class="panel-title">
                                <a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseFour" aria-expanded="false" aria-controls="collapseFour">初一部分</a>
                            </h4>
                        </div>
                        <div id="collapseFour" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingFour">
                            <div class="panel-body">
                                <button type="button" class="btn btn-primary btn-lg">物理</button>
                                <button type="button" class="btn btn-primary btn-lg">化学</button>
                                <button type="button" class="btn btn-primary btn-lg">生物</button>
                                <button type="button" class="btn btn-primary btn-lg">数学</button>
                                <button type="button" class="btn btn-primary btn-lg">语文</button>
                                <button type="button" class="btn btn-primary btn-lg">地理</button>
                                <button type="button" class="btn btn-primary btn-lg">历史</button>
                                <button type="button" class="btn btn-primary btn-lg">政治</button>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-default">
                        <div class="panel-heading" role="tab" id="headingFive">
                            <h4 class="panel-title">
                                <a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseFive" aria-expanded="false" aria-controls="collapseFive">初二部分</a>
                            </h4>
                        </div>
                        <div id="collapseFive" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingFive">
                            <div class="panel-body">
                                <button type="button" class="btn btn-primary btn-lg">物理</button>
                                <button type="button" class="btn btn-primary btn-lg">化学</button>
                                <button type="button" class="btn btn-primary btn-lg">生物</button>
                                <button type="button" class="btn btn-primary btn-lg">数学</button>
                                <button type="button" class="btn btn-primary btn-lg">语文</button>
                                <button type="button" class="btn btn-primary btn-lg">地理</button>
                                <button type="button" class="btn btn-primary btn-lg">历史</button>
                                <button type="button" class="btn btn-primary btn-lg">政治</button>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-default">
                        <div class="panel-heading" role="tab" id="headingSix">
                            <h4 class="panel-title">
                                <a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseSix" aria-expanded="false" aria-controls="collapseSix">初三部分</a>
                            </h4>
                        </div>
                        <div id="collapseSix" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingSix">
                            <div class="panel-body">
                                <button type="button" class="btn btn-primary btn-lg">物理</button>
                                <button type="button" class="btn btn-primary btn-lg">化学</button>
                                <button type="button" class="btn btn-primary btn-lg">生物</button>
                                <button type="button" class="btn btn-primary btn-lg">数学</button>
                                <button type="button" class="btn btn-primary btn-lg">语文</button>
                                <button type="button" class="btn btn-primary btn-lg">地理</button>
                                <button type="button" class="btn btn-primary btn-lg">历史</button>
                                <button type="button" class="btn btn-primary btn-lg">政治</button>
                            </div>
                        </div>
                    </div>
                </div>
                <!--===============================================================-->               
            </div>
            <!--left_block end-->
            <div class="col-sm-5 span5">
                <div class="list-group">
                    <a href="news.aspx?id=33" target="_blank" target="_blank" class="list-group-item active">东秦新闻</a>
                    <a href="#" runat="server" target="_blank" id="news0" class="list-group-item"></a><%--内容在后台动态添加，包括用于显示时间的span标签--%>
                    <a href="#" runat="server" target="_blank" id="news1" class="list-group-item"></a>
                    <a href="#" runat="server" target="_blank" id="news2" class="list-group-item"></a>
                    <a href="#" runat="server" target="_blank" id="news3" class="list-group-item"></a>
                    <a href="#" runat="server" target="_blank" id="news4" class="list-group-item"></a>
                    <a href="#" runat="server" target="_blank" id="news5" class="list-group-item"></a>
                </div>
                <div class="list-group">
                    <a href="news.aspx" target="_blank" runat="server" class="list-group-item active">东秦通知</a>
                    <a href="#" target="_blank" runat="server" id="news6" class="list-group-item"></a>
                    <a href="#" target="_blank" runat="server" id="news7" class="list-group-item"></a>
                    <a href="#" target="_blank" runat="server" id="news8" class="list-group-item"></a>
                    <a href="#" target="_blank" runat="server" id="news9" class="list-group-item"></a>
                    <a href="#" target="_blank" runat="server" id="news10" class="list-group-item"></a>
                    <a href="#" target="_blank" runat="server" id="news11" class="list-group-item"></a>
                </div>
            </div>
            <!--right_block end-->
        </div>
        <!--class = row end-->
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">

    <script type="text/javascript">
        $(document).ready(function () {
            var newsHref6 = "news.aspx?id=" + (idLength - 5);                  //顺序有待商榷
            var newsHref7 = "news.aspx?id=" + (idLength - 4);
            var newsHref8 = "news.aspx?id=" + (idLength - 3);
            var newsHref9 = "news.aspx?id=" + (idLength - 2);
            var newsHref10 = "news.aspx?id=" + (idLength - 1);
            var newsHref11 = "news.aspx?id=" + (idLength - 0);
            $("#ContentPlaceHolderMain_news6").attr('href', newsHref6);
            $("#ContentPlaceHolderMain_news7").attr('href', newsHref7);
            $("#ContentPlaceHolderMain_news8").attr('href', newsHref8);
            $("#ContentPlaceHolderMain_news9").attr('href', newsHref9);
            $("#ContentPlaceHolderMain_news10").attr('href', newsHref10);
            $("#ContentPlaceHolderMain_news11").attr('href', newsHref11);
        });
    </script>
</asp:Content>
