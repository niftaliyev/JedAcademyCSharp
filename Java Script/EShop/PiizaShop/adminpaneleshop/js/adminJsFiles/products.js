let products = JSON.parse(localStorage.getItem('products'));
let listProducts = document.getElementById('listProducts');

for (const product of products) {
    listProducts.innerHTML +=  `<div class="col-lg-3 col-md-6 col-12 ml-5 pt-3">
    <div class="card" style="width: 18rem;">
        <img src="${product.image}" class="card-img-top" alt="...">
        <div class="card-body">
          <h5 class="card-title">Name: ${product.name}</h5>
          <h5 class="card-title">Price: ${product.price}</h5>
          <h5 class="card-title">Quantity: <span style="color: red"> ${product.quantity}</span></h5>
        </div>
      </div>
    </div> `
}

