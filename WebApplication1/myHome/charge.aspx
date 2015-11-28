<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="charge.aspx.cs" Inherits="WebApplication1.charge" %>

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
    <div>
    <h1>在线支付</h1>
    </div>
        <div style="padding-right:30px">
            <ul>
                <li>请输入充值金额:
                <asp:TextBox ID="recharge" runat="server"></asp:TextBox></li>
                <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 备注：<asp:textbox id="remark" runat="server"></asp:textbox></li>

            </ul>
            <asp:Button ID="_submit" runat="server" Text="去网银充值" OnClick="_submit_Click" />
            <div>
                <ul>
                    <li>相关说明：</li>
<li>1、在线支付适用于以下情况：</li>
<li>如果你已经通过简单学习网校客服咨询人员下订单订购课程，可以选择此方式支付。
跟简单学习网校有合作的个人、单位，在跟相关人员达成沟通后，可以通过此方式向简单学习网校支付相关金额。</li>
<li>2、通过本方式支付后将直接到达简单学习网校银行账户，所以请务必支付准确金额；一旦多付，差额不返还不累计。</li>
<li>3、支付成功后，将可以访问“学习中心”-“我的交易”-“支付历史”栏目，查看所有通过本页面支付的历史记录。</li>
                </ul>
            </div>
        </div>
    </form>
</body>
</html>
