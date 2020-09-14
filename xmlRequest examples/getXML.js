function comezar(){
    zonadatos = document.getElementById("dataZone");
    var boton = document.getElementById("button");

    boton.addEventListener("click", leer, false);
}

function leer(){
    var url = 'file:///E:/Tools/soulRainbow/servers/SoulRainbow/SoulRainbow/www/routing.txt';
    var url2 = 'http://192.168.1.229:5555/index/startControl.xml'

    var solicitud = new XMLHttpRequest();

    
        

    solicitud.addEventListener("load", mostrar, false);

    solicitud.open('GET', url2, true);

    //add a custom header to the request to be indentified by the server
    solicitud.setRequestHeader("soulrainbow|XML", "XML");

    solicitud.send(null);
}

function mostrar(e){
    
    zonadatos.innerHTML = e.target.responseText;
    
}

window.addEventListener("load", comezar, false);







