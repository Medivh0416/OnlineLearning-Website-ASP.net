<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upPic.aspx.cs" Inherits="WebApplication1.upPic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>图片上传和显示</title>
    <style type="text/css">
    .pic_text{ color:Red;}
    .pic_label { color:Gray; margin-top:5px; margin-bottom:5px;}
    .pic_image { margin:5px;}
        div
        {
            padding:5px
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>您上传的头像会自动生成三种尺寸，请注意小尺寸的头像是否清晰</h3>
    <div class="pic_image" style="float:left;padding-left:5px;height:200px;width:200px"><asp:Image ID="pic" runat="server" Height="200px" Width="200px"/></div>
        <div style="float:left;padding-left:10px;height:120px;width:120px"><asp:Image ID="pic_mid" runat="server" Height="120px" Width="120px"/></div>
        <div style="float:left;padding-left:10px;height:80px;width:80px"><asp:Image ID="pic_s" runat="server" Height="80px" Width="80px"/></div>
    </div>
    <div style="clear: both"></div>
        <div><y style="color:purple;border:medium;padding:5px">这个头像我不喜欢，我要换换</y><br />
            <y style="color:#808080;border:medium;padding:5px">从你的电脑中选择你喜欢的图片: </y>
    <div style="padding-top:5px"><asp:FileUpload ID="pic_upload" runat="server" /><asp:Label ID="lbl_pic" runat="server" class="pic_text"></asp:Label></div>
    <div class="pic_label">上传图片格式为.jpg, .gif, .bmp,.png,图片大小不得超过1M</div>
    <div><asp:Button ID="btn_upload" runat="server"  Text="上传" onclick="btn_upload_Click" style="height: 21px"/></div></div>
    </form>
  
</body>
</html>