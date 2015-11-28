<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="study5.aspx.cs" Inherits="WebApplication1.study5t" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <link type="text/css" href="css/css.css" rel="stylesheet" />
    <link type="text/css" href="css/study5.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <input id="temp" type="text" runat="server" style="display:none;" />   <%--以后给加上个display：none  只是传值用的；--%>
    <div class="container">
        <form id="form" runat="server">
            <div id="head" class="effect" runat="server" style="text-align: center; line-height: 70px; font-size: 23px;">
                第五关：规范表达&nbsp;&nbsp;&nbsp;&nbsp;

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;您已用时<label id="time1" style="width: 25px;">0</label>分<label id="time2" style="width: 25px;">0</label>秒               
            </div>
            <div id="menu" class="effect" runat="server">
                <div id="obtain">
                    <div style="font-size: 23px">
                        获取原题
                        <span class="icon-heart get"></span>
                    </div>
                    <div id="get" runat="server"></div>
                </div>
            </div>
            <div id="content" class="effect" style="height:180px">
                <div style="font-size: 23px">
                    获取规范表达内容与步骤得分
                    <span class="icon-heart score" style="display: none"></span>
                    <div id="biaoda" runat="server" style="font-size:13px"></div>
                </div>
     
            <div id="score" runat="server" style="display: none"></div>
            </div>
            <div id="bottom" class="effect" runat="server">
                <input type="button" class="btn btn-primary btn-sm" id="complete" value="完成本关" /><%-- 应该有display：none的 --%>
                <asp:Button ID="save" class="btn btn-primary btn-sm" runat="server" Text="保存记录" OnClick="save_Click1" />
                <a id="over"></a>
            </div>   
        </form>        
            </div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
    <script src="js/study5.js" type="text/javascript"></script>
 <script type="text/javascript">
        $(document).ready(function () {
            i = 0;
            si = setInterval(function () {
                { $("#time1").html(Math.floor(i / 60)), $("#time2").html(i++ % 60) };
            }, 1000);
            $("#btn").on("click", function () {                    //不知道为什么 .click(clearInterval(si);)不能用。 只能用on绑定。
                clearInterval(si);
                alert("用时" + Math.floor(i / 60) + "分" + i % 60 + "秒");
            });
        });
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
