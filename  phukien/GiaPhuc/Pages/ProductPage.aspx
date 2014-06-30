<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProductPage.aspx.cs" Inherits="GiaPhuc.Pages.ProductPage" %>

<%@ Register Src="~/Controls/UCProductCategory.ascx" TagName="ProductCategory" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <%= WebExtensions.CombresLink("productCss") %>  
    <%= WebExtensions.CombresLink("productJs") %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="padding: 5px; width: 100%">
        <div style="padding: 5px; font-size: 10pt; font-weight: 300; width: 100%;">
            <div style="float: left" class="clearfix">
                <div class="clearfix">
                    <asp:HyperLink ID="linkProductImage" CssClass="jqzoom" runat="server">
                        <asp:Image ID="ProductImage" runat="server" Width="197px" AlternateText="phu kien ipad, iphone" />
                    </asp:HyperLink>
                </div>
            </div>
            <div style="float: left;">
                <div style="color: rgb(35, 86, 109); padding: 10px; font-size: 12pt; font-weight: bold;">
                    <asp:Label ID="lblProductCode" runat="server"></asp:Label>
                </div>
                <div style="color: #686767; padding: 10px;">
                    <asp:Label ID="lblProductName" runat="server"></asp:Label>
                </div>
                <div style="color: #686767; padding: 10px;">
                    <asp:Label ID="lblManufacturers" runat="server"></asp:Label>
                </div>
                <div style="padding: 10px; margin-top: 10px">
                    <div style="float: left; margin-right: 15px;">
                        Giá bán tại cửa hàng:</div>
                    <div style="color: red; float: left; font-weight: bold; font-size: 15pt; width: 160px;
                        text-align: center;">
                        <asp:Label ID="lblPrice" runat="server"></asp:Label>
                    </div>
                    <div style="margin-left: 20px; float: left;">
                        <asp:HyperLink ID="hypBuy" runat="server" Text="<span>Mua ngay</span>" CssClass="button" />
                    </div>
                </div>
            </div>
        </div>
        <div style="clear: both">
        </div>
        <div id="usual1" class="usual">
            <ul>
                <li><a href='#tab1' class="selected">MÔ TẢ SẢN PHẨM</a></li>
                <li><a href='#tab2'>THÔNG TIN KỸ THUẬT</a></li>
            </ul>
            <div id="tab1">
                <span style="padding: 5px;" id="divProductInstruction" runat="server"></span>
            </div>
            <div id="tab2">
                <span style="padding: 5px;" id="divProductImages" runat="server"></span>
            </div>
        </div>
        <div style="text-align: center; margin-top: 10px">
            <asp:HyperLink ID="linkBuy" runat="server" Text="<span>Mua ngay</span>" CssClass="button" />
        </div>
        <div style="margin-top: 3px">
            <a href='<asp:Literal runat="server" Text="<%$Resources:Resources, BackLink%>" />'
                class="backtohome">Trở về trang chủ</a> <a href="#" class="backtotop">Lên đầu trang</a>
        </div>
    </div>
    <div class="clear">
    </div>
    <uc:ProductCategory ID="dtlProducts" runat="server" CategoryName="Sản phẩm cùng loại" />
</asp:Content>
