var myVideo = document.getElementById("video"); 

function vidSwap(vidURL) {
var myVideo = document.getElementsByName('video')[0];
myVideo.addEventListener("onmouseleave", toggle);
myVideo.src = vidURL;
}

function toggle(){
   var myVideo = document.getElementsByName('video')[0];
    if(myVideo.paused) {
        myVideo.play();
    }
    else {
        myVideo.pause();
    }
    return false;
}


