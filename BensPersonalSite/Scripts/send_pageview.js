(function ($) {
    var module = function () {
        $.ready(function () {
            // Creates the default tracker.
            ga('create', 'UA-126339730-1', 'auto');

            // Uses the default tracker to send a pageview to the
            // Google Analytics property with tracking id UA-126339730-1
            ga('send', 'pageview');
        });}
    return module;
}(jQuery));