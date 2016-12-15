/// <reference path="jquery-3.1.0.js" />
/// <reference path="knockout-3.4.0.js" />
$(function () {
    $.get("http://localhost:55158/api/Values", function (data) {
          alert(data)
        }, "json");    
});

