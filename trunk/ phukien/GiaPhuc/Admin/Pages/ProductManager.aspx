<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.master" AutoEventWireup="true"
    Inherits="GiaPhuc.Admin.Pages.Pages_ProductManager" CodeBehind="ProductManager.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <link href="/static/css/tabs.css" rel="stylesheet" type="text/css" />
    <link href="/static/css/smartpaginator.css" rel="stylesheet" type="text/css" />
    <script src="/Scripts/template/jquery-jtemplates.js" type="text/javascript"></script>
    <script src="/Scripts/template/smartpaginator.js" type="text/javascript"></script>
    <script src="/Admin/Scripts/vm/handler.js" type="text/javascript"></script>
    <script src="/Admin/Scripts/vm/product-vm.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="product-manager">
        <div id="tabs" class="invertedshiftdown">
            <ul>
                <li class="current"><a class="posted">Đã đăng<span id="countPosted"></span></a></li>
                <li><a class="deleted">Đã xóa<span id="countDeleted"></span></a></li>
            </ul>
        </div>
        <div>
            Từ khóa:
            <input type="text" id="keyword" />
        </div>
        <div class="command">
            <input type="button" value="Find" id="btnFind" class="ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only" />
        </div>
        <div class="clear">
        </div>
        <div id="divProductList">
        </div>
        <div id="pager" style="margin: auto; width: 99%;">
        </div>
        <div class="command">
            <input type="button" value="Undo" id="btnUndo" class="ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only" />
            <input type="button" value="Delete" id="btnDelete" class="ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only" />
        </div>
    </div>
</asp:Content>
