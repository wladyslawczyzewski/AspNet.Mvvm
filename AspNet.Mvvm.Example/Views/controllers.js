/// <reference path="../Scripts/angular.js" />

var appControllers = angular.module('appControllers', []);

appControllers.controller('Example', ['$scope', '$http', function ($scope, $http) {
    $http.get('/example').success(function (data) {
        $scope.data = data;
    });
}]);
