<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true" CodeBehind="ManufacturerManager.aspx.cs" Inherits="GiaPhuc.Admin.Pages.ManufacturerManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="/static/css/smartpaginator.css" rel="stylesheet" type="text/css" />

    <script src="/Scripts/jquery-jtemplates.js" type="text/javascript"></script>

    <script src="/Scripts/smartpaginator.js" type="text/javascript"></script>

    <script src="/Admin/Scripts/jsManufacturer.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <a target="_blank" class="btnNew" href="/Admin/Pages/ManufacturerEntry.aspx">Tạo mới</a>
    <div id="manufacturer">
    </div>
    <div id="black" style="margin: auto;">
    </div>
</asp:Content>
