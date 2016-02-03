(function () {
    'use strict';
    angular
        .module('workOrderService', ['ngResource'])
        .factory('workOrderService', WorkOrders);

    WorkOrders.$inject = ['$resource'];

    function WorkOrders($resource) {
        return $resource("/api/WorkOrderCount", {}, {
            query: { method: 'GET', cache: false, isArray: true },
        });
    }
})();