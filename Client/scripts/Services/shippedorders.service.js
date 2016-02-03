(function () {
    'use strict';
    angular
        .module('shipService', ['ngResource'])
        .factory('shipService', ShipOrders);

    ShipOrders.$inject = ['$resource'];

    function ShipOrders($resource) {
        return $resource("/api/CurrentShippedOrders");
    }
})();