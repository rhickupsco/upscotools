 var domain = "@upscoinc.com";

 $(document).ready(function () {
     //this sets the focus on the first textbox of the form
     $("#ContentPlaceHolder1_DetailsView1 input:text").eq(0).focus();

     //this grabs the first character of the first name field 
     //and concatenates its value with the last name and adds it to the username field on key up
     $("#ContentPlaceHolder1_DetailsView1___FirstName_TextBox1").keyup(function () {         
        var userName = $("#ContentPlaceHolder1_DetailsView1___FirstName_TextBox1").val().substring(0,1) +
      $("#ContentPlaceHolder1_DetailsView1___LastName_TextBox1").val();
        $("#ContentPlaceHolder1_DetailsView1___UserName_UserName").val(userName);
    });

    $("#ContentPlaceHolder1_DetailsView1___LastName_TextBox1").keyup(function () {
        var userName = $("#ContentPlaceHolder1_DetailsView1___FirstName_TextBox1").val().substring(0,1) +
      $("#ContentPlaceHolder1_DetailsView1___LastName_TextBox1").val();
        //this builds an email address from the userName variable and the domain name set at top
        var emailAddress = userName + domain;
        $("#ContentPlaceHolder1_DetailsView1___UserName_UserName").val(userName);
        $("#ContentPlaceHolder1_DetailsView1___EmailAddress_TextBox1").val(emailAddress);
    });
});
