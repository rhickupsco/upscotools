$(document).ready(function () {
    setInterval(function () {
        var date = new Date();
        $('#show').text(date.toLocaleString());
       
    }, 1000);


    setInterval(function () {
        location.reload();
    }, 120000);


});


