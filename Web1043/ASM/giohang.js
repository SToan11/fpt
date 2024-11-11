let cart = [];

// Sample data
var data = [
    { "id": 1, "category": "DienThoai", "name": "Apple iPhone 15 Pro 128GB", "price": "25.890.000", "img": "iphone15.jpg" },
    { "id": 2, "category": "DienThoai", "name": "Samsung Galaxy S24 Ultra", "price": "28.490.000", "img": "s24ultra.jpg" },
    { "id": 3, "category": "Laptop", "name": "Apple MacBook Air M1 256GB 2020", "price": "18.190.000", "img": "macboo1k.jpg" },
    { "id": 4, "category": "Laptop", "name": "Laptop ASUS Zenbook 14 OLED", "price": "20.490.000", "img": "laptop1.png" },
    { "id": 5, "category": "DienThoai", "name": "iPad Air 5 10.9 inch", "price": "14.090.000", "img": "maytinhbang1.jpg" },
    { "id": 6, "category": "DienThoai", "name": "iPad Pro 11 inch 2022 M2", "price": "24.290.000", "img": "maytinhbang2.jpg" },
    { "id": 7, "category": "Laptop", "name": "Apple Macbook Air M2 2022", "price": "34.690.000", "img": "macbook2.jpg" },
    { "id": 8, "category": "Laptop", "name": "Laptop Lenovo Thinkpad X1 Carbon", "price": "33.590.000", "img": "laptop2.png" },
    { "id": 9, "category": "PhuKien", "name": "Sạc dự phòng trong suốt", "price": "199.000", "img": "sacduphong.jpg" },
    { "id": 10, "category": "PhuKien", "name": "Tai nghe nhét tai Bluetooth", "price": "54.999", "img": "tainghe2.jpg" },
    { "id": 11, "category": "PhuKien", "name": "Tai Nghe Bluetooth M10 Pro", "price": "49.000", "img": "tainghe1.jpg" },
    { "id": 12, "category": "DienThoai", "name": "Sản phẩm 1", "price": "1.500.000", "img": "sanpham (5).webp" },
    { "id": 13, "category": "PhuKien", "name": "Thảm Lót Chuột Cho Game Thủ", "price": "40.000", "img": "lotchuot1.jpg" },
    { "id": 14, "category": "PhuKien", "name": "Miếng Lót Chuột Có Đệm Tay", "price": "82.000", "img": "lotchuot2.jpg" },
    { "id": 15, "category": "PhuKien", "name": "Kệ giá đỡ điện thoại Để Bàn", "price": "2.800", "img": "kedodt.jpg" },
    { "id": 16, "category": "PhuKien", "name": "Giá đỡ LAPTOP, MACBOOK, IPAD", "price": "14.999", "img": "giadolaptop.jpg" },
    { "id": 17, "category": "BanPhim", "name": "Bàn phím cơ máy tính để bàn", "price": "399.000", "img": "banphim1.jpg" },
    { "id": 18, "category": "BanPhim", "name": "Bàn phím giả cơ gaming XUNFOX", "price": "289.000", "img": "banphim2.jpg" },
    { "id": 19, "category": "DienThoai", "name": "Sản phẩm 1", "price": "1.500.000", "img": "sanpham (1).jpg" },
    { "id": 20, "category": "PhuKien", "name": "Cáp Sạc LT + Type C + Micro USB", "price": "36.000", "img": "sac2.jpg" },
    { "id": 21, "category": "PhuKien", "name": "Sạc nhanh PD 20W", "price": "18.000", "img": "sac1.jpg" },
    { "id": 22, "category": "PhuKien", "name": "Ốp điện thoại từ tính", "price": "29.000", "img": "oplung1.jpg" },
    { "id": 23, "category": "VeSinh", "name": "Bộ Dụng Cụ Vệ Sinh Laptop", "price": "39.000", "img": "vslaptop2.jpg" },
    { "id": 24, "category": "VeSinh", "name": "Bộ vệ sinh laptop chuyên nghiệp", "price": "70.000", "img": "vslaptop.jpg" }
];

function renderProducts() {
    const productList = document.getElementById('product-list');
    productList.innerHTML = ''; 

    // Limit the displayed products to 4
    const displayedProducts = data.slice(0, 4);

    displayedProducts.forEach(product => {
        const productDiv = document.createElement('div');
        productDiv.className = 'sanpham';
        productDiv.innerHTML = `
            <a>
                <img src="img/${product.img}" alt="${product.name}">
                <h5>${product.name}</h5>
                <p>${product.price} VNĐ</p>
                <button id="fm" onclick="addToCart(${product.id})">Mua ngay</button>
            </a>
        `;
        productList.appendChild(productDiv);
    });
}

// Function to add product to cart
function addToCart(productId) {
    const product = data.find(item => item.id === productId);
    const existingItem = cart.find(cartItem => cartItem.id === productId);
    if (existingItem) {
        existingItem.quantity++;
    } else {
        cart.push({ ...product, quantity: 1 });
    }
    saveCart();
    renderCart();
}

// Function to remove product from cart
function removeRow(button) {
    const rowIndex = button.parentNode.parentNode.rowIndex - 2;
    cart.splice(rowIndex, 1);
    saveCart();
    renderCart();
}

// Function to update quantity
function updateQuantity(index, newQuantity) {
    if (newQuantity < 1) {
        cart.splice(index, 1);
    } else {
        cart[index].quantity = newQuantity;
    }
    saveCart();
    renderCart();
}

// Function to render cart
function renderCart() {
    const cartTable = document.getElementById('cart-table');
    cartTable.innerHTML = `
        <tr>
            <th colspan="7">Giỏ hàng của bạn</th>
        </tr>
        <tr>
            <td style="width: 35px;">STT</td>
            <td style="width: 210px;">Hình ảnh</td>
            <td style="width: 150px;">Tên sản phẩm</td>
            <td style="width: 60px;">Số lượng</td>
            <td style="width: 100px;">Đơn giá</td>
            <td style="width: 100px;">Thành tiền</td>
            <td style="width: 50px;"></td>
        </tr>
    `;
    console.log(cartTable);

    let total = 0;
    cart.forEach((item, index) => {
        const row = cartTable.insertRow();
        row.innerHTML = `
            <td>${index + 1}</td>
            <td><img src="img/${item.img}" alt="${item.name}" style="height: 100px;"></td>
            <td>${item.name}</td>
            <td>
                <input type="number" value="${item.quantity}" min="1" style="width: 50px;" onchange="updateQuantity(${index}, this.value)">
            </td>
            <td>${item.price} VNĐ</td>
            <td>${(parseFloat(item.price.replace(/\./g, '')) * item.quantity).toLocaleString()} VNĐ</td>
            <td><button onclick="removeRow(this)">Xóa</button></td>
        `;
        total += parseFloat(item.price.replace(/\./g, '')) * item.quantity;
    });

    const totalRow = cartTable.insertRow();
    totalRow.innerHTML = `
        <th colspan="7">Tổng cộng: ${total.toLocaleString()} VNĐ</th>
    `;
}

// Function to handle payment
function payNow() {
    if (cart.length === 0) {
        alert("Giỏ hàng của bạn đang trống!");
    } else {
        alert("Thanh toán thành công!");
        cart = [];
        saveCart();
        renderCart();
    }
}

// Function to save cart to localStorage
function saveCart() {
    localStorage.setItem('cart', JSON.stringify(cart));
}

// Function to load cart from localStorage
function loadCart() {
    const savedCart = localStorage.getItem('cart');
    if (savedCart) {
        cart = JSON.parse(savedCart);
    }
}

// Initialize the product list and load cart from localStorage
window.onload = function() {
    loadCart();
    renderProducts();
    renderCart();
};