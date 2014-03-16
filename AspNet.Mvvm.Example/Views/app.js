/// <reference path="../Scripts/angular.js" />
/// <reference path="../Scripts/angular-route.js" />

var app = angular.module('app', ['ngRoute', 'appControllers']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/example', {
        templateUrl: 'Partial/example.html',
        controller: 'Example'
    }).otherwise({
        redirectTo: '/example'
    });
}]);
