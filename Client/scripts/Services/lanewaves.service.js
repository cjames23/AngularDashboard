(function () {
    'use strict';
    angular
        .module('wavesService', ['ngResource'])
        .factory('wavesService', LaneWaves);

    LaneWaves.$inject = ['$resource'];

                 function LaneWaves($resource) {
                     return $resource("/api/LaneWaves", {}, {
                         query: { method: 'GET', cache: false, isArray: true },
                     });
                 }
})();