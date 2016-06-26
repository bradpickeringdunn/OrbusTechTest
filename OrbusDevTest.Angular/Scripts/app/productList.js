(function (angular) {
    angular.module('app')
           .directive('productList', [function () {
               return {
                   restrict: 'E',
                   replace: true,
                   scope: {
                       products: '='
                   },
                   templateUrl: 'partials/product-list',
                   link: function (scope) {
                   }
               };
           }]);
})(angular);
