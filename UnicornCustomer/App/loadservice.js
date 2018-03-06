angular.module('myApp').service('loadservice', loadservice);

loadservice.$inject = ['$http'];

function loadservice($http) {
    this.Load = Load;
    this.doreturn = doreturn;

    function Load() {
        var url = '/api/Load';
        return $http.post(url, null).then(doreturn); 
    }

    function doreturn(d) {
        return d.data;
    }
}