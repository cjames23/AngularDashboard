(function () {
    'use strict';
    angular
        .module('pickExceptService', ['ngResource'])
        .factory('pickExceptService', PickExcepts);

    PickExcepts.$inject = ['$resource'];

    function PickExcepts($resource) {
        return $resource("/api/exceptions", {}, {
            query: { method: 'GET', cache: false, isArray: true },
        });
    }
})();