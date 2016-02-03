(function () {
    'use strict';
    angular
        .module('picksService', ['ngResource'])
        .factory('picksService', LanePicks);

    LanePicks.$inject = ['$resource'];

            function LanePicks($resource) {
                return $resource("/api/LanePicks", {}, {
                    query: { method: 'GET', cache: false, isArray: true },
                });
            }
})();