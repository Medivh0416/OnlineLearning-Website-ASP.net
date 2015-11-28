<%@ Page Title="" Language="C#" MasterPageFile="~/bootstrap_v3.Master" AutoEventWireup="true" CodeBehind="homev3.aspx.cs" Inherits="WebApplication1.homev3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <!--[if IE]>
    <script type="text/javascript">
        window.location.href = "ie.aspx";
    </script>
    <![endif]-->
   
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
                        <a href="#" class="item active">
                            <img src="images/Carousel0.jpg" alt="Rammus_Splash_5" />
                            <!--504*297比例的图，自适应大小-->
                        </a>
                        <a href="#" class="item">
                            <img src="images/Carousel1.jpg" alt="Jax_splash_6" />
                        </a>
                        <a href="#" class="item">
                            <img src="images/Carousel2.jpg" alt="XinZhao_Splash_0" />
                        </a>
                        <a href="#" class="item">
                            <img src="images/Carousel3.jpg" alt="MonkeyKing_Splash_1" />
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
               <%-- <div class="list-group">
                    <a href="news.aspx?id=33" target="_blank" target="_blank" class="list-group-item active">最新资讯</a>--%>
<%--                    <a href="#" runat="server" target="_blank" id="news0" class="list-group-item"></a>--%><%--内容在后台动态添加，包括用于显示时间的span标签--%>
                  <%--  <a href="#" runat="server" target="_blank" id="news1" class="list-group-item"></a>
                    <a href="#" runat="server" target="_blank" id="news2" class="list-group-item"></a>
                    <a href="#" runat="server" target="_blank" id="news3" class="list-group-item"></a>
                    <a href="#" runat="server" target="_blank" id="news4" class="list-group-item"></a>
                    <a href="#" runat="server" target="_blank" id="news5" class="list-group-item"></a>
                </div>--%>
                <div class="list-group">
                    <a href="newsTitle.aspx?id=1" target="_blank" runat="server" class="list-group-item active">最新动态</a>
                    <a href="news.aspx?id=0" target="_blank" runat="server" id="news0" class="list-group-item"></a>
                    <a href="news.aspx?id=1" target="_blank" runat="server" id="news1" class="list-group-item"></a>
                    <a href="news.aspx?id=2" target="_blank" runat="server" id="news2" class="list-group-item"></a>
                    <a href="news.aspx?id=3" target="_blank" runat="server" id="news3" class="list-group-item"></a>
                    <a href="news.aspx?id=4" target="_blank" runat="server" id="news4" class="list-group-item"></a>
                    <a href="news.aspx?id=5" target="_blank" runat="server" id="news5" class="list-group-item"></a>
                </div>
                <div class="list-group">
                    <a href="infoTitle.aspx?id=1" target="_blank" runat="server" class="list-group-item active">最新资讯</a>
                    <a href="info.aspx?id=0" target="_blank" runat="server" id="info0" class="list-group-item"></a>
                    <a href="info.aspx?id=1" target="_blank" runat="server" id="info1" class="list-group-item"></a>
                    <a href="info.aspx?id=2" target="_blank" runat="server" id="info2" class="list-group-item"></a>
                    <a href="info.aspx?id=3" target="_blank" runat="server" id="info3" class="list-group-item"></a>
                    <a href="info.aspx?id=4" target="_blank" runat="server" id="info4" class="list-group-item"></a>
                    <a href="info.aspx?id=5" target="_blank" runat="server" id="info5" class="list-group-item"></a>
                </div>
            </div>
            <!--right_block end-->
        </div>
        <!--class = row end-->
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
</asp:Content>