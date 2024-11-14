var a = null, b = null, o = null;

function lam_lai() {
    a = null;
    b = null;
    o = null;
}

function toan_tu(x) {
    o = x;
}

function toan_hang(x) {
    if (a === null) {
        a = parseFloat(x);
    } else {
        b = parseFloat(x);
    }
}

function thuc_hien() {
    if (a !== null && b !== null && o !== null) {
        var c;
        switch (o) {
            case '+':
                c = a + b;
                alert("Tổng: " + c);
                break;
            case '-':
                c = a - b;
                alert("Hiệu: " + c);
                break;
            case '*':
                c = a * b;
                alert("Tích: " + c);
                break;
            case '/':
                if (b !== 0) {
                    c = a / b;
                    alert("Thương: " + c);
                } else {
                    alert("Lỗi: Không thể chia cho 0");
                }
                break;
            default:
                alert(o + ' không phải toán tử hợp lệ');
        }
    } else {
        alert("Lỗi: Vui lòng nhập đầy đủ toán hạng và toán tử");
    }
    lam_lai();
}
 


