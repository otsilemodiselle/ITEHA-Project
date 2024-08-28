$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'name', "width": "15%" },
            { data: 'barcode', "width": "5%" },
            { data: 'listPrice', "width": "5%" },
            { data: 'supplier', "width": "15%"},
            { data: 'category.name', "width": "30%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                    <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i>Edit</a>
                    <a href="/admin/product/delete/${data}" class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i>Delete</a>
                    </div>`
                },
                "width": "50%"
            }
        ]
    });
}
