<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="study4-2.aspx.cs" Inherits="WebApplication1.study4_2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <link href="css/study3.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <input id="temp" type="text" runat="server" style="display:none;" />   <%--以后给加上个display：none  只是传值用的；--%>
    <div id="container" runat="server">
        <div id="head" class="effect" runat="server" style="text-align: center; line-height: 70px; font-size: 19px;">
            第四关.第二问思路探索：您已用时<label id="time0" style="width: 25px;">0</label>时<label id="time1" style="width: 25px;">0</label>分<label id="time2" style="width: 25px;">0</label>秒
        </div>
        <div id="left" class="effect" runat="server">
            <div id="ps0" runat="server"></div>
            <div id="ps1" runat="server" style="display: none"></div>
            <div id="ps2" runat="server" style="display: none"></div>
            <div id="ps3" runat="server" style="display: none"></div>
            <div id="ps4" runat="server" style="display: none"></div>
        </div>
        <div id="middle1" class="effect" runat="server">
            <%--1--%>
            <span id="tip1" runat="server"></span>
            <span id="goal1" class="icon-comment"></span>
            <span id="g1" style="display: none">
                <span id="goal1_text" runat="server"></span>
            </span>
            <span id="task1" class="icon-question-sign task" style="display: none"></span>
            <br />
            <%--2--%>
            <span id="tip2" runat="server"></span>
            <span id="goal2" class="icon-comment" style="display: none"></span>
            <span id="g2" style="display: none">
                <span id="goal2_text" runat="server"></span>
            </span>
            <span id="task2" class="icon-question-sign task" style="display: none"></span>
            <br />
            <%--3--%>
            <span id="tip3" runat="server"></span>
            <span id="goal3" class="icon-comment" style="display: none"></span>
            <span id="g3" style="display: none">
                <span id="goal3_text" runat="server"></span>
            </span>
            <span id="task3" class="icon-question-sign task" style="display: none"></span>
            <br />
            <%--4--%>
            <span id="tip4" runat="server"></span>
            <span id="goal4" class="icon-comment" style="display: none"></span>
            <div id="g4" style="display: none"><span id="goal4_text" runat="server"></span></div>
            <span id="task4" class="icon-question-sign class" style="display: none"></span>
            <br />
            <input id="lijie" type="button" class="btn btn-default btn-lg" value="点击查看理解题目结果" />

        </div>
        <form runat="server">
            <div id="right" class="effect" runat="server">
                <asp:radiobuttonlist id="resultsel" runat="server" datatextfield="selection" repeatdirection="Horizontal" repeatcolumns="2"></asp:radiobuttonlist>
                <br />
                <br />
                <asp:radiobuttonlist id="zhuangtaisel" runat="server" datatextfield="statusoptions" repeatdirection="Horizontal" repeatcolumns="2"></asp:radiobuttonlist>
                <br />
                <br />
                <asp:radiobuttonlist id="formulasel" runat="server" datatextfield="formula" repeatdirection="Horizontal" repeatcolumns="2"></asp:radiobuttonlist>
                <br />
                <br />
                <asp:radiobuttonlist id="kejiesel" runat="server" datatextfield="text" repeatdirection="Horizontal" repeatcolumns="2"></asp:radiobuttonlist>
                <input id="Button" class="btn btn-default btn-lg" type="button" value="提示" />
                <input id="Button2" class="btn btn-default btn-lg" type="button" value="取消提示" />



            </div>
        </form>
        <div id="left1" class="effect" runat="server">
        </div>
        <div id="middle3" class="effect">
            任务结果：<br />
            <div id="result1" runat="server" style="display: none"></div>
            <div id="result2" runat="server" style="display: none"></div>
            <div id="result3" runat="server" style="display: none">
                选取状态或过程:  
                <span id="szhuangtai" runat="server"></span>
                <br />
                选取含有未知量的公式或规律: 
                <span id="sformula" runat="server"></span>
                <br />
                选择推理得出的关系式 :
                <span id="sguanxi" runat="server"></span>
                <br />
                判断是否可解  :
                <span id="skejie" runat="server"></span>
                <br />
            </div>
            <div id="result4" runat="server" style="display: none"></div>

            <input id="yes" class="btn btn-default" type="button" value="确定" />
            <input class="btn btn-default" id="complete" type="button" value="完成本关"/><%-- 应该有display：none的 --%>
        </div>
    </div>




</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
    <script type="text/javascript" src="js/study4-2.js"></script>
    <script type="text/javascript">
     
        t5 = '<%=tips5("") %>';
        t6 = '<%=tips6("") %>';
        t7 = '<%=tips7("") %>';
        t8 = '<%=tips8("") %>';
    </script>
    <script type="text/x-mathjax-config">
  MathJax.Hub.Config({
    extensions: ["tex2jax.js"],
    jax: ["input/TeX","output/HTML-CSS"],
    tex2jax: {inlineMath: [["$","$"],["\\(","\\)"]]}
  });
    </script>
    <script type="text/javascript" src="MathJax/MathJax.js"></script>
</asp:Content>
