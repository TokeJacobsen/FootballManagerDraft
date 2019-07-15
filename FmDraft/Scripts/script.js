var turnArray = [];
var currentTurn = 0;
var symbol = "";
window.onload = function () {

    symbol = $("#valuta").html();
    alert(symbol)

    let notReady = true;
    do {
    var starter = prompt("Who will pick first?", "1 OR 2");

        if (starter == 1 || starter == 2) {
            notReady = false;
            if (starter == 1) {
                turnArray = [1,2,2,1];
            }
            else {
                turnArray = [2,1,1,2];
            }
        }
        else {
            alert("Please input 1 or 2")
        }
    } while (notReady)
    

        if (getTurn() == 1) {
            $(".Player2").prop("disabled", true);
        }
        else {
            $(".Player1").prop("disabled", true);

        }
    

        $('.Player').click(function (event) {
            let activePlayer;
            if (event.currentTarget.id <= 18) {
                activePlayer = 1;
            }
            else {
                activePlayer = 2;
            }

        $("#myModal").modal();
        $.post("/draft/GetFive", { position: event.currentTarget.innerHTML }, function (data) {
            $("#" + event.currentTarget.id).prop("disabled", true);
            let counter = 0;
            let choiceInterval = setInterval(function () {
                console.log(data[counter])
                $("#choice" + counter).val('{"activePlayer" : ' + activePlayer + ', "playerId" : ' + data[counter].Id + ', "positionId" : "' + "#" + event.currentTarget.id + '", "name":"' + data[counter].Name + '", "club":"' + data[counter].Club.Name + '", "price" : "' + data[counter].Value + '" }');
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
        let currentBudget = stringToNumber($("#p" + buttonValue.activePlayer + "Budget").html());
        $("#p" + buttonValue.activePlayer + "Budget").html(numberWithCommas(currentBudget - buttonValue.price) + " " + symbol)

        $.post("/draft/select", { playerId: buttonValue.playerId, activePlayerId: buttonValue.activePlayer }, function (data) {
         
        });

        if (getTurn() == 1) {
            $(".Player2").prop("disabled", true);
            $(".Player1").prop("disabled", false);
        }
        else {
            $(".Player1").prop("disabled", true);
            $(".Player2").prop("disabled", false);
        }
    });




}

function createPlayer(playerObject) {

    return "<p>" + playerObject.Name + "</p><p>" + playerObject.Club.Name + "</p><p>" + numberWithCommas(playerObject.Value) + " " + symbol +"</p > <p>" + playerObject.Position + "</p> <span class='attributes'>" + setTechnicalAttributes(playerObject) + setMentalAttributes(playerObject) + setPhysicalAttributes(playerObject) + "</span>"
    }



function setTechnicalAttributes(playerObject) {
    if (playerObject.Position == "GK") {
        return "<div class='attributeSet'><p>Aerial reach: " + playerObject.Aerial + "</p><p>CommandOfArea: " + playerObject.CommandOfArea + "</p><p>Communication: " + playerObject.Communication + "</p><p>Eccentricity: " + playerObject.Eccentricity + "</p><p>First Touch: " + playerObject.FirstTouch + "</p><p>Handling: " + playerObject.Handling + "</p><p>Kicking: " + playerObject.Kicking + "</p><p>OneOnOne: " + playerObject.OneOnOne + "</p><p>Passing: " + playerObject.Passing + "</p><p>Reflexes: " + playerObject.Reflexes + "</p><p>RushingOut: " + playerObject.RushingOut + "</p><p>TendencyToPunch: " + playerObject.TendencyToPunch + "</p><p>Throwing: " + playerObject.Throwing + "</p></div>"

    } else {
        return "<div class='attributeSet'><p>Corners: " + playerObject.CornerKick + "</p><p>Crossing: " + playerObject.Crossing + "</p><p>Dribbling: " + playerObject.Dribbling + "</p><p>Finishing: " + playerObject.Finishing + "</p><p>First Touch: " + playerObject.FirstTouch + "</p><p>Freekick: " + playerObject.FreeKick + "</p><p>Heading: " + playerObject.Heading + "</p><p>Longshot: " + playerObject.Longshot + "</p><p>Long Throw: " + playerObject.LongThrow + "</p><p>Marking: " + playerObject.Marking + "</p><p>Passing: " + playerObject.Passing + "</p><p>Penalty: " + playerObject.PentaltyKick + "</p><p>Tackling: " + playerObject.Tackling + "</p><p>Technique: " + playerObject.Technique + "</p></div>"

    }
}

    function setMentalAttributes(playerObject) {
        return "<div class='attributeSet'><p>Aggression: " + playerObject.Aggression + "</p><p>Anticipation: " + playerObject.Anticipation + "</p><p>Bravery: " + playerObject.Bravery + "</p><p>Composure: " + playerObject.Composure + "</p><p>Concentration: " + playerObject.Concentration + "</p><p>Decisions: " + playerObject.Decisions + "</p><p>Determination: " + playerObject.Determination + "</p><p>Flair: " + playerObject.Flair + "</p><p>Leadership: " + playerObject.Leadership + "</p><p>Off The Ball: " + playerObject.OffTheBall + "</p><p>Positioning: " + playerObject.Positioning + "</p><p>Teamwork: " + playerObject.Teamwork + "</p><p>Vision: " + playerObject.Vision + "</p><p>Workrate: " + playerObject.Workrate + "</p></div>"
    }

    function setPhysicalAttributes(playerObject) {
        return "<div class='attributeSet'><p>Acceleration: " + playerObject.Acceleration + "</p><p>Agility: " + playerObject.Agility + "</p><p>Balance: " + playerObject.Balance + "</p><p>JumpingReach: " + playerObject.JumpingReach + "</p><p>NaturalFitness: " + playerObject.NaturalFitness + "</p><p>Pace: " + playerObject.Pace + "</p><p>Stamina: " + playerObject.Stamina + "</p><p>Strength: " + playerObject.Strength + "</p><p>__________</p><p>Height: " + playerObject.Height + "</p><p>Weight: " + playerObject.Weight + "</p><p>Age: " + playerObject.Age + "</p><p>Nationality: " + playerObject.Nationality + "</div>"
    }

    function numberWithCommas(x) {
        return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
    }

function stringToNumber(value) {
    return value.replace(".", "").replace("£", "").replace("DKK","").split(",").join("")
    }

function getTurn() {
        let turn = turnArray[currentTurn]
        if (currentTurn == 3) {
            currentTurn = 0;
        }
        else {
            currentTurn++;
        }
        return turn;


    }