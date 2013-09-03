<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.master" AutoEventWireup="true" Inherits="GiaPhuc.Admin.Pages.Pages_ProductManager" Codebehind="ProductManager.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">

    <script src="/Admin/Scripts/jsProduct.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div style="border: 1px solid #000; width: 100%">
        <a href="/Admin/Pages/ProductEntry.aspx" class="button">Add New</a>
    </div>
    <div class="clear"></div>
    <div id="gridProduct">
    </div>
</asp:Content>
