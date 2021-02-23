$(() => {
    $("#name").on('input', function() {
        ensureFormValidity();
    });

    $("#age").on('input', function () {

        const age = parseInt($("#age").val());

        if (age > 50) {
            $("#newsletter").prop('checked', true);
            $("#newsletter").prop('disabled', true);
            $("form").append("<input type='hidden' name='SignupToNewsletter' value='true' id='hidden-news' />");
        } else {
            $("#newsletter").prop('disabled', false);
            $("#hidden-news").remove();
        }

        ensureFormValidity();
    });

    //$("form").on('submit', function() {
    //    $("#newsletter").prop('disabled', false);
    //});

    function ensureFormValidity() {
        const name = $("#name").val();
        const age = $("#age").val();

        const isValid = name && age;
        $("#save-button").prop('disabled', !isValid);
    }
});