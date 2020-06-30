var previousTextNum = 0;
var isFirst = true;
function Choose(td_id)
{
    if (isFirst != true)
    {
        document.getElementById("chosen").id = "";
    }
    else
    {
        isFirst = false;
    }
    document.getElementById(td_id).childNodes[1].id = "chosen";
    document.getElementById("chosenroomnumber").value = document.getElementById("chosen").value;
}
function phoneCheck()
{
    var text = document.getElementById("phonenumber").value;
    if (text.length == 5 || text.length == 9 || text.length == 12)
    {
        if (previousTextNum <= text.length) {
            text += "-";
        }
        else
        {
            text = text.substr(0,text.length-1);
        }
    }
    previousTextNum = text.length;
    document.getElementById("phonenumber").value = text;
}