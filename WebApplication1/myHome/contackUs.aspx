<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contackUs.aspx.cs" Inherits="WebApplication1.myHome.contackUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link type="text/css" href="~/css/bootstrap.min.css" rel="stylesheet" />
    <link type="text/css" href="~/css/sticky-footer-navbar.css" rel="stylesheet"/>
    <link type="text/css" href="~/css/global.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
    <div id="contack">
    <h1>联系我们</h1>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:MultiView ID="mv_form" runat="server" ActiveViewIndex="0">
                    <asp:View ID="v_input" runat="server">
                        <span>姓名：</span><br />
                        <asp:TextBox ID="tb_name" runat="server"></asp:TextBox><br />
                        <span>联系电话：</span><br />
                        <asp:TextBox ID="tb_tel" runat="server"></asp:TextBox><br />
                        <span>留言：</span><br />
                        <asp:TextBox ID="tb_word" runat="server" TextMode="MultiLine"
                            rows="7" Columns="60"></asp:TextBox><br />
                        <hr />
                        <asp:Button ID="submit" runat="server" Text="确定" OnClick="submit_Click" />
                        <asp:Button ID="re" runat="server" Text="清除内容" />
                    </asp:View>
                    <asp:View ID="v_success" runat="server">
                        <h4>您的建议已经提交，我们会尽快处理</h4>
                    </asp:View>
                </asp:MultiView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
