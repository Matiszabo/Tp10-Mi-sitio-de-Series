function MostrarActores(idS) {
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarActoresAjax',
            data: { idSerie: idS },
            success:
                function (response) {
                    $("#contenidoModal").html(response.nombreActor);
                }
        }
    )
}

function MostrarMasInfo(idS) {
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarInfoSeriesAjax',
            data: { idSerie: idS },
            success:
                function (response) {
                    $("#contenidoModal").html(response.sinopsis);
                }

        }
    )
}

function MostrarTemporadas(idS) {
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarTemporadasAjax',
            data: { idSerie: idS },
            success:
                function (response) {
                    var contenido = "";
                    response.forEach(element => {
                        contenido += "<li>" + element.tituloTemporada + "</li>";
                    });
                    $("#contenidoModal").html(contenido);
                }

        }
    )
}