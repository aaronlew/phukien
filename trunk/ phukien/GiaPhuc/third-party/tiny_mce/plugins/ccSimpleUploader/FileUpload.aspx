<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="TinyMCEeditor.tiny_mce.plugins.ccSimpleUploader.FileUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript" src="../../tiny_mce_popup.js"></script>

    <script type="text/javascript" src="editor_plugin.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        File Name:
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" /><br />
        <br />
        <asp:Button ID="uploadButton" runat="server" OnClick="uploadButton_Click" OnClientClick="document.getElementById('progress_div').style.visibility='visible';"
            Text="Upload File" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <div id="progress_div" style="visibility: hidden;">
            <img src="/Scripts/tiny_mce/plugins/ccSimpleUploader/progress.gif" alt="wait..."
                style="padding-top: 5px;" /></div>
        <asp:Image ID="image" runat="server" />
    </div>
    </form>
</body>
</html>
