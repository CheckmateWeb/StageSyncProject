app.controller("StageSyncController", function ($scope, StageSyncService) {

    $scope.userarray = [];
    $scope.index = 0;




    $scope.nameofFunc = function () {
        alert("working");
    };


    $scope.alertFunc = function (parameterOne) {
        alert(parameterOne);
    }

    $scope.mathFunc = function () {
        var one = 1;
        var two = 2;
        var sum = one + two;
        alert(sum);

    }

    $scope.titleFunc = function () {
        $scope.variableName = "Main Menu"
    }

    $scope.registrationFunc = function () {

        if (($scope.FName == "" || $scope.FName == undefined) ||
            $scope.MName == "" || $scope.MName == undefined ||
            $scope.LName == "" || $scope.LName == undefined) {
            alert("Please insert values in the required fields")
            return;
        }

        // If editing, update existing entry
        if ($scope.isEditing) {
            var target = $scope.userarray[$scope.editIndex];
            target.firstname = $scope.FName;
            target.middlename = $scope.MName;
            target.lastname = $scope.LName;
            alert("Updated");
            $scope.isEditing = false;
            $scope.editIndex = null;
            $scope.clearFunc();
            return;
        }

        // Otherwise add new
        var userdata = {
            firstname: $scope.FName,
            middlename: $scope.MName,
            lastname: $scope.LName
        };

        $scope.userarray.push(userdata);
        $scope.clearFunc();
    }

    $scope.loginFunc = function () {
        if ($scope.Username == "" || $scope.Username == undefined ||
            $scope.Password == "" || $scope.Password == undefined) {
            alert("Please insert values in the required fields");
            return;
        }
        alert("Login Successful");
        // redirect to Modules controller which serves the Views/Modules views
        window.location.href = "/Modules/HomePage";
    }

    $scope.clearFunc = function () {
        $scope.FName = "";
        $scope.MName = "";
        $scope.LName = "";
        $scope.Username = "";
        $scope.Password = "";
        $scope.isEditing = false;
        $scope.editIndex = null;
    }

    $scope.editFunc = function (userid) {
        var targetData = $scope.userarray[userid];
        if (!targetData) return;
        // populate form for editing
        $scope.FName = targetData.firstname;
        $scope.MName = targetData.middlename;
        $scope.LName = targetData.lastname;
        $scope.isEditing = true;
        $scope.editIndex = userid;
    }

    $scope.deleteFunc = function (userid) {
        if (!confirm('Are you sure you want to delete this entry?')) return;
        $scope.userarray.splice(userid, 1);
        alert("Deleted Successfully");
    }

    $scope.sweetalertFunc = function () {
        Swal.fire({
            title: "Good job!",
            text: "You clicked the button!",
            icon: "success"
        });

    }

    $scope.getUsername = function () {

        var getData = StageSyncService.fetchFunc();
        getData.then(function (returnData) {
            alert(returnData.data);
        });
    }

    $scope.updateUsername = function () {
        var getData = StageSyncService.updateUsernameFunc("Mariveles");
        getData.then(function (returnedData) {
            alert(returnedData.data);
        });
    }


    $scope.userVerification = function () {

        var userdata = {

            FirstName: $scope.FName,
            MiddleName: $scope.MName,
            LastName: $scope.LName,
            Position: "SSE"
        };

        var getData = StageSyncService.userverificationFunc();
        getData.then(function (returnedData) {

        });

    }
});