﻿$(document).ready(function ($) {
    $(".water").each(function () {
        var tb = $(this);
        if (tb.val() != this.title) {
            tb.removeClass("water");
        }
    });

    $(".water").focus(function () {
        var tb = $(this);
        if (tb.val() == this.title) {
            tb.val("");
            tb.removeClass("water");
        }
    });

    $(".water").blur(function () {
        var tb = $(this);
        if ($.trim(tb.val()) == "") {
            tb.val(this.title);
            tb.addClass("water");
        }
    });

    jQuery("img").lazy();

    $('#hor-menu').dcMegaMenu({
        rowItems: '5',
        speed: 'fast',
        effect: 'fade',
        event: 'click',
        fullWidth: true
    });

    $('#social-icons').scrollToFixed({ marginTop: 10,
        zIndex: 99
    });

    $('#kenburns-slideshow').Kenburns({
        images: [
	    		"/images/highlight-products/image0.jpg",
	    		"/images/highlight-products/image1.jpg",
	    		"/images/highlight-products/image2.jpg",
	    		"/images/highlight-products/image3.jpg",
	    		"/images/highlight-products/image4.jpg",
	    		"/images/highlight-products/image5.jpg"
	    	    ],
        scale: 0.75,
        duration: 8000,
        fadeSpeed: 1200,
        ease3d: 'cubic-bezier(0.445, 0.050, 0.550, 0.950)',

        onSlideComplete: function () {
        },
        onLoadingComplete: function () {
        }

    });

});

function formatText(index, panel) {
    return index + "";
}