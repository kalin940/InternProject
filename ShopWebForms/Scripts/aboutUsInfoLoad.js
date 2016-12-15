/// <reference path="jquery-3.1.0.js" />
/// <reference path="knockout-3.4.0.js" />
/// <reference path="jquery.shorten.1.0.js" />
$(function () {
    let obj;
    $.get("http://localhost:49557/api/Infoes", function (data) {
        obj = data[0];
        //ko.applyBindings({
        //    info: obj
        //});      
        let address = obj.Address.split(",").join("<br/>")
        
        $('#about-us-all-info').html(obj.GeneralInfo + '<br/>' + obj.AllInf);
        $('#about-us-address').html("<h4>Address:</h4>"+address);
        $('#about-us-phone').html("<h4>Phone:</h4>" + obj.Phone);
        $('#about-us-email').html("<strong>Owner:</strong> <a href=\"#\">"+obj.Email+"</a>");
    }, "json");
    $.get("http://localhost:49557/api/OurWorks", function (data) {
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