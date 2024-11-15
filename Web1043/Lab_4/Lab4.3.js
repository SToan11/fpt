function updateDateTime() {
  var now = new Date();

  // Lấy giờ, phút, giây
  var h = now.getHours();
  var m = now.getMinutes();
  var s = now.getSeconds();

  // Định dạng thời gian luôn có 2 kí tự
  h = h < 10 ? "0" + h : h;
  m = m < 10 ? "0" + m : m;
  s = s < 10 ? "0" + s : s;

  // Lấy ngày, tháng năm
  var day = now.getDate();
  var month = now.getMonth() + 1; //Tháng bắt đầu từ 0
  var year = now.getFullYear();

  // Định dạng ngày tháng năm luôn có 2 kí tự
  day = day < 10 ? "0" + day : day;
  month = month < 10 ? "0" + month : month;

  // Hiển thị ngày và thời gian hiện tại
  document.getElementById("date-time").innerText =
    day + "/" + month + "/" + year + " " + h + ":" + m + ":" + s;
}

// cập nhật ngày và giờ khi mở trang
updateDateTime();

// đặt thời gian tự động cập nhật mỗi giây
setInterval(updateDateTime, 1000);
