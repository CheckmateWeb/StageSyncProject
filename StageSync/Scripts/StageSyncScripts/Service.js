app.service("StageSyncService", function ($http) {


    this.getAccounts = function() {
        return $http.get("/Modules/GetAccounts");
    };


    this.saveAccount = function(formData) {
        return $http.post("/Modules/SaveAccount", formData, {
            transformRequest: angular.identity,
            headers: {
                "Content-Type": undefined
            }
        });
    };

    
    this.deleteAccount = function (id) {
        return $http.post("/Modules/DeleteAccount", {
            id: id
        });
    };

    
    this.fetchMessageFunc = function () {
        return $http.get("/Modules/GetMessage");
    };
});