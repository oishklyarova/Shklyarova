(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/');
            $stateProvider
                .state('testEntries', {
                    url: '/',
                    templateUrl: '/App/Main/views/testEntries/entries.cshtml',
                    menu: 'TestEntries' //Matches to name of 'TestEntries' menu in ShklyarovaNavigationProvider
                });
        }
    ]);
})();