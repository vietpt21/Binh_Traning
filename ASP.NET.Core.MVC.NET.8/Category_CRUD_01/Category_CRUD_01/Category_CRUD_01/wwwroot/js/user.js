
$(document).ready(function () {
    loadDataTable();
});
var dataTable
function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {url: '/admin/user/getall'},
        "columns": [
            { data: 'name', "with": "10%" },
            { data: 'email',"with": "15%" },
            { data: 'phoneNumber' ,"with": "15%" },
            { data: 'company.name', "with": "10%" },
            { data: "role", "with": "15%" },
            {
                data: { id:"id", lockoutEnd: "lookoutEnd" },
                "render": function (data) {
                    var today = new Date().getTime();
                    var lockout = new Date(data.lockoutEnd).getTime();
                    if (lockout > today) {
                        return `
                        <div class="text-center" >
                            <a onclick=LockUnlock('${data.id}') class= "btn btn-danger text-white" style="cursor:pointer;with:100%;">
                             <i class ="bi bi-look fill"></i>Lock
                            </a>
                             <a href ="/admin/user/RoleManagment?userId=${data.id}" class= "btn btn-danger text-white" style="cursor:pointer;with:150px;">
                            <i class ="bi bi-look fill"></i>Permistion
                            </a>
					    </div>
                        `
                    }
                    else {
                        return `
                         <div class="text-center" >
                            <a onclick = LockUnlock('${data.id}') class= " btn btn-success text-white " style="cursor:pointer;with:100%;">
                            <i class ="bi bi-look fill"></i>UnLock
                            </a>
                             <a href ="/admin/user/RoleManagment?userId=${data.id}" class= "btn btn-danger text-white"style="cursor:pointer;with:150px;">
                            <i class ="bi bi-look fill"></i>Permistion
                            </a>
					    </div>
                        `
                    }
                },
                "with": "25%"
            },
        ]
    });
}
function LockUnlock(id) {
    $.ajax({
        type: "POST",
        url: '/Admin/User/LockUnlock',
        data: JSON.stringify(id),
        contentType: "application/json",
        success: function (data) {
            if (data.success) {
                dataTable.ajax.reload();
                toastr.success(data.message);
            }
            else {
                toastr.error(data.message);
            }
        }
    });
}
