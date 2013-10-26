<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SocialControl.ascx.cs"
    Inherits="GiaPhuc.Controls.SocialControl" %>
<div id="social-icons">
    <ul>
        <li>
            <g:plusone></g:plusone>
        </li>
        <li><a href="https://twitter.com/share" class="twitter-share-button"
            data-url="http://phukienipadx.com" data-via="phukienipadx" data-size="large">Tweet</a>
        </li>
        <li>
            <fb:like font="tahoma" href="http://phukienipadx.com" layout="button_count" show_faces="true"
                width="10" />
            <div id="fb-root">
            </div>
        </li>
        <%--<li style="height: 300px">
                <div class="fb-like-box" data-href="https://www.facebook.com/pages/Phukienipadx_com"
                    data-width="220" data-stream="false">
                </div>
            </li>--%>
    </ul>
</div>
