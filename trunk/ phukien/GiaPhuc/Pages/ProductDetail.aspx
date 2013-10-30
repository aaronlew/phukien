<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProductDetail.aspx.cs" Inherits="GiaPhuc.Pages.ProductDetail" %>

<%@ Register Src="~/Controls/UCProductCategory.ascx" TagName="ProductCategory" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="/static/css/jquery.jqzoom.css" type="text/css" />
    <link rel="stylesheet" href="/static/css/tabify.css" type="text/css" />
    <script src="/Scripts/jquery-migrate-1.2.1.js" type="text/javascript"></script>
    <script src="/Scripts/jquery.jqzoom-core.js" type="text/javascript"></script>
    <script src="/Scripts/jquery.tabify.js" type="text/javascript"></script>
    <style type="text/css">
        .clearfix:after
        {
            clear: both;
            content: ".";
            display: block;
            font-size: 0;
            height: 0;
            line-height: 0;
            visibility: hidden;
        }
        
        .clearfix
        {
            display: block;
            zoom: 1;
        }
        
        
        ul#thumblist
        {
            display: block;
        }
        
        ul#thumblist li
        {
            float: left;
            margin-right: 2px;
            list-style: none;
        }
        
        ul#thumblist li a
        {
            display: block;
            border: 1px solid #CCC;
        }
        
        ul#thumblist li a.zoomThumbActive
        {
            border: 1px solid red;
        }
        
        .jqzoom
        {
            text-decoration: none;
            float: left;
        }
    </style>
    <script type="text/javascript">

        $(document).ready(function () {
            $('.jqzoom').jqzoom({
                zoomType: 'standard',
                lens: true,
                preloadImages: false,
                alwaysOn: false
            });

            $("#usual1 ul").idTabs();

            $('img').each(function () {
                if (this.offsetWidth > 620) {
                    $(this).width(620);
                }
            });
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="padding: 5px; width: 100%">
        <div style="padding: 5px; font-size: 10pt; font-weight: 300; width: 100%">
            <div style="float: left" class="clearfix">
                <div class="clearfix">
                    <asp:HyperLink ID="linkProductImage" CssClass="jqzoom" runat="server">
                        <asp:Image ID="ProductImage" runat="server" Width="197px" AlternateText="phu kien ipad, iphone" />
                    </asp:HyperLink>
                </div>
            </div>
            <div style="float: left; width: 497px">
                <div style="color: rgb(35, 86, 109); padding: 10px; font-size: 12pt; font-weight: bold;">
                    <asp:Label ID="lblProductCode" runat="server"></asp:Label>
                </div>
                <div style="color: #686767; padding: 10px;">
                    <asp:Label ID="lblProductName" runat="server"></asp:Label>
                </div>
                <div style="color: #686767; padding: 10px;">
                    <asp:Label ID="lblManufacturers" runat="server"></asp:Label>
                </div>
                <div style="padding: 10px">
                    <div style="color: red; float: left">
                        <asp:Label ID="lblPrice" runat="server"></asp:Label>
                    </div>
                </div>
                <div style="padding: 10px; margin-top: 30px">
                    <asp:HyperLink ID="hypBuy" runat="server" Text="Mua hàng" CssClass="button" />
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
        <div style="margin-top: 3px">
            <a href='<asp:Literal runat="server" Text="<%$Resources:Resources, BackLink%>" />'
                class="backtohome">Trở về trang chủ</a> <a href="#" class="backtotop">Lên đầu trang</a>
        </div>
    </div>
    <uc:ProductCategory ID="dtlProducts" runat="server" CategoryName="Sản phẩm cùng loại" />
</asp:Content>
