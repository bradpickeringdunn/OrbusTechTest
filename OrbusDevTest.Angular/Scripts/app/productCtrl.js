(function (angular) {
    angular.module('app')
           .controller('productCtrl', ['$scope', function ($scope) {
               $scope.input = {
                   category: {
                       value: null,
                       config: {
                           type: 'select',
                           label: 'Category',
                           id: 'category',
                           options: []
                       }
                   },
                   subcategory: {
                       value: null,
                       config: {
                           type: 'select',
                           label: 'Sub Category',
                           id: 'subcategory',
                           options: []
                       }
                   },
                   minstock: {
                       value: 500,
                       config: {
                           type: 'number',
                           label: 'Min Stock',
                           id: 'minstock',
                           step: '100'
                       }
                   }
               };

               // TODO: Implement controller logic
           }]);
})(angular);
