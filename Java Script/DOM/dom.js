
// console.log(document.children[0].children[1].children[0]);
// console.dir(document.children[0].children[1].children[0]);
// document.children[0].children[1].children[0].innerText = prompt().toString();

// let item = document.getElementById('text');
// item.innerText = "CHANGED";

// //getElementById
// document.getElementById('text').innerText = "test";

// //getElementsByClassName
// let elements = document.getElementsByClassName('box');
// console.log(elements);
// elements.innerText = 'HELLO';

// let elements = document.getElementsByClassName('box');

// for (const element of elements) {
//     element.innerText = 'HELLO';
// }

// let elem = document.getElementsByTagName('h1');
// console.log(elem);
// // elem[0].innerText = "TEST";

// for (const element of elem) {
//     element.innerText = 'HELLO';
// }

// let elem = document.querySelector('.box');
// console.log(elem);

let elem = document.querySelectorAll('.box');
for (const element of elem) {
    element.innerText = 'HELLO';
}