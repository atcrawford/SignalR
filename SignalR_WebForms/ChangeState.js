/// <reference path="../Scripts/jquery-1.9.1.js" />
/// <reference path="../Scripts/jquery.signalR-1.0.1.js" />
/// <reference path="../Scripts/jquery-ui-1.8.20.js" />
$(function () {

    var hub = $.connection.changeState;
    
    hub.client.stateChanged = function (stall) {
        var $stall = $(stall.CompositeId);
        
        if (stall.IsOccuppied == true) {
            $stall.css("background-color","red");
        } else {
            $stall.css("background-color", "green");
        }
        
        $stall.show();
    };

    $.connection.hub.start().done(function () {
        var $stall = $(".stall");

        $stall.click(function () {
            hub.server.changeState('#' + this.id);
        });

        hub.server.getState();
    });

});