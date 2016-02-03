(function () {
    'use strict';

    angular
        .module('messageCtrl',['ngAnimate','toaster'])
        .controller('messageCtrl', message);

    message.$inject = ['$scope', 'toaster']; 

    function message($scope, toaster) {
        $scope.pop = function pop() {
            toaster.pop('success', "", "Your Message Has Been Sent!");
        };

    };
})();
