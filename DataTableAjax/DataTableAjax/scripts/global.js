function _login() {
    debugger
    $("#login-form").on("submit", function (e) {
        e.preventDefault();
        var d = {
            objUsuario: {
                idUsuario: 1,
                user: $("#usuario").val()
            }
        }
        $.ajax({
            method: "POST",
            url: "Index.aspx/Login",
            data: JSON.stringify(data),
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        }).done(function (info) {
            //Respuesta del servidor
            console.log(info);
            $(".mensaje").html(info.d);
        })
    });
}

function __showUsers() {
    debugger
    $("#boton").on("click", function () {
        dtUsers();
    });
}

function dtUsers() {
    var table = $("#table-users").DataTable({
        destroy: true,
        responsive: true,
        ajax: {
            method: "POST",
            url: "Index.aspx/getUsers",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: function (d) {
                return JSON.stringify(d);
            },
            dataSrc: "d.data"
        },
        columns: [
            { "data": "id" },
            { "data": "user" },
            { "data": "password" }
        ]
    });
}

function test() {
    $.ajax({
        method: "POST",
        url: "Index.aspx/getUsers",
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    }).done(function (info) {
        console.log(info);
    });
}