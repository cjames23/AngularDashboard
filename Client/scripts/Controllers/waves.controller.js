(function () {
	'use strict';
	/*Controller for Lane Waves Table to display table data */
    angular
            .module('waveController',['wavesService'])
			.controller('waveController', WaveController);

    WaveController.$inject = ['$scope', '$interval', 'wavesService'];

    function WaveController($scope, $interval, wavesService) {
        $scope.waves = wavesService.query();
        $interval(function () {
            $scope.waves = wavesService.query();
        }, 500000);
    };
})();