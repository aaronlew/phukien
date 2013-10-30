<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OnTopControl.ascx.cs"
    Inherits="GiaPhuc.Controls.OnTopControl" %>
<div style="position: fixed; width: 100%">
    <div class="onTop wrapper">
        <div id="divAddress">
            <p class="add1">
                <asp:Literal ID="Literal1" runat="server" Text="<%$Resources:Resources, Address1 %>" /></p>
            <p class="add2" style="display: none">
                <asp:Literal ID="Literal2" runat="server" Text="<%$Resources:Resources, Address2 %>" /></p>
        </div>
        <div id='cssmenu'>
            <ul>
                <li class='has-sub last'><a href="ymsgr:sendim?lieumanhdat1981">
                    <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=lieumanhdat1981&l=vi"
                        title="Bao da ipad, pin dự phòng YOOBAO, phukienipadx.com" />&nbsp; Bán hàng
                    TPHCM</a> </li>
                <li><a href="ymsgr:sendim?phukienipadx">
                    <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=phukienipadx"
                        title="Bao da ipad, pin dự phòng YOOBAO, phukienipadx.com" />&nbsp; Bán hàng
                    Hà Nội</a> </li>
                <%--<li><a href="ymsgr:sendim?nanganhbsg">
                        <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=nanganhbsg&l=vi"
                            title="Bao da ipad, pin dự phòng YOOBAO, phukienipadx.com" />&nbsp; Bán hàng
                        Hà Nội</a> </li>--%>
            </ul>
        </div>
    </div>
</div>
<div style="display: inline-block; height: 33px;"></div>
<style type="text/css">
    #divAddress
    {
        height: 33px;
        overflow: hidden;
    }
    .onTop
    {
        height: 33px;
        border-bottom: 1px solid #ddd;
        background: #fefefe;
        background: -moz-linear-gradient(top, #fefefe 0%, #ececec 100%);
        background: -webkit-gradient(linear, left top, left bottom, color-stop(0%, #fefefe), color-stop(100%, #ececec));
        background: -webkit-linear-gradient(top, #fefefe 0%, #ececec 100%);
        background: -o-linear-gradient(top, #fefefe 0%, #ececec 100%);
        background: -ms-linear-gradient(top, #fefefe 0%, #ececec 100%);
        background: linear-gradient(top, #fefefe 0%, #ececec 100%);
    }
    .onTop div
    {
        float: left;
    }
    .onTop p
    {
        line-height: 33px;
    }
    #cssmenu
    {
        float: right;
    }
</style>
<script type="text/javascript">
    function changeAddress(add1, add2) {
        add1.fadeOut();
        add2.fadeIn();
        setTimeout(function () {
            changeAddress(add2, add1);
        }, 5000);
    }

    $(function () {
        setTimeout(function () {
            changeAddress($('p.add1'), $('p.add2'));
        }, 5000);
    });
</script>
