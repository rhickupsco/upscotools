 



$(document).ready(function(){

        onDeviceReady();
        $('button#add').bind("click", function(){
            console.log('Got Link Info');
            insertItem();
        });
        $('button#add').bind("onKeyDown", function(){
            console.log('Got Link Info');
            insertItem();
        });
    });

    var listElement = $('#links');
    var messageElement = $('#message');
    var db;

    function getDatabase(){
        return window.openDatabase("myLinks","1.0","myLinks Database", 200000);
    }

    function insertItem(){
        console.log('Entering insertItem Function');

        var insertNameValue = document.getElementById('linkInput').value;
        var insertURLValue = document.getElementById('linkURLInput').value;
        console.log(insertNameValue.trim() & insertURLValue.trim())
      
        var sqlCommand = 'INSERT into links (strName, strLinkURL) VALUES ("' + insertNameValue + '","' + insertURLValue + '")';

       // console.log('Attemting to write ' + sqlCommand);
        db.transaction(function(tx){
            tx.executeSql(sqlCommand)
        }, databaseError, getItems);
        
        document.getElementById('linkInput').value = '';
        document.getElementById('linkURLInput').value = '';
        
        console.log('Done inserting item into db');
    }

    //get the items from the database
    function getItems(){
        console.log('Entering getItems Function');
        db.transaction(function(tx) {
            tx.executeSql('Select * from links', [], querySuccess, databaseError);
        }, databaseError);
        console.log('Leaving getItems Function');
    }

    function querySuccess(tx, results){
        console.log('Data returned successfully');
        displayData(tx,results);

    }

    function databaseError(){
        console.log('Failed to retrieve Links from Database');
        messageElement.html("SQL Error: " + error.code);
    }

    function displayData(tx,results){
        var len = results.rows.length;
        var output = '';

        for (var i = 0; i<len; i++) {
            output = output + '<li id="' + results.rows.item(i).id + '"><img src="favicon.ico" class="img-circle" width="30" height="30" style="padding-right:10px; margin-top:-5px;" ><a href="' + results.rows.item(i).strLinkURL + '" target="_blank">' + results.rows.item(i).strName + '</a></li>';
        }  
        
        document.getElementById('links').innerHTML = output;
        document.getElementById('message').innerHTML = 'You have ' + len + ' personal links to display';
        console.log('Leaving querySuccessFunction');
        $('#links').listElement
    }

    function clearAll() {
        console.log('Clearing Database');
        db.transaction(function(tx) {
            tx.executeSql( 'DELETE FROM links');
        }, databaseError, getItems);

        document.getElementById('links').value = '';
        return false;
    }

    //One day ... TODO ---- Clear one link from list
   /* function clearOne(){
         console.log('Removing link');
        db.transaction(function(tx,linkName) {
            tx.executeSql( 'DELETE FROM links where strName = linkName + "')
        }, databaseError, getItems);

        document.getElementById('links').value = '';
        return false;
    } 
    */
    

    //device is ready
    function onDeviceReady(){
        db=getDatabase();
        console.log('Creating WEB SQL Database named LINKS')
        db.transaction(function(tx){
           // tx.executeSql('DROP TABLE links');
        tx.executeSql('CREATE TABLE IF NOT EXISTS links (id Integer PRIMARY KEY AUTOINCREMENT, strName, strLinkURL)');
        }, databaseError, getItems);
    }