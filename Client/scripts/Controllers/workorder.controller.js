(function () {
    'use strict';
    /*Controller for Aging Work Orders data */
    angular
            .module('workOrderCtrl', ['workOrderService'])
			.controller('workOrderCtrl', workOrderCtrl);

    workOrderCtrl.$inject = ['$scope', '$interval', 'workOrderService'];

    function workOrderCtrl($scope, $interval, workOrderService) {
        $scope.workOrderCount = workOrderService.query();
        $interval(function () {
            $scope.workOrderCount = workOrderService.query();
        }, 500000);
    };
})();