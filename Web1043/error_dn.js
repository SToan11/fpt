document.getElementById('btndn').addEventListener('click', function() {
    var emailPhoneInput = document.getElementById('emailPhone').value.trim();
    var passwordInput = document.getElementById('password').value.trim();
    var emailPhoneError = document.getElementById('emailPhoneError');
    var passwordError = document.getElementById('passwordError');

    emailPhoneError.textContent = '';
    passwordError.textContent = '';

    var mauEmail = /^[a-zA-Z0-9_.]{3,20}@gmail\.com(\.vn)?$/;
    var mauSDT = /^[0-9]{10}$/;

    if (!emailPhoneInput) {
        emailPhoneError.textContent = 'Vui lòng nhập email hoặc số điện thoại.';
    } else if (emailPhoneInput.includes('@')) {
        if (!mauEmail.test(emailPhoneInput)) {
            emailPhoneError.textContent = 'Email không hợp lệ.';
        }
    } else {
        if (!mauSDT.test(emailPhoneInput)) {
            emailPhoneError.textContent = 'Số điện thoại hoặc email không hợp lệ.';
        }
    }

    if (!passwordInput) {
        passwordError.textContent = 'Vui lòng nhập mật khẩu.';
    } else if (passwordInput.length < 8) {
        passwordError.textContent = 'Mật khẩu phải có ít nhất 8 kí tự.';
    }

    if ((mauEmail.test(emailPhoneInput) || mauSDT.test(emailPhoneInput)) && passwordInput.length >= 8) {
        alert('Đăng nhập thành công!');
        window.location.href = 'index.html';
    }
});
