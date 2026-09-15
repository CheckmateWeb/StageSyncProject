app.service("StageSyncService", function ($http) {

    // Get all registered accounts
    this.getAccounts = function () {
        return $http.get("/Modules/GetAccounts");
    };

    // Create or update account
    this.saveAccount = function (formData) {
        return $http.post("/Modules/SaveAccount", formData, {
            transformRequest: angular.identity,
            headers: {
                "Content-Type": undefined
            }
        });
    };

    // Delete account
    this.deleteAccount = function (id) {
        return $http.post("/Modules/DeleteAccount", {
            id: id
        });
    };

    // Get welcome message from C#
    this.fetchMessageFunc = function () {
        return $http.get("/Modules/GetMessage");
    };
});