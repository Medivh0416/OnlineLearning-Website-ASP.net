<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="study3.aspx.cs" Inherits="WebApplication1.study3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">

    <%--<link type="text/css" href="css/css.css" rel="stylesheet" />--%>
    <link type="text/css" href="css/study3.css" rel="stylesheet" />
    <style type="text/css">
        #right1 table {
            margin: 10px 0;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <input id="temp" type="text" runat="server" style="display:none;" />   <%--以后给加上个display：none  只是传值用的；--%>
    <div id="container">
        <div id="head" runat="server" class="effect" style="text-align: center; line-height: 70px; font-size: 19px;">
            第三关：构建物体运动模型，分析研究对象的运动性质，并画出示意图：您已用时<label id="time0" style="width: 25px;">0</label>时<label id="time1" style="width: 25px;">0</label>分<label id="time2" style="width: 25px;">0</label>秒
             &nbsp能力值：<label id="ability">
                 <img alt="" id="heart1" src="images/heart215.png" style="display: none" />
                 <img alt="" id="heart2" src="images/heart217.png" style="display: none" />
                 <img alt="" id="heart3" src="images/heart215.png" style="display: none" />
                 <img alt="" id="heart4" src="images/heart217.png" style="display: none" />
                 <img alt="" id="heart5" src="images/heart215.png" style="display: none" />
                 <img alt="" id="heart6" src="images/heart217.png" style="display: none" />
                 <img alt="" id="heart7" src="images/heart215.png" style="display: none" />
                 <img alt="" id="heart8" src="images/heart217.png" style="display: none" />
                 <img alt="" id="heart9" src="images/heart215.png" style="display: none" />
                 <img alt="" id="heart10" src="images/heart217.png" style="display: none" />
             </label>
        </div>
        <div id="left" class="effect" runat="server">
        </div>
        <div id="middle1" class="effect">
            <table>
                <tr>
                    <td>
                        <%--<input type="image" src="images/20080521135018278.gif" id="st1" />--%>
                        <span id="st1" class="icon-heart"></span>
                        <span id="state1">状态Ⅰ</span>
                    </td>
                    <td id="xianshi">
                        <%--<input type="image" class="task" src="images/20080521135018556.gif" />--%>
                        <span class="icon-question-sign task" id="task1"></span>
                        <span class="icon-question-sign task2" id="task1_1" style="display: none"></span>
                        <span style="display: none" id="z1">
                            <asp:label id="m2v1" runat="server" text="速度"></asp:label>
                            <asp:label id="m2dx1" runat="server" text=""></asp:label>
                            (
            <asp:label id="m2tj1" runat="server" text=""></asp:label>
                            )
               
                    <asp:label id="m2fx1" runat="server" text=""></asp:label>
                            (
            <asp:label id="m2yj1" runat="server" text=""></asp:label>
                            )
                        </span>
                    </td>
                </tr>
                <tr>

                    <td style="display: none" id="z1a">
                        <%--<input type="image" class="task" src="images/20080521135018556.gif" />--%>
                        <span class="icon-question-sign task3"></span>
                        <asp:label id="m2a1" runat="server" text="加速度"></asp:label>
                        <asp:label id="m2dxa" runat="server" text=""></asp:label>
                        (
                    <asp:label id="m2tja" runat="server" text=""></asp:label>
                        )
            <asp:label id="m2fxa" runat="server" text=""></asp:label>
                        (
                    <asp:label id="m2yja" runat="server" text=""></asp:label>
                        )
                    </td>
                </tr>
                <tr>
                    <td>
                        <%--<input type="image" id="st2b" src="images/20080521135018278.gif"/>--%>
                        <span id="st2b" class="icon-heart"></span>
                        <span id="state2b">状态Ⅱ前</span>
                    </td>
                    <td>
                        <%--<input type="image" class="task" src="images/20080521135018556.gif" />--%>
                        <span class="icon-question-sign task" id="task2" style="display: none"></span>
                        <a id="z2v" style="display: none">
                            <asp:label id="m2v2" runat="server" text="速度"></asp:label>

                            <asp:label id="m2dx2" runat="server" text=""></asp:label>
                            (
            <asp:label id="m2tj2" runat="server" text=""></asp:label>
                            )               
                    <asp:label id="m2fx2" runat="server" text=""></asp:label>
                            (
            <asp:label id="m2yj2" runat="server" text=""></asp:label>
                            )
                        </a>
                    </td>
                </tr>
                <tr>
                    <td style="display: none" id="z2a">
                        <%--<input type="image" class="task" src="images/20080521135018556.gif" />--%>
                        <span class="icon-question-sign task"></span>
                        <asp:label id="m2a2" runat="server" text="加速度"></asp:label>
                        <asp:label id="m2dxa2" runat="server" text=""></asp:label>
                        (
                    <asp:label id="m2tja2" runat="server" text=""></asp:label>
                        )
            <asp:label id="m2fxa2" runat="server" text=""></asp:label>
                        (
                    <asp:label id="m2yja2" runat="server" text=""></asp:label>
                        )
                    </td>
                </tr>
                <tr>
                    <td>
                        <%--<input type="image" id="st2" src="images/20080521135018278.gif"/>--%>
                        <span id="st2" class="icon-heart"></span>
                        <span id="state2">状态Ⅱ</span></td>
                    <td>
                        <%--<input type="image" class="task" src="images/20080521135018556.gif" />--%>
                        <span class="icon-question-sign task" id="task3" style="display: none"></span>
                        <a id="z2_1v" style="display: none">
                            <asp:label id="m2v2_1" runat="server" text="速度"></asp:label>

                            <asp:label id="m2dx2_1" runat="server" text=""></asp:label>
                            (
            <asp:label id="m2tj2_1" runat="server" text=""></asp:label>
                            )
               
                    <asp:label id="m2fx2_1" runat="server" text=""></asp:label>
                            (
            <asp:label id="m2yj2_1" runat="server" text=""></asp:label>
                            )
                        </a>
                    </td>
                </tr>
                <tr>
                    <td style="display: none" id="z2_1a">
                        <%--<input type="image" class="task" src="images/20080521135018556.gif" />--%>
                        <span class="icon-question-sign task"></span>
                        <asp:label id="m2a2_1" runat="server" text="加速度"></asp:label>
                        <asp:label id="m2dxa2_1" runat="server" text=""></asp:label>
                        (
                    <asp:label id="m2tja2_1" runat="server" text=""></asp:label>
                        )
            <asp:label id="m2fxa2_1" runat="server" text=""></asp:label>
                        (
                    <asp:label id="m2yja2_1" runat="server" text=""></asp:label>
                        )
                    </td>
                </tr>
                <tr>
                    <td>
                        <%--<input type="image" id="st3" src="images/20080521135018278.gif"/>--%>
                        <span id="st3" class="icon-heart"></span>
                        <span id="state3">状态Ⅲ</span></td>
                    <td>
                        <%--<input type="image" class="task" src="images/20080521135018556.gif" />--%>
                        <span class="icon-question-sign task" id="task4" style="display: none"></span>
                        <a id="z3v" style="display: none">
                            <asp:label id="m2v3" runat="server" text="速度"></asp:label>

                            <asp:label id="m2dx3" runat="server" text=""></asp:label>
                            (
            <asp:label id="m3tj3" runat="server" text=""></asp:label>
                            )
               
                    <asp:label id="m2fx3" runat="server" text=""></asp:label>
                            (
            <asp:label id="m2yj3" runat="server" text=""></asp:label>
                            )
                        </a>
                    </td>
                </tr>
                <tr>
                    <td style="display: none" id="z3a">
                        <%--<input type="image" class="task" src="images/20080521135018556.gif" />--%>
                        <span class="icon-question-sign task"></span>
                        <asp:label id="m2a3" runat="server" text="加速度"></asp:label>
                        <asp:label id="m2dxa3" runat="server" text=""></asp:label>
                        (
                    <asp:label id="m2tja3" runat="server" text=""></asp:label>
                        )
            <asp:label id="m2fxa3" runat="server" text=""></asp:label>
                        (
                    <asp:label id="m2yja3" runat="server" text=""></asp:label>
                        )
                    </td>
                </tr>
                <tr>
                    <td>
                        <%--<input type="image" id="pro1" src="images/20080521135018278.gif" />--%>
                        <span id="pro1" class="icon-heart"></span>
                        <span id="process1">过程1</span></td>
                    <td id="m2gc1" style="display: none">火箭以加速度a1 做匀加速直线运动,位移为h=40m ,时间为t=4s .</td>
                </tr>
                <tr>
                    <td>
                        <%--<input type="image" id="pro2" src="images/20080521135018278.gif"/>--%>
                        <span id="pro2" class="icon-heart"></span>
                        <span id="process2">过程2</span>
                    </td>
                    <td id="m2gc2" style="display: none">火箭以加速度g 做匀减速直线运动,位移设为h1 ,时间设为t1 .</td>
                </tr>
            </table>
        </div>

        <form runat="server">
            <div id="right" class="effect">
                <div id="right1">

                    <asp:radiobuttonlist id="sop" runat="server" datatextfield="statusoptions" repeatdirection="Vertical" repeatcolumns="0">
                    <asp:ListItem></asp:ListItem>
                </asp:radiobuttonlist>
                    <table>
                        <tr>
                            <td>
                                <asp:radiobuttonlist id="dx" runat="server" datatextfield="tiaojian">
                                <asp:ListItem></asp:ListItem>
                            </asp:radiobuttonlist>
                            </td>
                            <td>
                                <asp:radiobuttonlist id="tj" runat="server" datatextfield="tiaojian">
                                <asp:ListItem>
                                </asp:ListItem>
                            </asp:radiobuttonlist>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:radiobuttonlist id="fx" runat="server" datatextfield="fangxiang">
                                <asp:ListItem></asp:ListItem>
                            </asp:radiobuttonlist>
                            </td>
                            <td>
                                <asp:radiobuttonlist id="yj" runat="server" datatextfield="yiju">
                                <asp:ListItem></asp:ListItem>
                            </asp:radiobuttonlist>
                            </td>
                        </tr>
                    </table>
                </div>
                <input id="Button" class="btn btn-default btn-lg" type="button" value="提示" />
                <input id="Button2" class="btn btn-default btn-lg" type="button" value="取消提示" />
            </div>
            <div id="left1" class="effect">
                理解题目结果：<br />
                1、研究对象：
        <span id="understand_yanjiuduixiang1" runat="server"></span>&nbsp&nbsp
        <span id="understand_yanjiuduixiang2" runat="server" style="color: red;"></span>
                <br />
                2、已知条件：
        <span id="understand_yizhitiaojian1" runat="server"></span>
                <br />
                <span id="understand_yizhitiaojian2" runat="server"></span>&nbsp&nbsp<span id="understand_yizhitiaojian21" runat="server" style="color: red"></span><br />
                <span id="understand_yizhitiaojian3" runat="server"></span>&nbsp&nbsp<span id="understand_yizhitiaojian31" runat="server" style="color: red"></span><br />
                <span id="understand_yizhitiaojian4" runat="server"></span>&nbsp&nbsp<span id="understand_yizhitiaojian41" runat="server" style="color: red"></span><br />
                <span id="understand_yizhitiaojian5" runat="server"></span>
                <br />
                3、已知量
        <span id="understand_yizhiliang" runat="server"></span>
                <br />
                4、未知量
        <span id="understand_weizhiliang1" runat="server"></span><span id="understand_weizhiliang11" runat="server" style="color: red"></span>
                <span id="understand_weizhiliang2" runat="server"></span><span id="understand_weizhiliang21" runat="server" style="color: red"></span>
                <br />
            </div>

            <div id="middle3" class="effect">
                任务结果：
                 <div id="change">
                     状态Ⅰ:<asp:label id="result" runat="server" text=""></asp:label><br />
                     <div id="middle3xianshi">
                         <table>
                             <tr>
                                 <td>速度
                                 </td>
                             </tr>
                             <tr>
                                 <td>大小</td>
                                 <td>【<asp:label id="resultdx" runat="server" text=""></asp:label>】 
                                 </td>
                             </tr>
                             <tr>
                                 <td>依据</td>
                                 <td>【<asp:label id="resulttj" runat="server" text=""></asp:label>】 
                                 </td>
                             </tr>
                             <tr>
                                 <td>方向</td>
                                 <td>【<asp:label id="resultfx" runat="server" text=""></asp:label>】 
                                 </td>
                             </tr>
                             <tr>
                                 <td>依据</td>
                                 <td>【<asp:label id="resultyj" runat="server" text=""></asp:label>】 
                                 </td>
                             </tr>
                         </table>
                     </div>

                     <div id="a1" style="display: none">
                         <table>
                             <tr>
                                 <td>加速度
                                 </td>
                                 <td>大小</td>
                                 <td>【<asp:label id="resultdxa" runat="server" text=""></asp:label>
                                     】 
                                 </td>
                             </tr>
                             <tr>
                                 <td>依据</td>
                                 <td>【 
                            <asp:label id="resulttja" runat="server" text=""></asp:label>
                                     】 
                                 </td>
                             </tr>
                             <tr>
                                 <td>方向</td>
                                 <td>【
                            <asp:label id="resultfxa" runat="server" text=""></asp:label>
                                     】 
                                 </td>
                             </tr>
                             <tr>
                                 <td>依据</td>
                                 <td>【
                            <asp:label id="resultyja" runat="server" text=""></asp:label>
                                     】 
                                 </td>
                             </tr>

                         </table>
                     </div>
                 </div>
                <div id="change2" style="display: none">
                    状态II前:<asp:label id="result2" runat="server" text=""></asp:label><br />
                    <div id="middle3xianshi2" style="display: none">
                        <table>
                            <tr>
                                <td>速度
                                </td>
                            </tr>
                            <tr>
                                <td>大小</td>
                                <td>【<asp:label id="resultdx2" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                            <tr>
                                <td>依据</td>
                                <td>【<asp:label id="resulttj2" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                            <tr>
                                <td>方向</td>
                                <td>【<asp:label id="resultfx2" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                            <tr>
                                <td>依据</td>
                                <td>【<asp:label id="resultyj2" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div id="a2" style="display: none">
                        <table>
                            <tr>
                                <td>加速度</td>
                            </tr>
                            <tr>
                                <td>大小</td>
                                <td>【<asp:label id="rdxa2" runat="server" text=""></asp:label>】</td>
                            </tr>
                            <tr>
                                <td>依据</td>
                                <td>【<asp:label id="rtja2" runat="server" text=""></asp:label>】 </td>
                            </tr>
                            <tr>
                                <td>方向</td>
                                <td>【<asp:label id="rfxa2" runat="server" text=""></asp:label>】 </td>
                            </tr>

                            <tr>
                                <td>依据</td>
                                <td>【<asp:label id="ryja2" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>

                        </table>
                    </div>
                </div>
                <div id="change2_1" style="display: none">
                    状态II:<asp:label id="result2_1" runat="server" text=""></asp:label><br />
                    <div id="middle3xianshi2_1" style="display: none">
                        <table>
                            <tr>
                                <td>速度</td>
                            </tr>
                            <tr>
                                <td>大小</td>
                                <td>【<asp:label id="rdx2_1" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                            <tr>
                                <td>依据</td>
                                <td>【<asp:label id="rtj2_1" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                            <tr>
                                <td>方向</td>
                                <td>【<asp:label id="rfx2_1" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                            <tr>
                                <td>依据</td>
                                <td>【<asp:label id="ryj2_1" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div id="a2_1" style="display: none">
                        <table>
                            <tr>
                                <td>加速度
                                </td>
                            </tr>
                            <tr>
                                <td>大小</td>
                                <td>【<asp:label id="rdxa2_1" runat="server" text=""></asp:label>
                                    】 
                                </td>
                            </tr>
                            <tr>
                                <td>依据</td>
                                <td>【 
                            <asp:label id="rtja2_1" runat="server" text=""></asp:label>
                                    】 
                                </td>
                            </tr>
                            <tr>
                                <td>方向</td>
                                <td>【
                            <asp:label id="rfxa2_1" runat="server" text=""></asp:label>
                                    】 
                                </td>
                            </tr>
                            <tr>
                                <td>依据</td>
                                <td>【
                            <asp:label id="ryja2_1" runat="server" text=""></asp:label>
                                    】 
                                </td>
                            </tr>

                        </table>
                    </div>
                </div>
                <div id="change3" style="display: none">
                    状态III:<asp:label id="result3" runat="server" text=""></asp:label><br />
                    <div id="middle3xianshi3" style="display: none">
                        <table>
                            <tr>
                                <td>速度
                                </td>
                            </tr>
                            <tr>
                                <td>大小</td>
                                <td>【<asp:label id="rdx3" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                            <tr>
                                <td>依据</td>
                                <td>【<asp:label id="rtj3" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                            <tr>
                                <td>方向</td>
                                <td>【<asp:label id="rfx3" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                            <tr>
                                <td>依据</td>
                                <td>【<asp:label id="ryj3" runat="server" text=""></asp:label>】 
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div id="a3" style="display: none">
                        <table>
                            <tr>
                                <td>加速度
                                </td>
                            </tr>
                            <tr>
                                <td>大小</td>
                                <td>【<asp:label id="rdxa3" runat="server" text=""></asp:label>
                                    】 
                                </td>
                            </tr>
                            <tr>
                                <td>依据</td>
                                <td>【 
                       <asp:label id="rtja3" runat="server" text=""></asp:label>
                                    】 
                                </td>
                            </tr>
                            <tr>
                                <td>方向</td>
                                <td>【
                            <asp:label id="rfxa3" runat="server" text=""></asp:label>
                                    】 
                                </td>
                            </tr>

                            <tr>
                                <td>依据</td>
                                <td>【
                            <asp:label id="ryja3" runat="server" text=""></asp:label>
                                    】 
                                </td>
                            </tr>

                        </table>
                    </div>
                </div>
                <div id="guocheng1" style="display: none">
                    过程1
               <label id="gc1"></label>
                    火箭以加速度a1 做匀加速直线运动,位移为h=40m ,时间为t=4s .
                </div>
                <div id="guocheng2" style="display: none">
                    过程2
                <label id="gc2"></label>
                    火箭以加速度g 做匀减速直线运动,位移设为h1 ,时间设为t1 .
                </div>
                <input id="yes" class="btn btn-default" type="button" value="确定" />

                <input class="btn btn-default" id="complete" type="button" value="完成本关"/>   <%-- 应该有display：none的 --%>
            </div>
            <div style="clear: both"></div>
            </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
    <script type="text/javascript" src="js/study3.js"></script>
    <script type="text/javascript" src="MathJax/MathJax.js"></script>
    <script type="text/x-mathjax-config">
        MathJax.Hub.Config({
          TeX: { equationNumbers: { autoNumber: "AMS" } }
        });
    </script>
    <script type="text/javascript">
        t1 = '<%=tips1("") %>';
        t2 = '<%=tips2("")%>';
        t3 = '<%=tips3("")%>';
        t4 = '<%=tips4("")%>';
    </script>
</asp:Content>
