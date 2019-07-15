window.onload = function () {


    var t = setInterval(checkIfReady, 1000);


    function checkIfReady() {
        let leagueChosen = $("#leagues").val();
        let player1 = $("#player1").val() != null && $("#player1").val() != "" ; 
        let player2 = $("#player2").val() != null && $("#player2").val() != "";
        let budget = $("#budget").val() != null && $("#budget").val() != "";

        let ready = (leagueChosen.length > 0 && player1 && player2 && budget)
        if (ready) {

            $(".start").attr("disabled", false);
          //  $(".start").attr("class", "start-ready");

            //css("background-color", "green");
        }
        else {
            $(".start").attr("disabled", true);

        }


    }

}

