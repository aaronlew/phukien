<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true"
    CodeBehind="TopicManager.aspx.cs" Inherits="GiaPhuc.Admin.TopicManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="/static/css/smartpaginator.css" rel="stylesheet" type="text/css" />

    <script src="/Scripts/jquery-jtemplates.js" type="text/javascript"></script>

    <script src="/Scripts/smartpaginator.js" type="text/javascript"></script>

    <script src="/Admin/Scripts/jsTopic.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <a target="_blank" href="/Admin/Pages/TopicEntry.aspx">Tạo mới</a>
    <div id="topic">
    </div>
    <div id="black" style="margin: auto;">
    </div>
</asp:Content>
