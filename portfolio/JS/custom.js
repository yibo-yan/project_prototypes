$(document).ready(function(){
    $('#cookieBanner').slideDown();
      $('#closeBanner').on('click', function() {
        $('#cookieBanner').slideUp();
    });
    $("#scrollToCV").click(function() {
      $('html, body').animate({
          scrollTop: $("#CV").offset().top
      }, 1000);
    });
    $("#scrollToContact").click(function() {
      $('html, body').animate({
         scrollTop: $("#contact").offset().top
    }, 1000);
    });
});