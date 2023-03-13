function Atvalt()
{

    var KelvinRDB=document.getElementById('RDB1')
    var FahrennheintRDB=document.getElementById('RDB2')
    var Celsiusfok=parseFloat(document.getElementById('CelsiusfokTXT').value)
    var Kelvinfok=0;
    var Fahrennheintfok=0;

    if (KelvinRDB.checked==true)
    {
        Kelvinfok=Celsiusfok+278,15;
        document.getElementById('KelvinfokTXT').value=Kelvinfok;

    }
    else if(FahrennheintRDB.checked==true)
    {
        Fahrennheintfok=Celsiusfok*1.8+32;
        document.getElementById('FahrenheitfokTXT').value=Fahrennheintfok;
    }
    else
    {
        alert("Nem választotta ki milyen hőmérsékletbe szeretne váltani")

    }   
}   
function Torles()
{
    document.getElementById('FahrenheitfokTXT'),value="";
    document.getElementById('KelvinTXT'),value="";
    document.getElementById('CelsiusfokTXT'),value="";
    document.getElementById('RDB1').checked = false;
    document.getElementById('RDB2').checked = false;
}