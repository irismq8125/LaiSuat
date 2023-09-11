// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    getNumber();  
    getOption();
});


function getNumber() {
    const input = $('input[type="text"]');
    input.on('input', function () {
        let number = parseInt($(this).val().replaceAll(',', ''));
        if (isNaN(number)) {
            number = 0;
        }
        $(this).val(number.toLocaleString('en-US'));
    });
}
function getOption() {
    let solan = $("#langui").val();
    $("select option").each(function () {
        if ($(this).val() == solan) {
            $(this).attr("selected", "selected");
        }
    });
}

//$('#ketqua').on('click', function () {
//    $('form')[0].submit();
//});