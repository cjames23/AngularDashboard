(function () {
    'use strict';
    angular
        .module('orderAgeService', ['ngResource'])
        .factory('orderAgeService', orderAge);

    orderAge.$inject = ['$resource'];

    function orderAge($resource) {
        return $resource("/api/AverageOrderAges", {}, {
            query: { method: 'GET', cache: false, isArray: true },
        });
    }
})();