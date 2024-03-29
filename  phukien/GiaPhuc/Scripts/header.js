(function ($) {

    $.fn.menumaker = function (options) {

        var cssmenu = $(this), settings = $.extend({
            title: "Menu",
            format: "dropdown",
            sticky: false
        }, options);

        return this.each(function () {
            cssmenu.prepend('<div id="menu-button">' + settings.title + '</div>');
            $(this).find("#menu-button").on('click', function () {
                $(this).toggleClass('menu-opened');
                var mainmenu = $(this).next('ul');
                if (mainmenu.hasClass('open')) {
                    mainmenu.hide().removeClass('open');
                }
                else {
                    mainmenu.show().addClass('open');
                    if (settings.format === "dropdown") {
                        mainmenu.find('ul').show();
                    }
                }
            });

            cssmenu.find('li ul').parent().addClass('has-sub');

            var multiTg = function () {
                cssmenu.find(".has-sub").prepend('<span class="submenu-button"></span>');
                cssmenu.find('.submenu-button').on('click', function () {
                    $(this).toggleClass('submenu-opened');
                    if ($(this).siblings('ul').hasClass('open')) {
                        $(this).siblings('ul').removeClass('open').hide();
                    }
                    else {
                        $(this).siblings('ul').addClass('open').show();
                    }
                });
            };

            if (settings.format === 'multitoggle') multiTg();
            else cssmenu.addClass('dropdown');

            if (settings.sticky === true) cssmenu.css('position', 'fixed');

            var resizeFix = function () {
                if ($(window).width() > 768) {
                    cssmenu.find('ul').show();
                }

                if ($(window).width() <= 768) {
                    cssmenu.find('ul').hide().removeClass('open');
                }
            };
            resizeFix();
            return $(window).on('resize', resizeFix);

        });
    };
})(jQuery);

(function ($) {


    $(document).ready(function () {

        $(window).scroll(function () {
            var scroll = $(window).scrollTop();

            if (scroll >= 200) {
                $(".header #logo img:first").slideUp(20, function () {
                    $(".header #logo img.smaller").slideDown(200);
                    $(".header").addClass('smaller');
                });
            } else {
                $(".header #logo img.smaller").slideUp(20, function () {
                    $(".header #logo img:first").slideDown(200);
                    $(".header").removeClass("smaller");
                });
            }
        });

//        $("#cssmenu").menumaker({
//            title: "Menu",
//            format: "multitoggle"
//        });

//        $("#cssmenu").prepend("<div id='menu-line'></div>");

//        var foundActive = false, activeElement, linePosition, menuLine = $("#cssmenu #menu-line"), lineWidth, defaultPosition, defaultWidth;

//        $("#cssmenu > ul > li").each(function () {
//            if ($(this).hasClass('active')) {
//                activeElement = $(this);
//                foundActive = true;
//            }
//        });

//        if (foundActive === false) {
//            activeElement = $("#cssmenu > ul > li").first();
//        }

//        defaultWidth = lineWidth = activeElement.width();

//        defaultPosition = linePosition = activeElement.position().left;

//        menuLine.css("width", lineWidth);
//        menuLine.css("left", linePosition);

//        $("#cssmenu > ul > li").hover(function () {
//            activeElement = $(this);
//            lineWidth = activeElement.width();
//            linePosition = activeElement.position().left;
//            menuLine.css("width", lineWidth);
//            menuLine.css("left", linePosition);
//        },
//        function () {
//            menuLine.css("left", defaultPosition);
//            menuLine.css("width", defaultWidth);
//        });

    });

})(jQuery);
