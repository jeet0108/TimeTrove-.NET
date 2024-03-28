// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById("scrollToNewCollection").addEventListener("click", function () {
    var targetElement = document.getElementById("new-collection");
    if (targetElement) {
        targetElement.scrollIntoView({ behavior: "smooth", block: "start" });
    }
});


function fetchProductData(Id) {
    // Redirect to the ProductDisplay.cshtml with the same productId
    console.log(Id);
    //window.location.href = `/Home/ProductDisplay?id=${Id}`;
}