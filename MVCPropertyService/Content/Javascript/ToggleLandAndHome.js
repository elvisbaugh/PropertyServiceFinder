

$(document).ready(function(){
  $("#House").click(function () {
  
    $("#propertyType").fadeIn(3000);
    $("#displayMyImages").fadeOut(1000);
    $("#displayMyImages").fadeIn(3000);
    $("#displayMyImages").load("/PropertyLocation/GetView",
           { parish: $("title").text(), propertyType: "House" });
 
  });


  $("#Land").click(function () {
    
    $("#propertyType").fadeIn(3000);
    $("#displayMyImages").fadeOut(1000);
    $("#displayMyImages").fadeIn(3000);
    $("#displayMyImages").load("/PropertyLocation/GetView",
           { parish: $("title").text(), propertyType: "Land" });
   

  });

});