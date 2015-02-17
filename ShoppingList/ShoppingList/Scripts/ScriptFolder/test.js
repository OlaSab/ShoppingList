    var app = angular.module("slApp", []);
    app.controller("slController", function ($scope, $http) {
        var self = this;
        self.Hejhopptest = "abc";
    $http.get('api/shoppingList').success(function(data, status, header, config) {
        $scope.slList = data;
    }).error(function() {
        console.log("Some error");
    });
});