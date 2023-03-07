// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Add user button click event
document.querySelector("#add_user").addEventListener("click", (e) => {
    e.preventDefault();

    document.querySelector(".add_user_form").classList.toggle("active");
})

// Cancel adding user click event
document.querySelector("#add_user_cancel").addEventListener("click", e => {
    e.preventDefault();

    document.querySelector(".add_user_form").classList.toggle("active");
});