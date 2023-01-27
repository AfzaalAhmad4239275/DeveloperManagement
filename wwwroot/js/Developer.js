var Count = 0;
var dataTable;

$(document).ready(function () {

    $(document).ready(function () {
        loadDataTable();
    });
});

function CreationNewDiv(Id) {
    $("#savebutton").removeClass("d-none");
    $("#editbutton").addClass("d-none");
    Count++
    if (Id != undefined && Id > 0) {
        Count = Id;
    }
    $("#DeveloperDivParent").append(`<div class="row  pl-3 "><label><h6>Developer ${Count}</h6></label></div><div class="row mb-2" style="margin-top:-16px" id="child${Count}">

                    <div class="col-4">
                        <div class="form-group"><p><h6>Name:</h6></p><input type="text" class="form-control " id="txt_Name${Count}" required /></div>
                        <div class="form-group child_sub"><input type="hidden" class="form-control" id="txt_Id${Count}" /></div>
                    </div>
                    <div class="col-4">
                        <div class="form-group"><p><h6>Age:</h6></p><input type="text" class="form-control" id="txt_Age${Count}" required /></div>
                    </div>
                    <div class="col-4">
                        <div class="form-group"><p><h6>Job Title:</h6></p><input type="text" class="form-control" id="txt_JobTitle${Count}" required /></div>
                    </div>

                    <hr />
                </div>`)
}

var dataTable;

function loadDataTable() {

    dataTable = $('#developerListTable').DataTable({
        "ajax": {
            "url": "/developer/getalldevelopers",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [

            { "data": "id", "width": "20%" },
            { "data": "name", "width": "20%" },
            { "data": "age", "width": "20%" },
            { "data": "job", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {

                    return `<div class="text-center">
                        <a class="btn btn-danger text-white" style="cursor:pointer; width: 120px;"
                            onclick=edit('developer/editdeveloper?id=${data}')>
                            Edit
                        </a>
                    </div>`;
                },
                "width": "20%"
            },


            {
                "data": "id",
                "render": function (data) {

                    return `<div class="text-center">
                        <a class="btn btn-danger text-white" style="cursor:pointer; width: 120px;"
                            onclick=Delete('developer/deletedeveloper?id=${data}')>
                            Delete
                        </a>
                    </div>`;
                },
                "width": "20%"
            }  
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%",
        "columnDefs": [
            {
                "searchable": false,
                "orderable": false,
                "targets": 0
            }
        ],
        "order": [
            [1, 'asc']
        ]
    });

    dataTable.on('order.dt search.dt', function () {
        dataTable.column(0, {
            search: 'applied',
            order: 'applied'
        }).nodes().each(function (cell, i) {
            cell.innerHTML = i + 1;
        });
    }).draw();
}

function save() {
    $("#savebutton").removeClass("d-none");
    $("#savebutton").removeClass("d-none");
    $("#createmorebutton").removeClass("d-none");
    var Developerlist = [];
    for (var n = 1; n <= Count; n++) {
        var Developer =
        {
            Name: $("#txt_Name" + n).val(),
            Age: $("#txt_Age" + n).val(),
            Job: $("#txt_JobTitle" + n).val()
        }
        if (Developer.Name == "" || Developer.Age == "" || Developer.Job == "") {
            swal({
                title: "Warning",
                text: "All Fields are Required",
                icon: "warning",
                showCancelButton: false,
                dangerMode: true
            });
            return false;
        }
        Developerlist.push(Developer)

    }
       

        $.ajax({
            async: true,
            type: "POST",
            url: "/Developer/savedeveloper",
            data: { Developerlist },
            cache: false,
            dataType: "json",
            success: function (result) {
                if (result.alreadyExist) {
                    alert("Name already Existed")
                    return false;
                }
                if (result.status) {
                    dataTable.destroy();
                    loadDataTable();

                    $("#AddDevModal").modal('hide');
                }
              else {
                    alert("Please fill are fields")

                }
               
               

               
            },
            failure: function (result) {
                
                alert("error");

            },
            error: function (result) {
                alert("error");

            }
        });
};

function edit(editUrl) {
    $("#createmorebutton").addClass("d-none");

        $.ajax({
            async: true,
            type: "POST",
            url: editUrl,
            cache: false,
            dataType: "json",
            success: function (response) {
                if (response) {

                    $("#DeveloperDivParent div").empty();
                    CreationNewDiv(response.id);
                    $("#txt_Id" + response.id).val(response.id);
                    $("#txt_Name" + response.id).val(response.name);
                    $("#txt_Age" + response.id).val(response.age);
                    $("#txt_JobTitle" + response.id).val(response.job);
                    $("#savebutton").addClass("d-none");
                    $("#editbutton").removeClass("d-none");

                    $("#AddDevModal").modal('show');
                }
                else {
                    alert("Some Thing Went Wrong")
                }
            },
            failure: function (response) {

                alert("error");

            },
            error: function (response) {
                alert("error");

            }
        });
};

function Delete(deleteUrl) {
    swal({
        title: "Are you sure to delete the Developer?",
        text: "Once deleted, you will not be able to recover",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: deleteUrl,
                success: function (data) {
                    if (data.status) {
                        dataTable.destroy();
                        loadDataTable();
                    }
                    else {
                        alert("Something Went Wrong");
                    }

                },

                failure: function (data) {

                    alert("error");

                },
                error: function (data) {
                    alert("error");

                }
            });
        }
    });
}

function clearmodal() {
    Count = 0;
    CreationNewDiv();
    $("#DeveloperDivParent div").empty();
    $("#AddDevModal").modal('show');
    $("#createmorebutton").removeClass("d-none");

}

function CreateNewModal() {
    
    Count = 0;
    $("#DeveloperDivParent div").empty();
    CreationNewDiv();
    $("#AddDevModal").modal('show');
    $("#createmorebutton").removeClass("d-none");


}

function update() {
   
        var saveobj =
        {
            Id: $("#txt_Id" + Count).val(),
            Name: $("#txt_Name" + Count).val(),
            Age: $("#txt_Age" + Count).val(),
            Job: $("#txt_JobTitle" + Count).val()
        }
       
        $.ajax({
            async: true,
            type: "POST",
            url: "/Developer/updatedeveloper",
            data: { obj: saveobj },
            cache: false,
            dataType: "json",
            success: function (result) {
                debugger;
                if (result.message) {
                    alert("Name already Existed")
                    return false;
                }
                if (result.status) {
                $("#AddDevModal").modal('hide');
                dataTable.destroy();
                loadDataTable();
                }
                else {
                    alert("Fill All Fields")
                }
                

            },

            failure: function (data) {

                alert("error");

            },
            error: function (data) {
                alert("error");

            }
        });
        return false;

}