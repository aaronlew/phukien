<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HorizontalBannerControl.ascx.cs"
    Inherits="GiaPhuc.Controls.HorizontalBannerControl" %>
<%@ Import Namespace="GiaPhuc.Utility" %>
<style type="text/css">
    #wmt-slideshow-wrapper
    {
        height: 280px;
        width: 728px;
        background: rgb(248, 248, 250);
        position: relative;
    }
    #wmt-slideshow-container
    {
        height: 280px;
        width: 100%;
        margin: 0 auto;
    }
    #wmt-slideshow-container li
    {
        list-style: none;
        width: 728px;
    }
    .slide-top
    {
        float: left;
    }
    .slide-bottom
    {
        float: right;
    }
    .slide-left-img
    {
        float: left;
    }
    .slide-right-img
    {
        float: right;
        margin-top: -220px;
        margin-right: 30px;
        border: solid 3px #fff;
    }
    .slide-left-text
    {
        float: left;
        position: absolute;
        width: 600px;
        left: -2130px;
        top: 180px;
        height: 100px;
        line-height: 100px;
        text-align: center;
    }
    .slide-right-text
    {
        float: right;
        position: absolute;
        width: 300px;
        right: -2130px;
        height: 100px;
        line-height: 100px;
        text-align: center;
    }
    .slide-text
    {
        font-size: 20px;
        font-family: Georgia;
        color: #ffffff;
        text-shadow: 1px 0px 11px rgba(0, 0, 0, 1);
    }
    .np-buttons
    {
        top: 220px;
        width: 30px;
        height: 30px;
        background: url(http://www.yootheme.com/demo/themes/wordpress/2012/sync/wp-content/plugins/widgetkit/widgets/slideshow/styles/sync/images/buttons.png);
        cursor: pointer;
        position: absolute;
        z-index: 5;
    }
    #wmt-snext
    {
        background-position: 0 -123px;
        left: 698px;
    }
    #wmt-snext:hover
    {
        background-position: 0 -164px;
    }
    #wmt-sprev
    {
        background-position: 0 0;
    }
    #wmt-sprev:hover
    {
        background-position: 0 -41px;
    }
</style>
<div class="main-width">
    <div id="wmt-slideshow-wrapper">
        <ul id="wmt-slideshow-container">
            <% for (int j = 1; j < SessionManager.DiscountProducts.Count; j++)
               { %>
            <li id="wmt-slide<%=j %>">
                <div class="slide-top">
                    <img class="slide-left-img" src="/static/images/banner/thumbl_728_<%=string.Format("{0:000}", j)%>.png"
                        alt="<%=SessionManager.DiscountProducts[j].ProductName%>"
                        title="<%=SessionManager.DiscountProducts[j].ProductName%>" />
                    <div class="slide-text slide-right-text">
                        <%=SessionManager.DiscountProducts[j].ProductNumber%></div>
                </div>
                <div class="slide-bottom">
                    <div class="slide-text slide-left-text">
                        <%=SessionManager.DiscountProducts[j].ProductName%></div>
                    <img class="slide-right-img" src="<%=SessionManager.DiscountProducts[j].ImageUrl%>"
                        alt="<%=SessionManager.DiscountProducts[j].ProductName%>" title="<%=SessionManager.DiscountProducts[j].ProductName%>"
                        width="200" />
                </div>
            </li>
            <% } %>
        </ul>
        <div id="wmt-snext" class="np-buttons">
        </div>
        <div id="wmt-sprev" class="np-buttons">
        </div>
    </div>
</div>
<script type="text/javascript">
    $(document).ready(function() {
    $('#wmt-slideshow-container').cycle({ 
        fx:      'scrollRight', 
        speed:   'fast',
        timeout: 6000,
        before:  onBefore, 
        after:   onAfter,
        next:   '#wmt-snext', 
        prev:   '#wmt-sprev'
     });
    function onBefore() { 
        $(this).removeClass('prev');
        $(this).addClass('current');
    }
    function onAfter() {
        $('.current .slide-right-text').animate({
                right: "+=2100",
            }, 800, "easeInBounce", function() {  
                $('.current .slide-left-text').animate({
                    left: "+=2100",
                }, 800, "easeInBounce", function() {  
                    $(this).parent().parent().removeClass('current');  
                    $(this).parent().parent().addClass('prev');         
                });                
            }
        );    
        $('.slide-left-text').css('left', '-2130px');
        $('.slide-right-text').css('right', '-2130px');  
    }
});   
</script>
