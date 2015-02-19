angular.module("shoppingListModule").controller("shoppingListController", ['$http', '$scope', 'shoppingListService', function($http, $scope, shoppingListService) {
    "use strict";

    
    $http.get('/api/shoppingList/')
        .success(function (data, status, header, config) {
            $scope.shoppingLists = data;
        })
        .error(function (data, status, header, config) {
            console.log("Requst failed!");
        });

    $scope.addList = function () {
        $http.post('/api/values/', $scope.newListName)
            .success(function (data, status, header, config) {
                $scope.shoppingLists = data;
            })
            .error(function (data, status, header, config) {
                console.log("Requst failed!");
            });
    };
    
    this.addList = function() {
    };
    
}]);
  
    
