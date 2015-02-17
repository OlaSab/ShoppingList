angular.module("shoppingListModule").service("shoppingListService", ['$http', function($http) {
    var self = this;

    self.getShoppingLists = function() {
        $http.get('/api/shoppingList/').success(function (data, status, header, config) {
            return data;
        }).error(function (data, status, header, config) {
            console.log("Requst failed!");
        });
    };

}])  