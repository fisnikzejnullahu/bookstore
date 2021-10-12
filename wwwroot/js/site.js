// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function confirmDeleteItem(e) {
    if (!confirm("Are you sure you want to delete this item?")) {
        e.preventDefault();
    }
}

function editComment() {
    document.getElementById('editCommentInput').style.display = 'block';
}

function validateTypeBook() {
    console.log("CAlitedet");
}