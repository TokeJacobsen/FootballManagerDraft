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

           let choiceInterval = setInterval(function () {
               $("#choiceList").append(" <button id='choice" + counter + "' class='choice choiceItem' data-dismiss='modal' class='btn - lg' style='color: red'>" + createPlayer(data[counter]) + "</button>")
           counter++;
           if (counter == 5) {
               clearInterval(choiceInterval)
           }
        }, 2000);

        });

    })
}

function createPlayer(playerObject) {

    return "<p>" + playerObject.Name + "</p><p>" + playerObject.Club.Name + "</p><p>" + numberWithCommas(playerObject.Value) + "£</p><p>" + playerObject.Position + "</p><span class='attributes'>" + setTechnicalAttributes(playerObject) + "</span>"
}

function setTechnicalAttributes(playerObject) {
    return "<p>Corners: " + playerObject.CornerKick + "</p><p>Crossing: " + playerObject.Crossing + "</p><p>Dribbling: " + playerObject.Dribbling + "</p><p>Finishing: " + playerObject.Finishing + "</p><p>First Touch: " + playerObject.FirstTouch + "</p><p>Freekick: " + playerObject.FreeKick + "</p><p>Heading: " + playerObject.Heading + "</p><p>Longshot: " + playerObject.Longshot + "</p><p>Long Throw: " + playerObject.LongThrow + "</p><p>Marking: " + playerObject.Marking + "</p><p>Passing: " + playerObject.Passing + "</p><p>Penalty: " + playerObject.PentaltyKick + "</p><p>Tackling: " + playerObject.Tackling + "</p><p>Technique: " + playerObject.Technique + "</p>"
}
    
function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}
