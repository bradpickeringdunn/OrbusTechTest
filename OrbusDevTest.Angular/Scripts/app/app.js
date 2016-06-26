(function (angular) {
    angular.module('app', ['ngRoute'])
           .config(['$routeProvider', '$locationProvider',
                function ($routeProvider, $locationProvider) {
                    $routeProvider
                        .when('/', {
                            templateUrl: 'partials/start-test'
                        })
                        .when('/product', {
                            templateUrl: 'partials/product',
                            controller: 'productCtrl'
                        })
                        .otherwise({
                            redirectTo: '/'
                        });

                    // use the hashbang mode
                    $locationProvider.html5Mode(false);
                }]);
})(angular);
