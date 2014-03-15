var divName = "#page";
var templatePath = "/Admin/template/PageTemplate.htm";
var serviceLoad = "/CMS.asmx/LoadPages";
var serviceDelete = "/CMS.asmx/DeletePage";

$(document).ready(function () {

    function waiting(tag) {
        tag.empty().html('<center><img src="/static/Images/spinner.gif" alt="spinner" style="margin: auto; padding: 0; height: auto;" /><p>If the data are loaded too long, please press F5 to reload your browser.</p><center>');
    }

    function load(pageNumber, init) {

        defaultParameters = "{ pageNumber: " + pageNumber + "}";

        waiting($(divName));

        $.ajax({
            type: "POST",
            url: serviceLoad,
            data: defaultParameters,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: (function Success(data, status) {
                var list = data.d;
                $(divName).setTemplateURL(templatePath);
                $(divName).processTemplate(list);
                
                if (init) {
                    $('#black').smartpaginator({
                        totalrecords: list.TotalRecords,
                        recordsperpage: list.PageSize,
                        length: 16,
                        next: 'Next',
                        prev: 'Prev',
                        first: 'First',
                        last: 'Last',
                        theme: 'black',
                        controlsalways: false,
                        onchange: function (newPage) {
                            load(newPage);
                            $('#r').html('Page # ' + newPage);
                        }
                    });
                }

                define();
            }),
            error: (function Error(XMLHttpRequest, textStatus, errorThrown) {
                var err = eval("(" + XMLHttpRequest.responseText + ")");
                $("#black").html(err.Message).fadeIn(1000);
            })
        });
    }

    function define() {
        $("#grid a.btnDelete").click(function () {
            if (confirm("Do you want to delete this record?")) {
                var aTag = $(this);

                // load provider
                $.ajax({
                    type: "POST",
                    url: serviceDelete,
                    data: "{ id: " + aTag.attr("id") + "}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    async: false,
                    success: (function Success(data, status) {
                        if (data.d) {
                            $('#grid > tbody > tr').removeClass('selected');
                            aTag.parents("tr:first").remove();
                            return false;
                        }
                    }),
                    error: (function (XMLHttpRequest, textStatus, errorThrown) {
                        var err = eval("(" + XMLHttpRequest.responseText + ")");
                        $(divName).html(err.Message).fadeIn(1000);
                    })
                });
            }
        });
    }

    load(1, true);

});