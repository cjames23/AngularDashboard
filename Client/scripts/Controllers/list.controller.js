(function () {
    'use strict';
    angular
        .module('picksController',['picksService'])
       /* Controller for The Lane Picks Table to display table data */
       .controller('picksController', PicksController);

    PicksController.$inject = ['$scope', '$interval', 'picksService'];

    function PicksController($scope, $interval, picksService) {
        $scope.picks = picksService.query();
           $interval(function() {
                $scope.picks = picksService.query()
            },100000);
          
        }
})();