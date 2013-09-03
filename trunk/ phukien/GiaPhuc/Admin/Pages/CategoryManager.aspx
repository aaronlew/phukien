<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true" CodeBehind="CategoryManager.aspx.cs" Inherits="GiaPhuc.Admin.Pages.CategoryManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="/static/css/smartpaginator.css" rel="stylesheet" type="text/css" />

    <script src="/Scripts/jquery-jtemplates.js" type="text/javascript"></script>

    <script src="/Scripts/smartpaginator.js" type="text/javascript"></script>

    <script src="/Admin/Scripts/jsCategory.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <a class="btnNew" href="/Admin/Pages/CategoryEntry.aspx">Tạo mới</a>
    <div id="category">
    </div>
    <div id="black" style="margin: auto;">
    </div>
</asp:Content>
