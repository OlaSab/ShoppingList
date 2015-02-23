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

        var data1 = $.param({
            json: JSON.stringify({
                name: 'abcd'
            })
        });
        $http({
            method: 'POST',
            url: '/api/shoppingList/',
            data: data1,
            //headers: { 'Content-Type': 'application/json; charset=utf-8' }
            //headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
        }).success(function(data, status, header, config) {
            $scope.shoppingLists = data;
        })
            .error(function(data, status, header, config) {
                console.log("Requst failed!");
            });
        
        //"application/json; charset=utf-8"
        
        //$http.post('/api/shoppingList/', data)
        //    .success(function (data, status, header, config) {
        //        $scope.shoppingLists = data;
        //    })
        //    .error(function (data, status, header, config) {
        //        console.log("Requst failed!");
        //    });
    };
    
    this.addList = function() {
    };
    
}]);
  
    
