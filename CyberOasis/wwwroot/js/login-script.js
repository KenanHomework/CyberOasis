const sign_in_btn = document.querySelector("#sign-in-btn");
const sign_up_btn = document.querySelector("#sign-up-btn");
const container = document.querySelector(".container-login");
const infoState = "info";
const successState = "success";
const warningState = "warning";

sign_up_btn.addEventListener("click", () => {
    container.classList.add("sign-up-mode");
});

sign_in_btn.addEventListener("click", () => {
    container.classList.remove("sign-up-mode");
});

function signUp() {
    const username = document.querySelector("#sign-up-username");
    const email = document.querySelector("#sign-up-email");
    const password = document.querySelector("#sign-up-password");
    const confirmPassword = document.querySelector("#sign-up-confirm-password");
    const rememberMe = document.querySelector("#sign-up-remember-me");
    const acceptUserAgreement = document.querySelector("#accept-user-agreement");

    /* Input Validation */
    if (isValidUsername(username.value) === false) {
        ShowSnackBar(warningState, "Invalid Username", "Please write valid username!");
    }
    if (isValidEmail(email.value) === false) {
        ShowSnackBar(warningState, "Invalid Password", "Please write valid password!");
    }
    if (isValidPassword(password.value) === false) {
        ShowSnackBar(warningState, "Invalid Password", "Please write valid password!");
    }
    if (password.value !== confirmPassword.value) {
        ShowSnackBar(warningState, "Invalid Password", "Passwords not same!");
    }
    if (acceptUserAgreement.checked === false) {
        ShowSnackBar(warningState, "User Agreement", "Please Read and Accept User Agreement.");
    }


}

function singIn() {
    const username = document.querySelector("#sign-in-username");
    const password = document.querySelector("#sign-in-password");
    const rememberMe = document.querySelector("#sign-in-remember-me");


    /* Input Validation */
    if (isValidUsername(username.value) === false) {
        ShowSnackBar(warningState, "Invalid Username", "Please write valid username!")
    }
    if (isValidPassword(password.value) === false) {
        ShowSnackBar(warningState, "Invalid Password", "Please write valid password!")
    }


}


function isValidUsername(username) {
    return /[a-zA-Z][a-zA-Z0-9-_]{3,20}/gi.test(username);
}

function isValidPassword(password) {
    return /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,20}$/gi.test(password);
}

function isValidEmail(email) {
    return /\b[\w\.-]+@[\w\.-]+\.\w{2,4}\b/gi.test(email);
}