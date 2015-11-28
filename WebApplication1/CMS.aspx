<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="CMS.aspx.cs" Inherits="WebApplication1.CMS1" validateRequest="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <title>CMS后台管理</title>
    <link href="xheditor/demos/common.css" rel="stylesheet" />
    <style type="text/css">
        #ContentPlaceHolderMain_submit {
            display: none;
        }

        body {
            /*在这页面特地添加，因为globle的paddin-top被xheditor的css给覆盖掉了*/
            padding-top: 70px;
            /*xheditor的css更改了标题的font-size，特地改一下*/
            font-size:14px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form id="form1" runat="server">
        <div id="container" style="position: relative; left: 10%; width: 80%; height: auto; border: 1px solid #ddd;">
            <h1 style="text-align: center">上传最新新闻</h1>
            <label>标题：</label>
            <input class="submit" id="title" type="text" runat="server" /><br />
            <label style="display: inline">内容：</label>
            <textarea id="elm1" name="elm1" rows="12" cols="80" style="width: 80%;" class="xheditor" runat="server">
        </textarea><br />
            <asp:button id="submit" runat="server" text="上传" onclick="submit_Click" /><br />
            <label>版块：</label>
            <select id="part" runat="server">
                <option value="-1">--选择一个版块--</option>
                <option value="news">最新新闻</option>
                <option value="info">最新资讯</option>
            </select><br />
            <button id="test">点我上传</button>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
    <script type="text/javascript" src="xheditor/jquery/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="xheditor/xheditor.js"></script>
    <script type="text/javascript" src="xheditor/xheditor_lang/zh-cn.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#test").click(function () {
                if ($("#ContentPlaceHolderMain_title").val() == '' || $("#ContentPlaceHolderMain_elm1").val() == '' || $("select").val() == '-1') {
                    alert("信息没填写完全");
                } else {
                    $("#ContentPlaceHolderMain_submit").click();
                }
            });
        });
    </script>
</asp:Content>
