function getPlayers(position, id) {

    
    $.post("/draft/PickP1", { position: position }, function (data) {
        $("#" + id).prop("disabled", true);
        alert(data[0].Name)
        return data;
    });


}


window.onload = function () {

    

    $('.Player1').click(function (event) {
        $("#myModal").modal();

        $.post("/draft/PickP1", { position: event.target.innerHTML }, function (data) {
            $("#" + event.target.id).prop("disabled", true);
            let counter = 0;
            console.log(JSON.stringify(data));
      //      $("#choice0").html(createPlayer(data[0]))
       //     $("#choice1").html(createPlayer(data[1]))
        //    $("#choice2").html(createPlayer(data[2]))
         //   $("#choice3").html(createPlayer(data[3]))
         //   $("#choice4").html(createPlayer(data[4]))

            let choiceInterval = setInterval(function () {
                //   $("#choice" + counter).show("slow");
                $("#choice" + counter).val('{ "playerId" : ' + data[counter].Id +', "positionId" : "test" }');
                $("#choice" + counter).html(createPlayer(data[counter]))
                    counter++;
                 if (counter == 5) {
                     clearInterval(choiceInterval)
           }
        }, 2000);

        });

    })


    $('.choice').click(function (event) {
        alert(event.currentTarget.id + "?")
        let playerId = $("#" + event.currentTarget.id).val();
       // alert($("#" + event.currentTarget.id).val())
        let test = JSON.parse($("#" + event.currentTarget.id).val())
        alert(test.positionId)
        $(".choice").html("<br><br><br><br><br><br>");
       // $("#" + event.target.id).
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
