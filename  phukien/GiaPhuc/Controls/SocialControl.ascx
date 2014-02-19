<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SocialControl.ascx.cs"
    Inherits="GiaPhuc.Controls.SocialControl" %>
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

    -->
</script>
<div id="social-icons">
    <ul>
        <li>
            <g:plusone></g:plusone>
        </li>
        <li><a href="https://twitter.com/share" class="twitter-share-button" data-url="http://phukienipadx.com"
            data-via="phukienipadx" data-size="large">Tweet</a> </li>
        <li>
            <iframe src="//www.facebook.com/plugins/like.php?href=http%3A%2F%2Fphukienipadx.com%2F&amp;width&amp;layout=box_count&amp;action=like&amp;show_faces=true&amp;share=true&amp;height=65"
                scrolling="no" frameborder="0" style="border: none; overflow: hidden; height: 65px;"
                allowtransparency="true"></iframe>
        </li>
    </ul>
</div>
