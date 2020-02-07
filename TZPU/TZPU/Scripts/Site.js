$(document).ready(function () {
    if ($("#question-submit").length != 0) {
        $("#question-submit").on("click", function () {
            submitAnswer();
        })
    }
})


function submitAnswer() {
    $("#question-submit").attr("disabled", true);
    $("#question-submit").html('<span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>'
        +'< span class= "sr-only" > Učitavam...</span >')

    if ($(".answer-radio-button").length == 0) {
        $.ajax({
            url: "/question/NumberOfYears?years=" + $("#child-age").val(),
            success: function (result) {
                $(".question-container").html(result);
            }
        });
    }
    else {
        if ($(".answer-radio-button:checked").length == 0) {
            alert("Morate izabrati odgovor!");
            return
        }
        else {
            $.ajax({
                url: "/question/Answer?answer=" + $(".answer-radio-button:checked").attr("id"),
                success: function (result) {
                    $(".question-container").html(result);
                }
            });
        }
    }
}