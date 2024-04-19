
var dataTable

$(document).ready(function () {
    var url = window.location.search;
    if (url.includes("inprocess")) {
        loadDataTable("inprocess");
    }
    else {
        if (url.includes("completed")) {
            loadDataTable("completed");
        }
        else {
            if (url.includes("pending")) {
                loadDataTable("pending");
            }
            else {
                if (url.includes("approved")) {
                    loadDataTable("approved");
                }
                else {
                    loadDataTable("all");
                }
            }
        }
    }
});

    function loadDataTable(status) {
        dataTable = $('#tblData').DataTable({
            "ajax": { url: '/Admin/Order/getall?status=' + status },
            "columns": [
                { data: 'id', "with": "10%" },
                { data: 'name', "with": "15%" },
                { data: 'phoneNumber', "with": "15%" },
                { data: 'applicationUser.email', "with": "15%" },
                { data: 'orderStatus', "with": "10%" },
                { data: 'orderTotal', "with": "15%" },
                {
                    data: 'id',
                    "render": function (data) {
                        return `
                        <div class="w-75 btn-group" role="group">
                        <a href="/Admin/Order/details?orderId=${data}"
                        class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                       
					</div>`
                    },
                    "with": "25%"
                },
            ]
        });
    }

