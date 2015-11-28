<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="study1.aspx.cs" Inherits="WebApplication1.study1t" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <link type="text/css" href="css/css.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <div id="head" class="effect" runat="server" style="text-align: center;">
                <div style="text-align: center; line-height: 70px; font-size: 23px;">
                    第一关 阅读题目&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;您已用时<label id="time0" style="width: 25px;">0</label>时<label id="time1" style="width: 25px;">0</label>分<label id="time2" style="width: 25px;">0</label>秒
                </div>
            </div>
            <div id="menu" class="effect" runat="server">
            </div>
            <div id="content" class="effect">
                <input class="btn btn-primary" id="complete" type="button" value="读题完成"/>
            </div>
           
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
    <script type="text/javascript" src="js/study1.js"></script>
    <script type="text/x-mathjax-config">
  MathJax.Hub.Config({
    extensions: ["tex2jax.js"],
    jax: ["input/TeX","output/HTML-CSS"],
    tex2jax: {inlineMath: [["$","$"],["\\(","\\)"]]}
  });
    </script>
    <script type="text/javascript" src="MathJax/MathJax.js"></script>

</asp:Content>

