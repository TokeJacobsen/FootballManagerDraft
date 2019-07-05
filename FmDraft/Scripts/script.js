function myfunction(position, id) {


    $.post("/draft/PickP1", { position: position }, function (data) {
        $("#" + id).prop("disabled", true);
        // $("#" + id).html(data);
        console.log(JSON.stringify(data));
        alert(data[0].Name)



    });
}


window.onload = function () {

    $('.Player1').click(function (event) {
        $("#myModal").modal();
    })
}

