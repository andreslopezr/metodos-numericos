// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function writeInput (char)
{
    if (isNaN(e) || notEqual(char, e[e.length-1]))
    {
        var e = document.forms["equation"].elements["equa"].value;
        document.forms["equation"].elements["equa"].value = "";
        e += char
        document.forms["equation"].elements["equa"].value = e;
    }
}

function deleteInput()
{
    var e = document.forms["equation"].elements["equa"].value;
    e = e.slice(0, e.length-1)
    document.forms["equation"].elements["equa"].value = e;
}

function notEqual(char, last)
{
    var charIsOperator = false;
    var lastIsOperator = false;
    if (char == '+' || char == '-' || char == '/' || char == '*' || char == "^")
        charIsOperator = true;
    if (last == '+' || last == '-' || last == '/' || last == '*' || last == "^")
        lastIsOperator = true;

    if (charIsOperator && lastIsOperator)
        return true
    else
        return false
}

