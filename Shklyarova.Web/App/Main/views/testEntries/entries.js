(function () {
    var app = angular.module('app');

    var controllerId = 'testEntriesController';
    app.controller(controllerId, [
        '$scope', '$state', 'abp.services.app.testEntry',
        function ($scope, $state, testEntryService) {
            testEntryService.getEntries().success(
                function (data) {
                    $scope.testEntries = data;
                });

            $scope.saveEntry = function () {
                testEntryService.createEntry($scope.newTestEntry).success(function () {
                    $scope.message = "Saved successfully!";
                    $state.reload();
                });
            };
        }
    ]);
})();