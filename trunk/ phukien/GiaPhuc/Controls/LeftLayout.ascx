<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeftLayout.ascx.cs"
    Inherits="GiaPhuc.Controls.LeftLayout" %>
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
    -->
</script>
<div>
    <uc:AdvertiseLeftSide ID="AdvertiseLeftSide1" runat="server" />
</div>
