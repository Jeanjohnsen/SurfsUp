// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//Makes the navbar transparent on scroll
$(window).scroll(function() {
    var offset = $(window).scrollTop();
    console.log(offset);
    $('header').toggleClass('trans', offset > 50);
  });

// $('.navTrigger').click(function () {
//     $(this).toggleClass('active');
//     console.log("Clicked menu");
//     $("#mainListDiv").toggleClass("show_list");
//     $("#mainListDiv").fadeIn();

// });