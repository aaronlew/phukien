<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true"
    CodeBehind="PageManager.aspx.cs" Inherits="GiaPhuc.Admin.PageManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="/content/smartpaginator.css" rel="stylesheet" type="text/css" />

    <script src="/Scripts/jquery-jtemplates.js" type="text/javascript"></script>

    <script src="/Scripts/smartpaginator.js" type="text/javascript"></script>

    <script src="/Admin/Scripts/jsPage.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <a href="PageEntry.aspx">Tạo mới</a>
    <div id="page">
    </div>
    <div id="black" style="margin: auto;">
    </div>
</asp:Content>
