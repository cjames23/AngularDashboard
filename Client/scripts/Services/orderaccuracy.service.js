(function () {
    'use strict';

    angular
        .module('oService', ['ngResource'])
        .factory('oService', orderaccuracy);

    orderaccuracy.$inject = ['$resource'];

    function orderaccuracy($resource) {
        return $resource('/api/InspOrderAccuracy');

  
    }
})();