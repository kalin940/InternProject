/// <reference path="jquery-3.1.0.js" />
/// <reference path="knockout-3.4.0.js" />
/// <reference path="jquery.shorten.1.0.js" />

$(function () {
    $.get("http://localhost:49557/api/Partners", function (data) {
        let numberofObjects = Object.keys(data).length;
        for (let i = 0; i < numberofObjects; i++) {
            data[i].Logo = "data:image/gif;base64," + data[i].Logo;
        }
        ko.applyBindings({
            info: data
        });
        $('.info-short').shorten({
            "showChars": 50
        });
    }, "json");
});