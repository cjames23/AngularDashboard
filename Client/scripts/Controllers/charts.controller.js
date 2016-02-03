(function () {
    'use strict';
    /*Controller for Lane Waves Table to display table data */
    angular
            .module('graphCtrl', ['chart.js','shipService','oService'])
			.controller('graphCtrl', graphCtrl);

    graphCtrl.$inject = ['$scope', 'shipService','oService'];

    function graphCtrl($scope, shipService, oService) {
        var data = shipService.query(
        function loadData()
        {
            var chartData = [];
            var chartLabels = [];
            for (var i = 0; i < data.length; i++) {
                chartData.push(data[i].Units);
                chartLabels.push(data[i].OrderType);
            }
            $scope.labels = chartLabels;
            $scope.data = chartData;
        });
        };
})();