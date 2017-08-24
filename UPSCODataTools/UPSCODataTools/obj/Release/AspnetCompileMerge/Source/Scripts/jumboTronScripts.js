$(document).ready(function () {
    setInterval(function () {
        var date = new Date();
        $('#time').text(date.toLocaleString());
       
    }, 1000);


    setInterval(function () {
        location.reload();
    }, 12000);


});


