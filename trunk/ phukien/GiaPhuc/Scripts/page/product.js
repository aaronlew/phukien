
$(document).ready(function () {
    $('.jqzoom').jqzoom({
        zoomType: 'standard',
        lens: true,
        preloadImages: false,
        alwaysOn: false
    });

    $("#usual1 ul").idTabs();

    $('img').each(function () {
        if (this.offsetWidth > 620) {
            $(this).width(620);
        }
    });
});