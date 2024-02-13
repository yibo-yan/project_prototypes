$(document).ready(function(){
    $("#htmlButton").click(function(){
        $("#htmlExample").html("<h1>HELLO <h1>");
    });
    $("#textButton").click(function(){
        $("#htmlExample").text("<h1>HELLO <h1>");
    });
    $("#appendButton").click(function(){
        $("#htmlExample").append("<h1>HELLO <h1>");
    });
    $("#cssButton").click(function(){
        $("#cssExample").css("background","green");
    });
    $("#addButton").click(function(){
        $("#cssExample").addClass("customClass")
    });
    $("#removeButton").click(function(){
        $("#cssExample").removeClass("customClass")
    });
});