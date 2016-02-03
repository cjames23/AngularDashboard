(function () {
    'use strict';

    angular
        .module('errorRateCtrl',['errorRateService'])
        .controller('errorRateCtrl', errorRateCtrl);

    errorRateCtrl.$inject = ['$scope', '$interval', 'errorRateService'];

    function errorRateCtrl($scope, $interval, errorRateService) {
        $scope.errorRate = errorRateService.query();
        $interval(function () {
            $scope.errorRate = errorRateService.query();
        }, 500000);
    };
})();
