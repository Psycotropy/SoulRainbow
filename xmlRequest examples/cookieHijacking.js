function start(){
    var button = document.getElementById("button");
    button.addEventListener("click", read, false);
}

function read(){
    var url2 = 'http://192.168.1.229:5555/index/startControl.xml'

    var request = new XMLHttpRequest();

    request.open('POST', url2, true);

    //add a custom header to the request to be indentified by the server
    solicitud.setRequestHeader("soulrainbow|cookies", "cookies");
	
    //cookie sending example
    solicitud.send("ssid=123123123123123");
}


window.addEventListener("load", start, false);