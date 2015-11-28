<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="study2.aspx.cs" Inherits="WebApplication1.study2t" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <link type="text/css" href="css/study2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <input id="temp" type="text" runat="server" style="display:none;" />   <%--以后给加上个display：none  只是传值用的；--%>
    <div id="Div1" class="container" runat="server">
        <div id="head" class="effect" runat="server" style="text-align: center;">
            <div style="text-align: center; line-height: 70px; font-size: 23px;">
                第二关：重新表达&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;您已用时<label id="time0" style="width: 25px;">0</label>时<label id="time1" style="width: 25px;">0</label>分<label id="time2" style="width: 25px;">0</label>秒
            </div>
        </div>
        <div id="left" class="effect" runat="server"></div>
        <div id="middle" class="effect" runat="server">
            1、研究对象
            <span id="y" class="icon-heart"></span>
            <span id="duixiangx" style="display: none;"><span id="duixiang" runat="server"></span></span>
            <span id="xing" class="icon-comment" style="display: none;"></span>
            <br />
            <%--已知条件--%>

            <span>2、已知条件:</span><br />
            <span id="yza" class="icon-heart" style="display: none;"></span>
            <span id="yizhiap" style="display: none"><span id="yizhia" runat="server"></span></span>
            <br />
            <span id="yzb" class="icon-heart" style="display: none;"></span>
            <span id="yizhibp" style="display: none"><span id="yizhib" runat="server"></span></span>
            <span id="task1" class="icon-question-sign task" style="display: none;"></span>
            <asp:label id="Label1" runat="server" text=""></asp:label>
            <br />

            <span id="yzc" class="icon-heart" style="display: none;"></span>
            <span id="yizhicp" style="display: none"><span id="yizhic" runat="server"></span></span>
            <span id="task2" class="icon-question-sign task" style="display: none;"></span>
            <asp:label id="Label2" runat="server" text=""></asp:label>
            <br />

            <span id="yzd" class="icon-heart" style="display: none;"></span>
            <span id="yizhidp" style="display: none"><span id="yizhid" runat="server"></span></span>
            <span id="task3" class="icon-question-sign task" style="display: none;"></span>
            <asp:label id="Label3" runat="server" text=""></asp:label>
            <br />
            <span id="yze" class="icon-heart" style="display: none;"></span>
            <span id="yizhiep" style="display: none"><span id="yizhie" runat="server"></span></span>
            <br />


            <span>3、已知量
                <span id="yzl" class="icon-heart" style="display: none;"></span>
            </span>

            <span style="display: none" id="yzlx"><span id="yizhiliang" runat="server"></span></span>
            <br />
            4、未知量:<br />
            <span id="wzl1" class="icon-heart" style="display: none;"></span>
            <span id="wzl1p" style="display: none;"><span id="weizhiliang" runat="server"></span></span>
            <br />
            <span id="task4" class="icon-question-sign" style="display: none;"></span>
            <asp:label id="Label4" runat="server" text=""></asp:label>
            <br />
            <span id="wzl2" class="icon-heart" style="display: none;"></span>
            <span id="wzl2p" style="display: none;"><span id="weizhiliang2" runat="server"></span></span>
            <br />
            <span id="task5" class="icon-question-sign" style="display: none;"></span>
            <asp:label id="Label5" runat="server" text=""></asp:label>
        </div>


        <form runat="server">
            <div id="right" class="effect" runat="server">
                <p>选项</p>
                <asp:radiobuttonlist id="select" runat="server" datatextfield="selection"></asp:radiobuttonlist>

                <input class="btn btn-primary btn-lg btn-block button1" type="button" value="提示" id="tishi" />
                <input class="btn btn-primary btn-lg btn-block button2" type="button" value="取消提示" id="quxiao" /><br />
            </div>

            <div id="foot" class="effect" runat="server">
                任务结果<br />
                <div id="result1" runat="server" style="display: none"></div>
                <div id="result2" runat="server" style="display: none"></div>
                <div id="result3" runat="server" style="display: none"></div>
                <div id="result4" runat="server" style="display: none"></div>
                <div id="result5" runat="server" style="display: none"></div>
                <input id="submit" class="btn btn-primary btn-sm" type="button" value="确定" />
                <div style="clear: both;"></div>
                <%--不可见的自适应div--%>
            </div>

            <div id="bottom" class="effect" runat="server">
                <input type="button" class="btn btn-primary" id="complete" value="完成本关" />   <%-- 应该有display：none的 --%> 
            </div>
           
            <asp:BulletedList ID="test" runat="server"></asp:BulletedList>
        </form>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
    <script type="text/javascript" src="js/study2.js"></script>
    <script type="text/x-mathjax-config">
  MathJax.Hub.Config({
    extensions: ["tex2jax.js"],
    jax: ["input/TeX","output/HTML-CSS"],
    tex2jax: {inlineMath: [["$","$"],["\\(","\\)"]]}
  });
    </script>
    <script type="text/javascript" src="MathJax/MathJax.js"></script>
    <script type="text/javascript">
        t1 = '<%=tips1("") %>';
        t2 = '<%=tips2("") %>';
        t3 = '<%=tips3("") %>';
        t4 = '<%=tips4("") %>';
        t5 = '<%=tips5("") %>';
        t6 = '<%=tips6("") %>';
    </script>
</asp:Content>
