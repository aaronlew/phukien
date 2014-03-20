<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="GiaPhuc.Default" %>
    
<%@ Register Src="~/Controls/UCProductCategory.ascx" TagName="ProductCategory" TagPrefix="uc" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script type="text/javascript" src="/Scripts/jquery.cycle2.min.js" />
    <script type="text/javascript" src="/Scripts/jquery.cycle2.carousel.min.js" />
    <script type="text/javascript">
        $(document).ready(function () {
            $('#siteMapPath').hide();
        });
    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="products">
        <!-- The New Products -->
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <uc:ProductCategory ID="ucProductCategory" runat="server" 
                    CategoryName='<%#DataBinder.Eval(Container.DataItem, "Name") %>'
                    CategoryUrl='<%#DataBinder.Eval(Container.DataItem, "Url") %>'
                    DataSource='<%# DataBinder.Eval(Container.DataItem, "Products") %>' />
            </ItemTemplate>
        </asp:Repeater>
        <div class="clear">
        </div>
    </div>
</asp:Content>
