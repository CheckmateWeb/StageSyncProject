app.service("StageSyncService", function ($http, $q) {

    this.fetchFunc = function () {
        return $http.get("/Modules/GetUsername");

    }

    this.updateUsernameFunc = function (uname) {
        var data = $http({
            method: "POST",
            url: "/Modules/UpdateUsername",
            params: {
                username: uname

            }
        });

        return data;

    }

    this.userverificationFunc = function (udata) {
        var data = $http({
            method: "POST",
            url: "/Modules/UserVerification",
            data: udata
        })
        return data;
    }

});