<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeftLayout.ascx.cs"
    Inherits="GiaPhuc.Controls.LeftLayout" %>
<%@ Import Namespace="GiaPhuc.Utility" %>
<%@ Import Namespace="phukienipadx.Bl.Models" %>
<%@ Register Src="~/Controls/UCProductCell.ascx" TagName="ProductCell" TagPrefix="uc" %>
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

    function hoverMenu() {
        //初始化
        var end_num = 4;
        var array_num = $(".navItem").size();
        $(".mainlist").css("position", "static");
        $(".sub-nav-container").css("top", "-10000000px");
        $(".navItem").removeClass("show_back");

        if ($(this).closest('li').has('div').length == 0) return true;

        $(this).addClass("show_back");

        //计算尺寸
        var indexs = $(".navItem").index($(this));
        var show_box_height = $(this).next().height() + $(".right-tr").height() + $(".right-br").height();

        var li_height = $("#litb-nav li").height();
        var li_height_total = (indexs + 1) * (li_height + 1);

        //判断并做出改变
        if ((li_height_total + li_height + 1) > show_box_height) {
            $(this).parent().css("position", "relative");
            if (indexs > array_num - end_num) {
                $(this).next().css("top", -show_box_height + 70 + "px");
            } else {
                $(this).next().css("top", "-11px");
            }
        } else {
            $(this).next().css("top", "-17px");
        }
    }

    function hoverMenu1() {

        //初始化
        var end_num = 4;
        var array_num = $(".navItem").size();
        $(".mainlist").css("position", "static");
        $(".sub-nav-container").css("top", "-10000000px");
        $(".navItem").removeClass("show_back");

        if ($(this).closest('li').has('div').length == 0) return true;

        $(this).addClass("show_back");

        //计算尺寸
        var indexs = $(".navItem").index($(this));
        var show_box_height = $(this).next().height() + $(".right-tr").height() + $(".right-br").height();

        var li_height = $("#litb-nav li").height();
        var li_height_total = (indexs + 1) * (li_height + 1);

        //判断并做出改变
        if ((li_height_total + li_height + 1) > show_box_height) {
            $(this).parent().css("position", "relative");
            if (indexs > array_num - end_num) {
                $(this).next().css("top", -show_box_height + 70 + "px");
            } else {
                $(this).next().css("top", "-11px");
            }
        } else {
            $(this).next().css("top", "-17px");
        }

        return false;
    }

    $(function () {
        $('#litb-nav li:last').attr('style', 'border-radius:0 0 5px 5px');

        $(".navItem").click(hoverMenu1).hover(
    	  hoverMenu,
    	    function () {
    	        $(".sub-nav-container").hover(
    				function () {
    				    //nothing
    				},
    				function () {
    				    $(this).css("top", "-10000000px");
    				    //$(this).css("z-index","9999999");
    				    $(this).parent().css("position", "static");
    				    $(".navItem").removeClass("show_back");
    				}
    			);
    	    }
    	);

    });

    $(document).click(function () {
        $(".mainlist").css("position", "static");
        $(".sub-nav-container").css("top", "-10000000px");
        $(".navItem").removeClass("show_back");
    });

    //-->

</script>
<div id="left_menu">
    <div id="light_menu" class="menu">
        <ul id="litb-nav">
            <%
                bool first = true;
                foreach (CategoryInfo item in SessionManager.Categories)
                {
            %>
            <li class="<%=(first ? "first" : string.Empty) %> mainlist" style="position: static;">
                <a target="_blank" class="navItem" href="<%= ("/Default.aspx?CategoryID=" + item.CategoryId).ParseSimpleUrl(item.Name) %>"
                    title="<%=item.Name %>">
                    <%= item.Name %></a>
                <%
                    if (first) first = false;
                    if (item.Categories != null && item.Categories.Count > 0)
                    {%>
                <div class="sub-nav-container">
                    <dl>
                        <%
                        int i = 0;
                        foreach (CategoryInfo subItem in item.Categories)
                        {
                        %>
                        <dt><a target="_blank" href="<%= ("/Default.aspx?CategoryID=" + subItem.CategoryId).ParseSimpleUrl(subItem.Name) %>"
                            title="<%=subItem.Name %>">
                            <%= subItem.Name %></a></dt>
                        <%
                            i++;
                        }%>
                    </dl>
                </div>
                <% } %>
            </li>
            <%
                }
            %>
        </ul>
    </div>
</div>
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
<div class="box-heading">
    PHỤ KIỆN BÁN CHẠY</div>
<asp:Repeater ID="datDefault" runat="server">
    <HeaderTemplate>
        <div id="highlight-product" class="product-special info">
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
</asp:Repeater>