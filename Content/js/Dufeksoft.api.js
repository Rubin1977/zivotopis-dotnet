$(document).ready(function () {
    contactFormApi();
});

function contactFormApi() {
    $.ajax('/DufeksoftApi/ContactFormApiKey',
        {
            type: 'POST',
            success: function (data) {
                $('.password-group #Password').val(data.MainKey);
                $('.password-group #ConfirmPassword').val(data.SubKey);
            }
        });
}
