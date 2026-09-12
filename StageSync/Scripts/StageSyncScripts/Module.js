// Angular module definition required by Controller.js and Service.js
(function(window, angular) {
    'use strict';

    // Define a global 'app' Angular module so other scripts can reference it
    var app = angular.module('StageSyncModule', []);

    // Expose to global scope to match other scripts that expect window.app
    window.app = app;

})(window, window.angular);

