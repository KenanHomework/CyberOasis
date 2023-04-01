document.querySelector("#year").innerText = new Date().getFullYear();

function toggleShow(CalledElement) {
    console.log("salam")
    const elements = document.getElementsByClassName("dropdown-content");
    for (let i = 0; i < elements.length; i++) {
        elements[i].classList.remove("show")
    }
    CalledElement.nextElementSibling.classList.toggle("show");
}

// Close the dropdown if the user clicks outside of it
window.onclick = function (event) {
    if (!event.target.matches('.dropdown')) {
        var dropdowns = document.getElementsByClassName("dropdown-content");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
    }
}


function ApplyInfosSnackBar(state, header, message) {
    const snackHeader = document.querySelector(".snackbar-text-heading");
    const snackMessage = document.querySelector(".snackbar-text-paragraph");

    ApplySnackBarState(state);

    snackHeader.innerText = header;
    snackMessage.innerText = message;
}

function ShowSnackBar(state, header, message) {
    CreateInsertSnackBar();

    const snackbar = document.querySelector(".snackbar");
    const closeBtn = document.querySelector(".snackbar-close-btn");

    ApplyInfosSnackBar(state,header,message);
    
    const showSnackbar = (autohide) => {
        snackbar.classList.add("isShown");

        if (autohide) {
            setTimeout(hideSnackbar, 3000);
        }
    };

    const hideSnackbar = () => {
        snackbar.classList.remove("isShown");
    };
    closeBtn.addEventListener("click", hideSnackbar);

    showSnackbar(true);
}

function CreateInsertSnackBar() {
    document.querySelector(".snackbar").innerHTML = `
    <i ></i>
    <div class="snackbar-text">
        <h2 class="snackbar-text-heading"></h2>
        <p class="snackbar-text-paragraph"></p>
    </div>
    <svg
            class="snackbar-close-btn"
            width="22"
            height="22"
            viewBox="0 0 22 22"
            fill="none"
            xmlns="http://www.w3.org/2000/svg"
    >
        <circle opacity="0.12" cx="11" cy="11" r="10" fill="#22272F" />
        <path
                fill-rule="evenodd"
                clip-rule="evenodd"
                d="M1.75 11C1.75 5.89137 5.89137 1.75 11 1.75C16.1086 1.75 20.25 5.89137 20.25 11C20.25 16.1086 16.1086 20.25 11 20.25C5.89137 20.25 1.75 16.1086 1.75 11ZM11 0.25C5.06294 0.25 0.25 5.06294 0.25 11C0.25 16.9371 5.06294 21.75 11 21.75C16.9371 21.75 21.75 16.9371 21.75 11C21.75 5.06294 16.9371 0.25 11 0.25ZM8.53033 7.46967C8.23744 7.17678 7.76256 7.17678 7.46967 7.46967C7.17678 7.76256 7.17678 8.23744 7.46967 8.53033L9.93934 11L7.46967 13.4697C7.17678 13.7626 7.17678 14.2374 7.46967 14.5303C7.76256 14.8232 8.23744 14.8232 8.53033 14.5303L11 12.0607L13.4697 14.5303C13.7626 14.8232 14.2374 14.8232 14.5303 14.5303C14.8232 14.2374 14.8232 13.7626 14.5303 13.4697L12.0607 11L14.5303 8.53033C14.8232 8.23744 14.8232 7.76256 14.5303 7.46967C14.2374 7.17678 13.7626 7.17678 13.4697 7.46967L11 9.93934L8.53033 7.46967Z"
                fill="#7C828D"  
        />
    </svg>`;
}

function ApplySnackBarState(state) {
    const icon = document.querySelector(".snackbar i");
    const infoClass = "fa fa-info";
    const successClass = "fa fa-check";
    const warningClass = "fa fa-triangle-exclamation";

    icon.className = "";
    console.log(state)
    switch (state) {
        case successState:
            console.log(successClass)
            icon.className = successClass;
            icon.style.color = "var(--positive-1)";
            break;
        case warningState:
            console.log(warningClass)
            icon.className = warningClass;
            icon.style.color = "var(--negative-1)";
            break;
        default:
            console.log(infoClass)
            icon.className = infoClass;
            icon.style.color = "var(--accent-2)";
    }
}