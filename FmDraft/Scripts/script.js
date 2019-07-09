
window.onload = function ()     {

    

    $('.Player1').click(function (event) {
        $("#myModal").modal();
        $.post("/draft/PickP1", { position: event.currentTarget.innerHTML }, function (data) {
            $("#" + event.currentTarget.id).prop("disabled", true);
            let counter = 0;
            let choiceInterval = setInterval(function () {

                $("#choice" + counter).val('{ "playerId" : ' + data[counter].Id + ', "positionId" : "' + "#" + event.currentTarget.id + '", "name":"' + data[counter].Name + '", "club":"' + data[counter].Club.Name + '" }');
                $("#choice" + counter).html(createPlayer(data[counter]))
                counter++;
                if (counter == 5) {
                     clearInterval(choiceInterval)
                }
            }, 2000);

        });

    })


    $('.choice').click(function (event) {
        let buttonValue = JSON.parse($("#" + event.currentTarget.id).val())
        $(buttonValue.positionId).html("<p>" + buttonValue.name + "</p><p>" + buttonValue.club + "</p>")
        $(".choice").html("<br><br><br><br><br><br>");

        if (buttonValue.positionId != undefined) {
            $('#myModal').modal('hide');
            $(".choice").val("");

        }
    });




}

function createPlayer(playerObject) {

    return "<p>" + playerObject.Name + "</p><p>" + playerObject.Club.Name + "</p><p>" + numberWithCommas(playerObject.Value) + "£</p><p>" + playerObject.Position + "</p><span class='attributes'></span>"
}

function setTechnicalAttributes(playerObject) {
    return "<p>Corners: " + playerObject.CornerKick + "</p><p>Crossing: " + playerObject.Crossing + "</p><p>Dribbling: " + playerObject.Dribbling + "</p><p>Finishing: " + playerObject.Finishing + "</p><p>First Touch: " + playerObject.FirstTouch + "</p><p>Freekick: " + playerObject.FreeKick + "</p><p>Heading: " + playerObject.Heading + "</p><p>Longshot: " + playerObject.Longshot + "</p><p>Long Throw: " + playerObject.LongThrow + "</p><p>Marking: " + playerObject.Marking + "</p><p>Passing: " + playerObject.Passing + "</p><p>Penalty: " + playerObject.PentaltyKick + "</p><p>Tackling: " + playerObject.Tackling + "</p><p>Technique: " + playerObject.Technique + "</p>"
}
    
function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}
