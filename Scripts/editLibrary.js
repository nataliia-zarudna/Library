$(document).ready(init);

function init() {
    
    $("#genreTitle").on("blur", function (e, data) {

        $("#updateGenre").submit();

    });

}