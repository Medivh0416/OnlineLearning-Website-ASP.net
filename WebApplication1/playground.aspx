<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="playground.aspx.cs" Inherits="WebApplication1.playground" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <style type="text/css">
        body {
            padding-top: 70px;
            padding-bottom: 70px;
        }

        .shake-div {
            display: block;
            width: auto;
            height: 50px;
            position: relative;
            border: 3px solid black;
            background-color: #666;
            border-radius: 5px;
            text-align: center;
            font-size: large;
            font-weight: bold;
            line-height: 48px;
            color: gold;
            margin-bottom: 20px;
        }

            .shake-div:hover, .shake-div:focus {
                color: gold;
                text-decoration: none;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="container">
        <h1 class="text-center">智慧乐园</h1>
        <br />
        <p class="text-center" style="font-size:18px;">智力活动体验中心，此项目为线上免费、线下收费项目为学生多元智力发展提供丰富的载体、工具、方法、趣味游戏及交流平台</p>
        <br /><br /><br /><br />
        <div class="row">
            <div class="col-sm-4">
                <a href="http://www.baidu.com/baidu?wd=%CB%BC%CE%AC%B7%BD%B7%A8%BA%CD%B9%A4%BE%DF&tn=monline_dg" target="_blank" class="shake shake-slow shake-div">思维方法与工具</a>
                <a href="#" class="shake shake-rotate shake-div">逻辑常识</a>
            </div>
            <div class="col-sm-4">
                <a href="#" class="shake shake-horizontal shake-div">注意力测试与训练游戏</a>
                <a href="#" class="shake shake-vertical shake-div">数学与魔术</a>
            </div>
            <div class="col-sm-4">
                <a href="#" class="shake shake-little shake-div">世界经典益智游戏互动论坛</a>
                <a href="#" class="shake shake-crazy shake-div">智商情商测试</a>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">


    </asp:Content>

