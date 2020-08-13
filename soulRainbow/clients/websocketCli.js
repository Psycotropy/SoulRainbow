'use strict';
document.open();
//replace with your websocket server
//ws://192.168.1.229:3333
let socket = new WebSocket("wss://echo.websocket.org");
let message = "Some string message";
socket.onopen = function(e){
    document.write("[open] connection established" + "<br>");
    document.write("[*] sending to the server" + "<br>");
    //socket.send(message);
    sendDataWithInterval();
};

socket.onmessage = function(event){
    document.write("------------------" + "<br>");
    document.write(`[message] recived from the server :  ${event.data}`);
};

socket.onclose = function(event){
    if(event.wasClean){
        document.write(`[close] COnnection closed cleanly, code=${event.code} reason=${event.reason} <br>`);

    }else{
        document.write("[close] connection died <br>");
    }

};

socket.onerror = function(error){
    document.write(`[error] ${error.message}`);
};

//this method is ideal with low speed connections
function sendDataWithInterval(){
    setInterval(() => {
        if(socket.bufferedAmount == 0){
            socket.send("cadena enviada desde la funcion setInterval");
        }
    }, 500);
}

 