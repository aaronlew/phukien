<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeftLayout.ascx.cs"
    Inherits="GiaPhuc.Controls.LeftLayout" %>
<%@ Import Namespace="GiaPhuc.Utility" %>
<%@ Import Namespace="phukienipadx.Bl.Models" %>
<%@ Register Src="~/Controls/UCProductCell.ascx" TagName="ProductCell" TagPrefix="uc" %>
<%@ Register Src="~/Controls/AdvertiseLeftSide.ascx" TagName="AdvertiseLeftSide"
    TagPrefix="uc" %>
<script type="text/javascript">

    <!--
    /* google plus */
    window.___gcfg = {
        lang: 'vi-VN'
    };

    (function () {
        var po = document.createElement('script');
        po.type = 'text/javascript';
        po.async = true;
        po.src = 'https://apis.google.com/js/plusone.js';
        var s = document.getElementsByTagName('script')[0];
        s.parentNode.insertBefore(po, s);
    })();

    !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + '://platform.twitter.com/widgets.js'; fjs.parentNode.insertBefore(js, fjs); } } (document, 'script', 'twitter-wjs');

    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = "//connect.facebook.net/vi_VN/all.js#xfbml=1";
        fjs.parentNode.insertBefore(js, fjs);
    } (document, 'script', 'facebook-jssdk'));

</script>
<%--<div class="box-heading">
        LIÊN HỆ</div>--%>
<%--<ul class="info">
        <li><b style="color: blue">TPHCM:</b></li>
        <li>
            <asp:Literal runat="server" Text="<%$Resources:Resources, Address1 %>"></asp:Literal></li>
        <li class="center"><a href="ymsgr:sendim?lieumanhdat1981">
            <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=lieumanhdat1981&l=vi"
                title="Bao da ipad, pin dự phòng YOOBAO, phukienipadx.com"></img>
        </a></li>
        <li class="center bold">
            <asp:Literal ID="Literal2" runat="server" Text="<%$Resources:Resources, UserSupport1 %>"></asp:Literal></li>
        <li class="center"><a href="ymsgr:sendim?phukienipadx">
            <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=phukienipadx"
                title="Bao da ipad, pin dự phòng YOOBAO, phukienipadx.com" />
        </a></li>
        <li class="center bold">
            <asp:Literal ID="Literal3" runat="server" Text="<%$Resources:Resources, UserSupport2 %>"></asp:Literal></li>
        <li class="seperator"></li>
        <li><b style="color: red">Hà Nội:</b></li>
        <li>
            <asp:Literal ID="Literal1" runat="server" Text="<%$Resources:Resources, Address2 %>"></asp:Literal></li>
        <li class="center"><a href="ymsgr:sendim?nanganhbsg">
            <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=nanganhbsg&l=vi"
                title="Bao da ipad, pin dự phòng YOOBAO, phukienipadx.com" />
        </a></li>
        <li class="center bold">
            <asp:Literal ID="Literal4" runat="server" Text="<%$Resources:Resources, UserSupport3 %>"></asp:Literal></li>
        <li class="center"><span style="color: red; font-style: italic">Vui lòng gọi trước khi
            đến cửa hàng</span></li>
        <li class="clear"></li>
    </ul>--%>
<%--<div class="box-heading">
        THỐNG KÊ TRUY CẬP</div>--%>
<div>
    <uc:AdvertiseLeftSide ID="AdvertiseLeftSide1" runat="server" />
</div>
<!--<div class="box-heading" style="margin-left: 6px;">
    PHỤ KIỆN BÁN CHẠY</div>
<asp:Repeater ID="datDefault" runat="server">
    <HeaderTemplate>
        <div id="highlight-product" class="product-special info" style="margin-left: 6px;">
    </HeaderTemplate>
    <ItemTemplate>
        <uc:ProductCell ID="ucProductCell" runat="server" ProductClass='<%--#DataBinder.Eval(Container.DataItem, "ClassHot") + " " + DataBinder.Eval(Container.DataItem, "ClassNew")--%>'
            ProductCode='<%#DataBinder.Eval(Container.DataItem, "ProductNumber")%>' ProductName='<%#DataBinder.Eval(Container.DataItem, "ProductName")%>'
            ProductPrice='<%#DataBinder.Eval(Container.DataItem, "DisplayPrice")%>' ProductUrl='<%#DataBinder.Eval(Container.DataItem, "DetailsUrl")%>'
            PhotoPath='<%#DataBinder.Eval(Container.DataItem, "ThumbsUrl")%>' AddToCartUrl='<%#DataBinder.Eval(Container.DataItem, "ShopCartUrl")%>'
            ProductDiscountPrice='<%#DataBinder.Eval(Container.DataItem, "DisplayDiscountPrice")%>'
            IsDiscountItem='<%#DataBinder.Eval(Container.DataItem, "IsDiscountItem")%>' />
    </ItemTemplate>
    <FooterTemplate>
        <ul id="visit-counter">
            <li class="center" style="color: Red; font-weight: bold">Online:
                <%= Application["OnlineUsers"] %></li>
            <li class="center" style="color: #006e2e">
                <div id="visitorCount">
                </div>
                <script type="text/javascript">
                    $(document).ready(function () {
                        $.get('/VisitorCounter.ashx', function (data) {
                            $('#visitorCount').html(data);
                        });
                    });
                </script>
            </li>
        </ul>
        </div>
    </FooterTemplate>
</asp:Repeater>-->
