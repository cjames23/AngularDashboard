(function () {
    'use strict';
    angular
        .module('totesService', ['ngResource'])
        .factory('totesService', totesService);

    totesService.$inject = ['$resource'];

    function totesService($resource) {
        return $resource("/api/AgingTotes", {}, {
            query: { method: 'GET', cache: false, isArray: true },
        });
    }
})();