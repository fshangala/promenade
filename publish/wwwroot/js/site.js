﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
tinymce.init({
    selector: "textarea",
});
$(document).ready(function() {  
    $('#btnValue').click(function() {  
        $("#divkarea").html("");  
        var content = tinymce.get("txtarea").getContent();  
        $("#divkarea").html(content);  
    });  
}); 