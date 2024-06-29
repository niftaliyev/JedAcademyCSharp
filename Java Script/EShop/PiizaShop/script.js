let products = JSON.parse(localStorage.getItem("products"));
let orders = [];

console.log(products);
let listProducts = document.getElementById("listProducts");

for (const product of products) {
  listProducts.innerHTML += `<div class="col-lg-3 col-md-6 col-12 ml-5 pt-3">
    <div class="card" style="width: 18rem;">
        <img src="${product.image}" class="card-img-top" alt="...">
        <div class="card-body">
          <h5 class="card-title">Name: ${product.name}</h5>
          <h5 class="card-title">Price: ${product.price}</h5>
          <h5 class="card-title">Quantity: <span style="color: red"> ${product.quantity}</span></h5>
          <button id="btnOrder" class="btn btn-primary">Add to cart</button>
        </div>
      </div>
    </div> `;
}

let buttons = document.querySelectorAll("#btnOrder");

for (const button of buttons) {
  button.addEventListener("click", function () {
    let productName = event.target.parentElement.querySelector("h5").innerText;
    let currentProduct = products.find((x) => productName.includes(x.name));
    let ordersInLocalStorage = JSON.parse(localStorage.getItem("orders"));
    if (ordersInLocalStorage) {
      let exsistOrder = ordersInLocalStorage.find((x) => productName.includes(x.name));
      if (exsistOrder) {
        currentProduct.Count = currentProduct.Count + 1;
        ordersInLocalStorage.push(currentProduct);

      }else{
        currentProduct.Count = 1;
        ordersInLocalStorage.push(currentProduct);
      }
      localStorage.setItem("orders", JSON.stringify(ordersInLocalStorage));
    } else {
      currentProduct.Count = 1;
      orders.push(currentProduct);
      localStorage.setItem("orders", JSON.stringify(orders));
    }
    if (orders) {
      let listOrders = document.getElementById("listOrders");
      for (const order of orders) {
        console.log(order.name);
        listOrders.innerHTML += `
      <li>${order.name}</li>
  
  `;
      }
    }
  });
}

document.getElementById("cardButton").addEventListener("click", function () {
  console.log("click card button");
  let ordersInLocalStorage = JSON.parse(localStorage.getItem("orders"));
  ordersInLocalStorage = distinctByProperty(ordersInLocalStorage,'name');

  if (ordersInLocalStorage) {
    let listOrders = document.getElementById("listOrders");
    listOrders.innerHTML = '';
    for (const order of ordersInLocalStorage) {
      console.log(order.name);
      listOrders.innerHTML += `
      <li>Name: ${order.name} Price: ${order.price} Count: ${order.Count}</li> 
  
  `;
    }
  }
});




function distinctByProperty(arr, prop) {
  const grouped = arr.reduce((acc, current) => {
    if (!acc[current[prop]]) {
      acc[current[prop]] = current;
    } else if (current.Count > acc[current[prop]].Count) {
      acc[current[prop]] = current;
    }
    return acc;
  }, {});

  return Object.values(grouped);
}