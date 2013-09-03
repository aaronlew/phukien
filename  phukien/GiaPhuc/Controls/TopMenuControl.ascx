<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopMenuControl.ascx.cs"
    Inherits="GiaPhuc.Controls.TopMenuControl" %>
<div id="topmenu">
    <div class="wrapper">
        <ul>
            <li><a href="/">Home</a></li>
            <li><a href="<%="/pages/aboutpage.aspx".ParseSimpleUrl("Giới thiệu phukienipadx") %>">
                Giới thiệu</a></li>
            <li><a href="<%="/pages/topicpage.aspx?ID=9".ParseSimpleUrl("Hướng dẫn mua hàng") %>">
                Hướng dẫn mua hàng</a></li>
            <li><a href="<%="/pages/topicpage.aspx?ID=6".ParseSimpleUrl("Quy định bảo hành") %>">
                Quy định bảo hành</a></li>
            <li><a href="<%="/pages/topicpage.aspx?ID=8".ParseSimpleUrl("Tìm đối tác") %>">Tìm đối
                tác</a></li>
            <li><a href="<%="/pages/contactpage.aspx".ParseSimpleUrl("Liên hệ phukienipadx") %>">
                Liên hệ</a></li>
        </ul>
    </div>
</div>
