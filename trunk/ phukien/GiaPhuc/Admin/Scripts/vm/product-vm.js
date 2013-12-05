var currentPage = 1;
var pageSize = 10;
var status = 'posted';

$(document).ready(function () {

    $('#tabs li a').click(function () {
        status = $(this).attr('class');
        loadProducts(1);

        switch (status) {
            case 'deleted':
                $('#btnUndo').show();
                $('#btnDelete').val('Destroy');
                break;
            default:
                $('#btnUndo').hide();
                $('#btnDelete').val('Delete');
                break;
        }

        $('#tabs li.current').removeClass('current');
        $(this).closest('li').addClass('current');
    });

    // add multiple select / deselect functionality
    $('#divProductList').on('click', '#allChoice', function () {
        $('.choice').prop('checked', this.checked);
    });

    // if all checkbox are selected, check the selectall checkbox
    // and viceversa
    $('#divProductList').on('click', '.choice', function () {

        if ($(".choice").length == $(".choice:checked").length) {
            $("#allChoice").prop("checked", true);
        } else {
            $("#allChoice").prop("checked", false);
        }
    });

//    $('#divProductList').on('click', '.button-edit', openDialog);
//    $('#divProductList').on('click', '.button-approve', openDialog);

    $('#btnDelete').click(function () {
        var selectedItems = [];
        $(".choice:checked").each(function () {
            selectedItems.push(parseInt($(this).closest('tr').attr('id')));
        });
        var result = productImplement.deleteProducts(selectedItems, status);

        if (result) {
            loadProducts(currentPage);
        }
    });

    $('#btnUndo').click(function () {
        var selectedItems = [];
        $(".choice:checked").each(function () {
            selectedItems.push(parseInt($(this).closest('tr').attr('id')));
        });
        var result = productImplement.undoProducts(selectedItems);

        if (result) {
            loadProducts(currentPage);
        }
    });


    $('#btnFind').click(function () { loadProducts(1); });

    loadProducts(1);
});


function loadProducts(pageNum, isPaged) {
    var productObjects = productImplement.getProducts(status, pageNum,
            $('#keyword').val());

    if (productObjects !== null) {
        $('#divProductList').setTemplateURL("/Admin/template/productList.htm");
        $('#divProductList').processTemplate(productObjects);

        if (!isPaged) {
            paginator(productObjects.TotalRecords, productObjects.PageSize);
        }

        if (productObjects.CountPosted > 0) {
            $("#countPosted").text(' (' + productObjects.CountPosted + ')');
        }
        else {
            $("#countPosted").text('');
        }
        if (productObjects.CountDeleted > 0) {
            $("#countDeleted").text(' (' + productObjects.CountDeleted + ')');
        }
        else {
            $("#countDeleted").text('');
        }
    }

    currentPage = pageNum;
}

function paginator(rowCount, pageSize) {
    $('#pager').smartpaginator({
        totalrecords: rowCount,
        recordsperpage: pageSize,
        length: 5,
        next: 'Next',
        prev: 'Prev',
        first: 'First',
        last: 'Last',
        theme: 'blue',
        controlsalways: true,
        onchange: function (newPage) {
            loadProducts(newPage, true);
            currentPage = newPage;
            $('#r').html('Page # ' + newPage);
        }
    });
}