angular.module("shoppingListModule").controller("shoppingListController", ['$http', '$scope', 'shoppingListService', function($http, $scope, shoppingListService) {
    "use strict";

    $scope.getLists = function() {
        $http.get('/api/shoppingList/')
            .success(function(data, status, header, config) {
                $scope.shoppingLists = data;
            })
            .error(function(data, status, header, config) {
                console.log("Requst failed!");
            });
    };

    $scope.getLists();

    $scope.removeList = function(shoppingListId) {
        $http.delete('/api/shoppingList/' + shoppingListId)
            .success(function (data, status, header, config) {
                $scope.getLists();
            })
            .error(function (data, status, header, config) {
                console.log("Requst failed!");
            });
    };
    
    $scope.addList = function (newListName) {
        var data1 = { ShoppingListName: newListName };
        $http.post('/api/shoppingList/', data1)
            .success(function (data, status, header, config) {
                $scope.getLists();
            })
            .error(function (data, status, header, config) {
                console.log("Requst failed!");
            });
    };
    
    
}]);
  
    
