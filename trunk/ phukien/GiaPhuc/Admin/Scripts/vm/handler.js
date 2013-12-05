var productImplement = new Object();

productImplement.getProduct = function (productId) {
    var URL = "/Handler/MyService.asmx/GetProduct";
    var model;
    $.ajax({
        type: "POST",
        url: URL,
        data: JSON.stringify({ productId: productId }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (data) {
            model = data.d;
        },
        error: function () {
            model = null;
        }
    });

    return bookObject;
}

productImplement.updateProduct = function (product) {
    var URL = "/Handler/MyService.asmx/UpdateProduct";
    var result;
    $.ajax({
        type: "POST",
        url: URL,
        data: JSON.stringify({ product: product }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (data) {
            result = data.d;
        },
        error: function () {
            result = false;
        }
    });

    return result;
}

productImplement.getProducts = function (status, pageNumber, keyword) {
    var URL = "/Handler/MyService.asmx/GetProducts";
    var model;
    $.ajax({
        type: "POST",
        url: URL,
        data: JSON.stringify({ status: status, pageNumber: pageNumber, keyword: keyword }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (data) {
            model = data.d;
        },
        error: function () {
            model = null;
        }
    });

    return model;
}

productImplement.deleteProducts = function (productIds) {
    var URL = "/Handler/MyService.asmx/DeleteProducts";
    var result;
    $.ajax({
        type: "POST",
        url: URL,
        data: JSON.stringify({ productIds: productIds }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (data) {
            result = data.d;
        },
        error: function () {
            result = false;
        }
    });

    return result;
}

productImplement.undoProducts = function (productIds) {
    var URL = "/Handler/MyService.asmx/UndoProducts";
    var result;
    $.ajax({
        type: "POST",
        url: URL,
        data: JSON.stringify({ productIds: productIds }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (data) {
            result = data.d;
        },
        error: function () {
            result = false;
        }
    });

    return result;
}


productImplement.getTabs = function () {
    var URL = '/Get.asmx/GetTabs';
    var tabs;
    $.ajax({
        type: "POST",
        url: URL,
        async: false,
        success: function (data) {
            tabs = data.d;
        },
        error: function () {
        }
    });
    return tabs;
}
