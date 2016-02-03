(function () {
    'use strict';
    angular.module("lanePicks", ['ngRoute', 'ngAnimate', 'toaster', 'chart.js', 'picksController', 'waveController','workOrderCtrl','orderAgeCtrl','graphCtrl', 'messageCtrl', 'picksService','workOrderService', 'wavesService', 'shipService', 'oService', 'pickExceptService', 'orderAgeService','PickExceptionController', 'errorRateService','errorRateCtrl','totesCtrl','totesService'])
        .config(config)
    .filter('percentage', function(){
        return function (input) {
            if (isNan(input)) {
                return input;
            }
            return Math.floor((input * 100)/ 100) +'%';
        }
    })
config.$inject = ['$routeProvider', '$locationProvider'];

        function config($routeProvider, $locationProvider) {
            /*Routing for App that handles loading data */
            $routeProvider
                .when("/LanePicks",
                    {
                        templateUrl: "/Client/Partials/LanePicks.html",
                        controller: 'picksController'
                    })
                .when("/LaneWaves",
                    {
                        templateUrl: "/Client/Partials/LaneWaves.html",
                        controller: 'waveController'
                    })
                .when("/Dashboard",
                    {
                        templateUrl: "/Client/Partials/Dashboard.html"
                    })
                .when("/ReportIssue",
                    { templateUrl: "/Client/Partials/ReportIssue.html" })
                .when("/Charts",
                    {
                        templateUrl: "/Client/Partials/charts.html",
                        controller: 'graphCtrl'
                    })
                .when('/NewMessage',
                    {
                        templateUrl: "/Client/Partials/NewMessage.html",
                        controller: 'messageCtrl'

                    })
                .when("/PickerExceptions",
                    {
                        templateUrl: "/Client/Partials/PickerExceptions.html",
                        controller: 'PickExceptionController'
                    })
                .when("/WorkOrders", {
                    templateUrl: "/Client/Partials/WorkOrders.html",
                    controller: 'workOrderCtrl'
                })
                .when("/totes", {
                    templateUrl: "/Client/Partials/totes.html",
                    controller: 'totesCtrl'
                })
                .otherwise(
                    { redirectTo: "/" });
        };
    
})();
        
