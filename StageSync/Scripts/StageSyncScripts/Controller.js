app.controller("StageSyncController", function ($scope, StageSyncService) {


    $scope.userArray = [];
    $scope.user = {};
    $scope.isEditing = false;
    $scope.errorMessage = "";
    $scope.ConfirmPassword = "";

    $scope.loginData = {
        Username: '',
        Password: ''
    };
    $scope.showPassword = false;

    $scope.loadAccounts = function() {

        StageSyncService.getAccounts()
            .then(function(response) {
                var accounts = response.data || [];
                $scope.userArray = accounts;
                $scope.totalAccounts = accounts.length;
            })
            .catch(function(error) {
                console.error("Failed to load accounts:", error);
                $scope.userArray = [];
                $scope.totalAccounts = 0;
            });
    };

    
    $scope.registrationFunc = function () {

        var user = $scope.user;
        var namePattern = /\d/; 

        
        if (!user.username ||
            !user.firstname ||
            !user.lastname ||
            !user.email ||
            !user.contactno ||
            !user.password ||
            !$scope.ConfirmPassword) {

            $scope.SweetAlertError("Please fill in all required fields.");
            return;
        }

       
        if (namePattern.test(user.firstname)) {
            $scope.SweetAlertError("First Name cannot contain numbers.");
            return;
        }

       
        if (user.middlename && namePattern.test(user.middlename)) {
            $scope.SweetAlertError("Middle Name cannot contain numbers.");
            return;
        }

     
        if (namePattern.test(user.lastname)) {
            $scope.SweetAlertError("Last Name cannot contain numbers.");
            return;
        }

        
        if (user.username.length < 3 || user.username.length > 20) {
            $scope.SweetAlertError("Username must be between 3 and 20 characters.");
            return;
        }


        if (user.firstname.length < 2 || user.firstname.length > 50) {
            $scope.SweetAlertError("First Name must be between 2 and 50 characters.");
            return;
        }

        
        if (user.lastname.length < 2 || user.lastname.length > 50) {
            $scope.SweetAlertError("Last Name must be between 2 and 50 characters.");
            return;
        }

        
        var emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        if (!emailPattern.test(user.email) || user.email.length > 100) {
            $scope.SweetAlertError("Please enter a valid email address (max 100 characters).");
            return;
        }

        
        var contactPattern = /^[0-9+\-\s()]{7,15}$/;
        if (!contactPattern.test(user.contactno)) {
            $scope.SweetAlertError("Contact number must be between 7 and 15 digits.");
            return;
        }

        
        if (user.password.length < 8 || user.password.length > 12) {
            $scope.SweetAlertError("Password must be between 8 and 12 characters.");
            return;
        }

        
        var passwordPattern = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,12}$/;
        if (!passwordPattern.test(user.password)) {
            $scope.SweetAlertError(
                "Password must be 8-12 characters and contain uppercase, lowercase, number, and special character."
            );
            return;
        }


        if (user.password !== $scope.ConfirmPassword) {
            $scope.SweetAlertError("Passwords do not match.");
            return;
        }

        
        var usernameTaken = false;
        for (var i = 0; i < $scope.userArray.length; i++) {
            if ($scope.userArray[i].username && user.username &&
                $scope.userArray[i].username.toLowerCase() === user.username.toLowerCase() &&
                $scope.userArray[i].id !== user.id) {
                usernameTaken = true;
                break;
            }
        }

        if (usernameTaken) {
            $scope.SweetAlertError("Username is already taken.");
            return;
        }

        
        var emailTaken = false;
        for (var j = 0; j < $scope.userArray.length; j++) {
            if ($scope.userArray[j].email && user.email &&
                $scope.userArray[j].email.toLowerCase() === user.email.toLowerCase() &&
                $scope.userArray[j].id !== user.id) {
                emailTaken = true;
                break;
            }
        }

        if (emailTaken) {
            $scope.SweetAlertError("Email address is already registered.");
            return;
        }

       
        if ($scope.isEditing) {
            for (var k = 0; k < $scope.userArray.length; k++) {
                if ($scope.userArray[k].id === user.id) {
                    $scope.userArray[k] = angular.copy(user);
                    break;
                }
            }
            $scope.SweetAlertSuccess("Account updated successfully!");
            $scope.clearFunc();
        } else {
            user.id = $scope.userArray.length + 1;
            $scope.userArray.push(angular.copy(user));
            $scope.SweetAlertSuccess("Successfully registered!");
            $scope.clearFunc();
        }
    };

    
    $scope.editFunc = function (udata) {
        $scope.isEditing = true;
        $scope.user = angular.copy(udata);
        $scope.ConfirmPassword = udata.password;
        window.scrollTo({
            top: 0,
            behavior: "smooth"
        });
    };

    
    $scope.deleteFunc = function (id) {
        Swal.fire({
            title: "Delete account?",
            text: "This action cannot be undone.",
            icon: "warning",
            showCancelButton: true,
            confirmButtonText: "Yes, delete it!",
            cancelButtonText: "Cancel",
            confirmButtonColor: "#e53935",
            cancelButtonColor: "#424242"
        }).then(function (result) {
            if (result.isConfirmed) {
                for (var i = 0; i < $scope.userArray.length; i++) {
                    if ($scope.userArray[i].id === id) {
                        $scope.userArray.splice(i, 1);
                        break;
                    }
                }
                $scope.SweetAlertSuccess("Account deleted successfully!");
                $scope.$apply();
            }
        });
    };

    
    $scope.clearFunc = function () {
        $scope.user = {};
        $scope.ConfirmPassword = "";
        $scope.isEditing = false;
        $scope.errorMessage = "";
    };

    
    $scope.login = function () {
        var username = $scope.loginData && $scope.loginData.Username;
        var password = $scope.loginData && $scope.loginData.Password;

        if (!username || !password) {
            $scope.SweetAlertError("Please enter your username and password.");
            return;
        }

        Swal.fire({
            title: 'Access Granted',
            text: 'Welcome back to StageSync!',
            icon: 'success',
            confirmButtonColor: '#8bc34a',
            timer: 1200,
            showConfirmButton: false
        }).then(function () {
            window.location.href = "/Modules/HomePage";
        });
    };

    $scope.loginFunc = function () {
        $scope.login();
    };

    $scope.clearLogin = function () {
        $scope.loginData = {
            Username: '',
            Password: ''
        };
        $scope.showPassword = false;

        if (typeof M !== 'undefined' && M.updateTextFields) {
            setTimeout(function () {
                M.updateTextFields();
            }, 50);
        }
    };

   
    $scope.SweetAlertError = function (message) {
        Swal.fire({
            title: "Error!",
            text: message,
            icon: "error",
            confirmButtonColor: "#8bc34a"
        });
    };

    $scope.SweetAlertSuccess = function (message) {
        Swal.fire({
            title: "Success!",
            text: message,
            icon: "success",
            confirmButtonColor: "#8bc34a"
        });
    };

    // --- Page Navigation ---
    $scope.redirectHomePage = function () { window.location.href = "/Modules/HomePage"; };
    $scope.redirectAboutPage = function () { window.location.href = "/Modules/AboutPage"; };
    $scope.redirectContactPage = function () { window.location.href = "/Modules/ContactPage"; };
    $scope.redirectLoginPage = function () { window.location.href = "/Modules/LoginPage"; };
    $scope.redirectRegistrationPage = function () { window.location.href = "/Modules/RegistrationPage"; };

});