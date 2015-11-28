<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="msboard.aspx.cs" Inherits="WebApplication1.msboard1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <style type="text/css">
        body {
            padding-top:50px;
            padding-bottom:0;
        }

        .row div {
            padding: 0;
        }
            .row div a {
                display: block;
                height: 238px;
                font-size: 30px;
                font-weight: bolder;
                text-align: center;
                line-height: 238px;
                color: #fff;
                opacity: 0.8;
                transition: opacity 0.3s ease;
            }

                .row div a:hover, .row div a:focus {
                    text-decoration: none;
                    opacity: 1;
                }
        

        .block0 {
            background-color: #2AB8AC;
        }

        .block1 {
            background-color: #FFAB52;
        }

        .block2 {
            background-color: #CCE033;
        }

        .block3 {
            background-color: #9C55A5;
        }

        .block4 {
            background-color: #57CADD;
        }

        .block5 {
            background-color: #FFF68D;
            color: #000!important;
        }
        /*.bgw {
            opacity:1!important;
             height: 238px;
                font-size: 30px;
                font-weight: bolder;
                text-align: center;
                line-height: 238px;
                color: #fff;
                opacity: 0.8;
                font-size:140px;
                color:#000;
        }*/
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="container">
        <div class="row">
            <h1 class="glyphicon glyphicon-remove"></h1>
            <div class="col-sm-4">
                <%--<div class="block0 bgw">奇</div>--%>
                <%--<div class="block1 bgw">画</div>--%>
                <a href="#" class="block0">奇思妙想与一题多解</a>
                <a href="#" class="block1">画龙点睛</a>
            </div>
            <div class="col-sm-4">
                <%--<div class="block2 bgw">答</div>--%>
                <%--<div class="block3 bgw">库</div>--%>
                <a href="#" class="block2">有问有答</a>
                <a href="#" class="block3">我的题库</a>
            </div>
            <div class="col-sm-4">
                <%--<div class="block4 bgw">友</div>--%>
                <%--<div class="block5 bgw">e</div>--%>
                <a href="#" class="block4">用户心声与同省题友</a>
                <a href="#" class="block5">e题留学</a>
            </div>

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">

    </asp:Content>
