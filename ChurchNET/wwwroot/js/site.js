// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function () {
    $(".sidenav").sidenav();    
    $("aside").pushpin({
        top: 650,
        bottom: 1700,
        offset: 0
    });
});