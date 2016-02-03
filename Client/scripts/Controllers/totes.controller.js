(function () {
    'use strict';
    /*Controller for Aging Work Orders data */
    angular
            .module('totesCtrl', ['totesService'])
			.controller('totesCtrl', totesCtrl);

    totesCtrl.$inject = ['$scope', '$interval', 'totesService'];

    function totesCtrl($scope, $interval, totesService) {
        $scope.totes = totesService.query();
        $interval(function () {
            $scope.totes = totesService.query();
        }, 500000);
    };
})();