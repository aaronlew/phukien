<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="GiaPhuc.Default" %>

<%@ Register Src="~/Controls/UCProductCategory.ascx" TagName="ProductCategory" TagPrefix="uc" %>
<%@ Register Src="~/Controls/ArticleLayout.ascx" TagName="ArticleLayout" TagPrefix="uc" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <%= WebExtensions.CombresLink("defaultJs") %>
    <script type="text/javascript">        $.fn.cycle.defaults.autoSelector = '.articles';</script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#siteMapPath').hide();
        });
    </script>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="TopContent">
    <asp:PlaceHolder ID="pnlPost" runat="server"></asp:PlaceHolder>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ArticleContent">
    <div id="articles">
        <uc:ArticleLayout ID="articleLayout" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="products">
        <!-- The New Products -->
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <uc:ProductCategory ID="ucProductCategory" runat="server" CategoryName='<%#DataBinder.Eval(Container.DataItem, "Name") %>'
                    CategoryUrl='<%#DataBinder.Eval(Container.DataItem, "Url") %>' DataSource='<%# DataBinder.Eval(Container.DataItem, "Products") %>' />
            </ItemTemplate>
        </asp:Repeater>
        <div class="clear">
        </div>
    </div>
</asp:Content>
