(function () {
    'use strict';

    angular
        .module('PickExceptionController',['pickExceptService'])
        .controller('PickExceptionController', PickExceptionController);

    PickExceptionController.$inject = ['$scope', '$interval', 'pickExceptService'];

    function PickExceptionController($scope, $interval, pickExceptService) {
        $scope.pickerexcepts = pickExceptService.query();
        $interval(function () {
            $scope.pickerexcepts = pickExceptService.query();
        }, 300000);
    }
})();
