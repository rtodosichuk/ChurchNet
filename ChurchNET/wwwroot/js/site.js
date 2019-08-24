// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function () {
    $(".sidenav").sidenav();
    $('.tooltipped').tooltip();
    $("aside").pushpin({
        top: 600,
        bottom: 5000,
        offset: 0
    });
});