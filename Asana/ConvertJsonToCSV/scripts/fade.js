$('document').ready(function () {
    $('#btnConvert').click(function () {
        $('#btnConvert').finish().delay(5000).fadeOut('slow', function () {
            $('#scoreCard').fadeIn('slow');
        });
    })
});

