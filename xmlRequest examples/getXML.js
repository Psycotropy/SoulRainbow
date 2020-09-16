function start(){
    dataZone = document.getElementById("dataZone");
    var button = document.getElementById("button");

    button.addEventListener("click", read, false);
}

function read(){
    var url = 'http://192.168.1.229:5555/index/startControl.xml'

    var request = new XMLHttpRequest();

    request.addEventListener("load", show, false);

    request.open('POST', url, true);

    //add a custom header to the request to be indentified by the server
    request.setRequestHeader("soulrainbow|xml", "XML");

    request.send(null);
}

function show(e){
    
    dataZone.innerHTML = e.target.responseText;
    
}

window.addEventListener("load", start, false);







