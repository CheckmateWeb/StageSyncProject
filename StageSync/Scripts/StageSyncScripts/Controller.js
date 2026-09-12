app.controller("StageSyncController", function ($scope, StageSyncService) {

    $scope.userarray = [];
    $scope.isEditing = false;
    $scope.editIndex = null;

    // Save and Update User Registration
    $scope.registrationFunc = function () {

        if (($scope.FName == "" || $scope.FName == undefined) ||
            $scope.MName == "" || $scope.MName == undefined ||
            $scope.LName == "" || $scope.LName == undefined ||
            $scope.BandName == "" || $scope.BandName == undefined ||
            $scope.Username == "" || $scope.Username == undefined ||
            $scope.Password == "" || $scope.Password == undefined) {
            alert("Please insert values in the required fields");
            return;
        }

        // If editing, update existing entry in array
        if ($scope.isEditing) {
            var target = $scope.userarray[$scope.editIndex];
            target.firstname = $scope.FName;
            target.middlename = $scope.MName;
            target.lastname = $scope.LName;
            target.bandname = $scope.BandName;
            target.username = $scope.Username;
            target.password = $scope.Password;

            alert("Updated");
            $scope.clearFunc();
            return;
        }

        // Add new user entry
        var userdata = {
            firstname: $scope.FName,
            middlename: $scope.MName,
            lastname: $scope.LName,
            bandname: $scope.BandName,
            username: $scope.Username,
            password: $scope.Password
        };

        $scope.userarray.push(userdata);
        $scope.clearFunc();
    };

    // Populate form fields for editing
    $scope.editFunc = function (userid) {
        var targetData = $scope.userarray[userid];
        if (!targetData) return;

        $scope.FName = targetData.firstname;
        $scope.MName = targetData.middlename;
        $scope.LName = targetData.lastname;
        $scope.BandName = targetData.bandname;
        $scope.Username = targetData.username;
        $scope.Password = targetData.password;

        $scope.isEditing = true;
        $scope.editIndex = userid;
    };

    // Remove user entry
    $scope.deleteFunc = function (userid) {
        if (!confirm('Are you sure you want to delete this entry?')) return;
        $scope.userarray.splice(userid, 1);
        alert("Deleted Successfully");
    };

    // User Login
    $scope.loginFunc = function () {
        if ($scope.Username == "" || $scope.Username == undefined ||
            $scope.Password == "" || $scope.Password == undefined) {
            alert("Please insert values in the required fields");
            return;
        }
        alert("Login Successful");
        window.location.href = "/Modules/HomePage";
    };

    // Clear form inputs
    $scope.clearFunc = function () {
        $scope.FName = "";
        $scope.MName = "";
        $scope.LName = "";
        $scope.BandName = "";
        $scope.Username = "";
        $scope.Password = "";
        $scope.isEditing = false;
        $scope.editIndex = null;
    };
});