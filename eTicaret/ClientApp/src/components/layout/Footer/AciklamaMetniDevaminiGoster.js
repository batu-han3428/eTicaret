﻿import $ from "jquery";

$(function () {

        $(".hr").css("display", "none");

        $('#aciklamaMetniLink').mouseup(function(){

            if($("#devaminiGoster").css("display") === "none"){
                 $(this).text("Devamını Gizle");

            }else if($("#devaminiGoster").css("display") === "inline"){

                $(this).text("Devamını Göster");

            }
                 
        });
        
});