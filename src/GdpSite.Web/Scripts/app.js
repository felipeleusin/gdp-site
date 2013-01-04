$(function() {
    var formContato = $("#form-contato").on("submit", function (ev) {
        ev.preventDefault();
        
        $.ajax({
            url: "/contato",
            type: "POST",
            data: formContato.serialize()
        }).done(function() {
            formContato[0].reset();
            $("#modal-contato").modal();

            setTimeout(function() {
                $("#modal-contato").modal("hide");
            }, 2000);
        });
    });
});