function validateForm() {
    let valid = true;

    document.getElementById("nameError").innerText = "";
    document.getElementById("emailOrPhoneError").innerText = "";
    document.getElementById("passwordError").innerText = "";
    document.getElementById("confirmPasswordError").innerText = "";

    const name = document.getElementById("name").value;
    if (name.trim() === "") {
        document.getElementById("nameError").innerText = "Vui lòng nhập họ tên";
        valid = false;
    }

    const emailOrPhone = document.getElementById("emailOrPhone").value;
    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    const phonePattern = /^\d{10}$/;
    if (emailOrPhone.trim() === "") {
        document.getElementById("emailOrPhoneError").innerText = "Vui lòng nhập email hoặc số điện thoại";
        valid = false;
    } else if (!emailPattern.test(emailOrPhone) && !phonePattern.test(emailOrPhone)) {
        document.getElementById("emailOrPhoneError").innerText = "Email hoặc số điện thoại không hợp lệ";
        valid = false;
    }

    const password = document.getElementById("password").value;
    if (password.length < 6) {
        document.getElementById("passwordError").innerText = "Mật khẩu phải có ít nhất 6 ký tự";
        valid = false;
    }

    const confirmPassword = document.getElementById("confirmPassword").value;
    if (password !== confirmPassword) {
        document.getElementById("confirmPasswordError").innerText = "Mật khẩu không khớp";
        valid = false;
    }

    return valid;
}

