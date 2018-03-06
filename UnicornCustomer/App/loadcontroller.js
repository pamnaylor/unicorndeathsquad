// Here we get the module we created in file one
angular.module('myApp').controller('CtrlLoad', CtrlLoad);

// Inject my dependencies
CtrlLoad.$inject = ['$scope', '$http', 'loadservice'];

// Now create our controller function with all necessary logic
function CtrlLoad($scope, $http, loadservice) {
    vm = $scope,
    vm.customers = [],
    vm.Load = Load;
    vm.doreturn = doreturn;
    Load();

    function Load() {
        loadservice.Load().then(doreturn);

        debugger;
        //loadservice.Load().then(doreturn);
    }

    function doreturn(data) {
        vm.customers = data;
    }
}
