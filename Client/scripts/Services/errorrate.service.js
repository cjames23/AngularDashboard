(function () {
    'use strict';
    angular
        .module('errorRateService', ['ngResource'])
        .factory('errorRateService', errorRate);

    errorRate.$inject = ['$resource'];

    function errorRate($resource) {
        return $resource("/api/CurrentErrorRate", {}, {
            query: { method: 'GET', cache: false, isArray: true },
        });
    }
})();