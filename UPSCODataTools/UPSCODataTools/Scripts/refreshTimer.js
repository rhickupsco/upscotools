       $(document).ready(function () {
           $("#Summary").load();
           setInterval(function () {
               $("#Summary").reload()
           }, 90000);
       });
