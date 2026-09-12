app.service("StageSyncService", function ($http, $q) {

    this.fetchFunc = function () {
        return $http.get("module/GetUsername");

    }

    this.updateUsernameFunc = function (uname) {
        var data = $http({
            method: "POST",
            url: "Module/UpdateUsername",
            params: {
                username: uname

            }
        });

        return data;

    }

    this.userverificationFunc = function (udata) {
        var data = $http({
            method: "POST",
            url: "Module/UserVerification",
            data: udata
        })
        return data;
    }

});