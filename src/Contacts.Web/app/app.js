(function () {
    'use strict';
    angular.module('contactsApp', [])
        .factory('personApiSvc', ['$http', function ($http) {
            var get = function (index, callback, errback) {
                var baseUrl = '/api/person/';
                $http({
                    url: baseUrl + index,
                    headers: {
                        'Content-Type': 'application/json'
                    }
                }).success(callback).error(errback);
            }
            return {
                get: get
            };
        }]).controller('headCtrl', ['$scope', function ($scope) {
            $scope.title = 'Contacts - Home';
        }]).controller('personCtrl', ['$scope', 'personApiSvc', function ($scope, personApiSvc) {
            $scope.title = 'All Contacts';
            personApiSvc.get(1, function (persons) {
                $scope.persons = persons;
                $scope.persons.forEach(function (elem) {
                    elem.fullName = elem.firstName + ' ' + elem.lastName;
                });
            });
        }]);

}());