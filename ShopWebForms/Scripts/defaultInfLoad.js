$(function () {
    let obj;
    $.get("http://localhost:49557/api/Infoes", function (data) {
        obj = data[0];
        //ko.applyBindings({
        //    info: obj
        //});      
        $('#default-general-info').html(obj.GeneralInfo +"<br/>");
    }, "json");
});