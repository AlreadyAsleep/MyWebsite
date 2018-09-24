var track = (function ($) {
    var module = function () {}
    
    module.onReady = function () {
        gtag('config', 'UA-126339730-1');
        gtag('event', 'page_view', { 'send_to': 'UA-126339730-1' });
    }

    return module;
}(jQuery));