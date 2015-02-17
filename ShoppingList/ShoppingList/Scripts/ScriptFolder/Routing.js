var shoppingListApp = angular.module('shoppingListModule');

shoppingListApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.
        when('/shoppingList', {
            templateUrl: '/Index.html'//,
            //controller: shoppingListController
        }).
        otherwise({
            templateUrl: '/Index.html'
            //, controller: shoppingListController
        });
        //otherwise({
        //    redirectTo: '/'
        //});

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });

}]);