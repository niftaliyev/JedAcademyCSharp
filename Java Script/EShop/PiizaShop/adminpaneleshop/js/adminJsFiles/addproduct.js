let products = [];

document.forms.addProduct.addEventListener("submit", function () {
  event.preventDefault();

  const fileInput = document.getElementById("imageInput");
  const file = fileInput.files[0];

  if (file) {
    const reader = new FileReader();
    reader.onload = function (event) {
      const base64String = event.target.result;
      let product = {
        id: Date.now(),
        name: document.forms.addProduct.name.value,
        price: document.forms.addProduct.price.value,
        image: base64String,
        quantity: document.forms.addProduct.quantity.value
      };

      let productsLocalStorage = JSON.parse(localStorage.getItem('products'));
      if (productsLocalStorage) {
        productsLocalStorage.push(product);
        localStorage.setItem("products", JSON.stringify(productsLocalStorage));
      }else{
        products.push(product);
        localStorage.setItem("products", JSON.stringify(products));
      }
      document.forms.addProduct.reset();

    };
    reader.readAsDataURL(file);
  } else {
    alert("Please select a image first");
  }
});
