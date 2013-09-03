<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="GiaPhuc.Default" %>

<%@ Register Src="~/Controls/UCProductCategory.ascx" TagName="ProductCategory" TagPrefix="uc" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script src="/Scripts/jquery.carouFredSel-6.2.1-packed.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#siteMapPath').hide();
            $(".box-categories").carouFredSel();
        });
    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="products">
        <!-- The New Products -->
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <uc:ProductCategory ID="ucProductCategory" runat="server" CategoryName='<%#DataBinder
                                                                                                   .
                                                                                                   Eval
                                                                                                   (Container
                                                                                                        .
                                                                                                        DataItem,
                                                                                                    "Name") %>'
                    DataSource='<%#                DataBinder.Eval(Container.DataItem, "Products") %>' />
            </ItemTemplate>
        </asp:Repeater>
        <div class="clear">
        </div>
    </div>
</asp:Content>
