<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CategoryPage.aspx.cs" Inherits="GiaPhuc.Pages.CategoryPage" %>
    
<%@ Register Src="~/Controls/UCProductCategory.ascx" TagName="ProductCategory" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="products">
        <!-- The New Products -->
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <uc:productcategory id="ucProductCategory" runat="server" categoryname='<%#DataBinder.Eval(Container.DataItem, "Name") %>'
                    categoryurl='<%#DataBinder.Eval(Container.DataItem, "Url") %>' datasource='<%# DataBinder.Eval(Container.DataItem, "Products") %>' />
            </ItemTemplate>
        </asp:Repeater>
        <div class="clear">
        </div>
    </div>
    <script type="text/javascript">
        jQuery("img").lazy();
    </script>
</asp:Content>
