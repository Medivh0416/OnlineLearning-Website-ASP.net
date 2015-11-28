<%@ Page Title="" Language="C#" MasterPageFile="~/FrontUser.Master" AutoEventWireup="true" CodeBehind="upload.aspx.cs" Inherits="WebApplication1.upload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">

    <style type="text/css">
        .auto-style1 {
            /*width: 359px;*/
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form id="form1" runat="server">
        <div id="head" class="effect" runat="server" style="text-align: center; line-height: 70px; font-size: 19px;"></div>
        <h3 style="text-align: center;">题目录入</h3>
        <div class="container" runat="server">
            <table class="table" runat="server">
                <tr>
                    <td>题目：
                    </td>
                    <td>
                        <asp:TextBox ID="question" class="upLoad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>题目图片：
                    </td>
                    <td>
                        <asp:FileUpload ID="quespicup" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td>第二关：研究对象：
                    </td>
                    <td>
                        <asp:TextBox ID="yjdx" runat="server" class="upLoad" name="text"></asp:TextBox><br />
                        <button id="addyjdx" type="button" class="btn btn-info">添加研究对象</button>
                        <button id="delyjdx" type="button" class="btn btn-warning">删除研究对象</button><br />
                    </td>
                </tr>
                <tr>
                    <td>已知条件：
                    </td>
                    <td>
                        <asp:TextBox ID="yztj" runat="server" class="upLoad"></asp:TextBox><br />
                        <button id="addyztj" type="button" class="btn btn-info">添加已知条件</button>
                        <button id="delyztj" type="button" class="btn btn-warning">删除已知条件</button><br />
                    </td>
                </tr>
                <tr>
                    <td>已知量：
                    </td>
                    <td>
                        <asp:TextBox ID="yzl" runat="server" class="upLoad"></asp:TextBox>
                        <br />
                        <button id="addyzl" type="button" class="btn btn-info">添加已知量</button>
                        <button id="delyzl" type="button" class="btn btn-warning">删除已知量</button><br />
                    </td>
                </tr>
                <tr>
                    <td>未知量：
                    </td>
                    <td>
                        <asp:TextBox ID="wzl" runat="server" class="upLoad"></asp:TextBox><br />
                        <button id="addwzl" type="button" class="btn btn-info">添加未知量</button>
                        <button id="delwzl" type="button" class="btn btn-warning">删除未知量</button><br />
                    </td>
                </tr>
                <tr>
                    <td>任务：
                    </td>
                    <td>
                        <asp:TextBox ID="task" runat="server" class="upLoad"></asp:TextBox><br />
                        <button id="addtask" type="button" class="btn btn-info">添加任务</button>
                        <button id="deltask" type="button" class="btn btn-warning">删除任务</button><br />
                    </td>
                </tr>
                <tr>
                    <td>选项：
                    </td>
                    <td>
                        <asp:TextBox ID="selection" runat="server" class="upLoad"></asp:TextBox><br />
                        <button id="addselection" type="button" class="btn btn-info">添加选项</button>
                        <button id="delselection" type="button" class="btn btn-warning">删除选项</button><br />
                    </td>
                </tr>
            </table>

           <%-- <asp:button id="submit" runat="server" text="提交" onclick="submit_Click"/>--%>
            <button id="test">test</button>

        </div>


    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" runat="server">
    <script type="text/javascript" src="js/upload.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            $("#arr").on("click", function () {
                var array = new Array();
                for (var i = 0; i < $(".upLoad").length; i++) {
                    array.push($(".upLoad")[i].value);
                }
            });
        });

            $("#test").click(function () {
                $("#ContentPlaceHolderMain_submit").click();
            });
        
        

        //$(document).ready(function () {
            //$("#ContentPlaceHolderMain_submit").on('click', function () {
            //    var $inputLength = $(".upLoad").length;
            //    var $index = true;
            //    for (var i = 0; i < $inputLength; i++) {
            //        if ($(".upLoad")[i].value === "") {
            //            $index = false;
            //            break;
            //        };
            //    };
            //    if ($index) {
                    <%--"<%=submit_Click()%>";
//                   <%-- document.getElementById("test").onclick();
//            alert("上传完成(javascript)");
//        } else {
//            alert("信息还没填写完全(javascript)");
//        }
//    });
      
//});--%>

    </script>
    <%--<script type="text/javascript">
        //$(document).ready(function () {
            //$("#ContentPlaceHolderMain_submit").on('click', function () {
                //var $inputLength = $(".upLoad").length;
                //var $index = true;
                //for (var i = 0; i < $inputLength; i++) {
                   // if ($(".upLoad")[i].value === "") {
                        //$index = false;
                       // break;
                   // };
               // };
               // if ($index) {
                    //$("#ContentPlaceHolderMain_test").trigger('click');
        //} else {
           // alert("信息还没填写完全");
       // }
//    });
//});
    <%--</script>--%>
</asp:Content>
