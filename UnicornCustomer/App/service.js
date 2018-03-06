angular.module('myApp').service('service1', service1);

service1.$inject = ['$http'];

function service1($http) {
    this.Name = 'test';
    this.SaveFile = SaveFile;
    this.doreturn = doreturn;

    function SaveFile(dto) {
        debugger;
        
        var url = '/api/Unicorn'; //  api / Unicorn

        $http.post(url, dto).then(doreturn); //.then(doreturn);
    }

    function doreturn(d){
        alert(d.data);
    }
}