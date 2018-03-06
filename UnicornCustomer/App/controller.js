// Here we get the module we created in file one
angular.module('myApp').controller('Ctrl1', Ctrl1);

// Inject my dependencies
Ctrl1.$inject = ['$scope', '$http', 'service1'];

// Now create our controller function with all necessary logic
function Ctrl1($scope, $http, service1) {
    vm = $scope,
    vm.FirstName = 'mike',
    vm.LastName = 'fisher',
    vm.Nationality = 'british',
    vm.Age = 21;
    vm.Save = Save;

    function Save() {
        var dto = getDTO();

        alert(dto.FirstName);
        service1.SaveFile(dto); //.then(doreturn);
        // alert(service1.Name);        
    }

    function doreturn(d) {
        alert(d);
    }

    function getDTO() {
        return {
            "FirstName": vm.FirstName,
            "LastName": vm.LastName,
            "Nationality": vm.Nationality,
            "Age": vm.Age
        };
    }
}
