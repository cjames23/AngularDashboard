(function () {
    'use strict';
    /*Controller for Aging Work Orders data */
    angular
            .module('orderAgeCtrl', ['orderAgeService'])
			.controller('orderAgeCtrl', orderAgeCtrl);

    orderAgeCtrl.$inject = ['$scope', '$interval', 'orderAgeService'];

    function orderAgeCtrl($scope, $interval, orderAgeService) {
        $scope.orderAge = orderAgeService.query();
        $interval(function () {
            $scope.orderAge = orderAgeService.query();
        }, 500000);
    };
})();
