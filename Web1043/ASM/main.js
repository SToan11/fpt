var dataspjs = data.slice(0,8);
console.log(dataspjs);

for(let i =0; i < dataspjs.length; i++){
    document.getElementById('datasp').innerHTML +=
    `
         <div class="sanpham">
            <a href="chitiet.html">
                <img src="img/${dataspjs[i].img}" alt="">
                <h5>${dataspjs[i].name}</h5>
                <h4>${dataspjs[i].price}</h4>
                <button id="fm"><a href="giohang.html">Mua ngay</a> </button>
            </a>
        </div>
    `
}

document.addEventListener('DOMContentLoaded', function() {
    var products = document.querySelectorAll('.sanpham img');

    products.forEach(function(product) {
        product.addEventListener('mouseover', function() {
            product.style.transform = "scale(1)"; 
            product.style.transition = "transform 0.3s ease";
        });

        product.addEventListener('mouseout', function() {
            product.style.transform = "scale(0.8)";
            product.style.transition = "transform 0.3s ease"; 
        });
    });
});





var hinh = ['img/banner1.1.webp', 'img/banner1.2.webp', 'img/banner1.3.webp', 'img/banner1.4.webp', 'img/banner1.5.webp']

let i = 0;


function left(){
    i--;
    if(i < 0){
        i = hinh.length -1;
    }
    document.getElementById('banner').src = hinh[i];
}

function right(){
    i++;
    if(i == hinh.length){
        i=0
    }
    document.getElementById('banner').src = hinh[i];
}

setInterval(right,3000);






















// script.js
let slideIndex = 1;
showSlides(slideIndex);

// Next/previous controls
function plusSlides(n) {
  showSlides(slideIndex += n);
}

// Thumbnail image controls
function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides(n) {
  let i;
  let slides = document.getElementsByClassName("mySlides");
  let dots = document.getElementsByClassName("dot");
  if (n > slides.length) {slideIndex = 1}    
  if (n < 1) {slideIndex = slides.length}
  for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none";  
  }
  for (i = 0; i < dots.length; i++) {
      dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";  
  dots[slideIndex-1].className += " active";
}

// Auto slide
setInterval(function() {
  plusSlides(1);
}, 3000); // Change image every 3 seconds
