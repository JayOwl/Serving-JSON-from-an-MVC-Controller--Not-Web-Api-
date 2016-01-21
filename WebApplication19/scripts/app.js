$(document).ready(function () {
    $("#btnGetManufacturers").click(function () {
        var actionUrl = "http://jsonmvc.jamped.com/Home/Manufacturer";
        $.getJSON(actionUrl, displayData);
    });

    function displayData(response) {
        if (response != null) {
            for (var i = 0; i < response.length; i++) {
                $("#manufacturerList").append("<li>" + response[i].mfg + " "
                + response[i].mfgDiscount + "</li>")
            }
        }
    }
});