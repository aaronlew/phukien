function editRecord(id) {
    window.location = '/Admin/Pages/ProductEntry.aspx?ID=' + id;
}

$(document).ready(function () {
    
    var divName = "#gridProduct";

    $(divName).jtable({
        title: 'Product List',
        paging: true,
        pageSize: 10,
        sorting: true,
        defaultSorting: 'ProductName ASC',
        actions: {
            listAction: "/Admin/Pages/ProductManager.aspx/GetProductList",
            deleteAction: "/Admin/Pages/ProductManager.aspx/DeleteProductItem"
        },
        fields: {
            ProductId: {
                key: true,  
                list: false
            },
            ProductNumber: {
                title: '#',
                width: '5%'
            },
            ProductName: {
                title: 'Tên sản phẩm',
                width: '95%'
            },
            CustomAction: {
                title: '',
                width: '1%',
                sorting: false,
                create: false,
                edit: false,
                list: true,
                display: function (data) {
                    if (data.record) {
                        return '<button title="Edit" class="jtable-command-button jtable-edit-command-button" onclick="javascript:editRecord(' + data.record.ProductId + '); return false;"><span>Edit</span></button>';
                    }
                    return undefined;
                }
            }
        }
    });

    $(divName).jtable('load');
});