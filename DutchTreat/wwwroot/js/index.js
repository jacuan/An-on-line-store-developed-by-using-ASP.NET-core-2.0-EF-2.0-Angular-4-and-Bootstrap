$(document).ready(function () {
    console.log("Hello!");

    //var theForm = document.getElementById("theForm");
    //theForm.hidden = true;
    var theForm = $("#theForm");
    theForm.hide();

    //var button = document.getElementById("buyButton");
    //button.addEventListener("click", function () {
    //    console.log("Buying Item");
    //});

    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Buying Item");
    });

    //var productInfo = document.getElementsByClassName("product-props");

    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });

    //By Convention, we should declare variable like this: var $.... to indicate this is a jQuery varable.
    //So the examples before this line (above), is not 100% percise. 
    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
       // $popupForm.toggle(1000);
        $popupForm.fadeToggle(1000);
    });








});


