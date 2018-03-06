// Here we get the module we created in file one
angular.module('myApp').controller('customerController', customerController);

// Inject my dependencies
customerController.$inject = ['$scope', 'loadservice'];

// Now create our controller function with all necessary logic
function customerController($scope, customerService) {
    $scope.customers = [],

    customerService.Load()
        .then(function (customers) { $scope.customer = customers; })
        .catch(function (error) { console.log(error); });
 }
