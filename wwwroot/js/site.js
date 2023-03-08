// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Add user button click event
let addUserButton = document.querySelector("#add_user");
if (addUserButton) {
    addUserButton.addEventListener("click", (e) => {
        e.preventDefault();

        document.querySelector(".add_user_form").classList.toggle("active");
    });
}

// Cancel adding user click event
let cancelAddUserButton = document.querySelector("#add_user_cancel");
if (cancelAddUserButton) {
    cancelAddUserButton.addEventListener("click", e => {
        e.preventDefault();

        document.querySelector(".add_user_form").classList.toggle("active");
    });
}

// Changing the date should calculate
document.getElementById("dob").addEventListener("change", e => {
    let dateOfBirth = new Date(e.target.value);
    
    document.getElementById("age").value = new Date().getFullYear() - dateOfBirth.getFullYear();
});